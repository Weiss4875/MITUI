using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UMod;
using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Events;
using Warudo.Core.Serializations;
using Warudo.Core.Utils;

namespace Warudo.Core.Plugins {
    public class PluginManager {
        private readonly List<Plugin> pluginList = new();
        private readonly Dictionary<string, Plugin> pluginMap = new();
        private PluginMonitor userPluginMonitor;

        public async UniTask LoadAndMonitorUserPlugins() {
            var pluginsPath = Application.streamingAssetsPath + "/Plugins";

            if (!Directory.Exists(pluginsPath)) {
                Directory.CreateDirectory(pluginsPath);
            }

            userPluginMonitor = new PluginMonitor(pluginsPath);
            await userPluginMonitor.Start();
        }

        public async UniTask<Plugin> EnablePlugin(Type type, ModHost modHost = null, Action<string> onPluginName = null) {
            if (pluginList.Any(it => it.GetType() == type)) {
                throw new ArgumentException($"Plugin of type {type.Name} is already enabled");
            }
            if (Context.PluginTypeRegistry.GetTypeMeta(type) == null) {
                var attribute = type.GetCustomAttribute<PluginTypeAttribute>();
                if (attribute == null) {
                    throw new Exception($"Plugin type {type.FriendlyFullName()} does not have an ID");
                }
                Context.PluginTypeRegistry.RegisterType(attribute.Id, type);
            }
            var meta = Context.PluginTypeRegistry.GetTypeMeta(type);
            var pluginType = meta.PluginType;
            onPluginName?.Invoke(pluginType.name);
            
            Debug.Log($"Enabling {pluginType.id} ({pluginType.version})");
            Plugin plugin;
            try {
                plugin = Context.PluginTypeRegistry.CreateEntity(pluginType.id, it => it.ModHost = modHost);
            } catch (Exception e) {
                Log.Error($"Failed to enable {pluginType.id} ({pluginType.version})", e);
                return null;
            }

            var serializedData = await LoadPluginData(pluginType.id);
            if (serializedData != null) {
                plugin.Deserialize(serializedData);
            } else {
                try {
                    plugin.OneTimeSetup();
                } catch (Exception e) {
                    Log.Error($"Failed to run one time setup for {pluginType.id} ({pluginType.version})", e);
                    return null;
                }
            }

            foreach (var nodeType in meta.NodeTypes) {
                try {
                    Context.NodeTypeRegistry.RegisterType(nodeType).OwnerPlugin = plugin;
                } catch (Exception e) {
                    Log.Error($"Could not register node type {nodeType.FriendlyFullName()}", e);
                }
            }
            
            foreach (var assetType in meta.AssetTypes) {
                try {
                    Context.AssetTypeRegistry.RegisterType(assetType).OwnerPlugin = plugin;
                } catch (Exception e) {
                    Log.Error($"Could not register asset type {assetType.FriendlyFullName()}", e);
                }
            }
            
            pluginList.Add(plugin);
            pluginMap[pluginType.id] = plugin;
            
            Context.EventBus.Broadcast(new PluginEnableEvent(plugin));

            if (modHost != null && Application.isEditor) {
                var names = modHost.Assets.FindAllRelativeNames();
                Debug.Log($"Found {names.Length} assets");
                foreach (var name in names) {
                    Debug.Log($"{name}");
                }
            }
            
            return plugin;
        }
        
        public async UniTask<T> EnablePlugin<T>(Action<string> onPluginName = null) where T : Plugin {
            return (T) await EnablePlugin(typeof(T), null, onPluginName);
        }

        public void DisablePlugin(Type type) {
            var plugin = pluginMap.Values.FirstOrDefault(it => it.GetType() == type);
            if (plugin == null) {
                throw new ArgumentOutOfRangeException($"Plugin of type {type} is not enabled");
            }
            DisablePlugin(plugin);
        }

        public void DisablePlugin(Plugin plugin) {
            var pluginType = plugin.Type.PluginType;
            if (!pluginMap.ContainsKey(pluginType.id)) {
                throw new ArgumentOutOfRangeException($"Plugin {pluginType.id} is not enabled");
            }
            
            Context.EventBus.Broadcast(new PluginDisableEvent(plugin));
            
            Debug.Log($"Destroying {pluginType.id} ({pluginType.version})");
            plugin.Destroy();

            if (plugin.ModHost != null) {
                try {
                    if (plugin.ModHost.IsModLoaded) {
                        plugin.ModHost.UnloadMod(false);
                    }
                } catch (Exception e) {
                    Log.Error($"Failed to unload mod {plugin.ModHost.name}", e);
                }
            }

            var scene = Context.OpenedScene;
            if (scene != null) {
                var removals = new List<Guid>();
                foreach (var (id, asset) in scene.GetAssets()) {
                    if (asset.Plugin == plugin) {
                        removals.Add(id);
                    }
                }
                removals.ForEach(scene.RemoveAsset);
                
                foreach (var (_, graph) in scene.GetGraphs()) {
                    removals.Clear();
                    foreach (var (id, node) in graph.GetNodes()) {
                        if (node.Plugin == plugin) {
                            removals.Add(id);
                        }
                    }
                    removals.ForEach(graph.RemoveNode);
                }
            }
            
            var meta = Context.PluginTypeRegistry.GetTypeMeta(plugin.GetType());
            foreach (var nodeType in meta.NodeTypes) {
                if (Context.NodeTypeRegistry.IsTypeRegistered(nodeType)) {
                    Context.NodeTypeRegistry.UnregisterType(nodeType);
                }
            }
            foreach (var assetType in meta.AssetTypes) {
                if (Context.AssetTypeRegistry.IsTypeRegistered(assetType)) {
                    Context.AssetTypeRegistry.UnregisterType(assetType);
                }
            }

            Context.ResourceManager.UnregisterAllProviders(plugin);
            Context.ResourceManager.UnregisterAllUriResolvers(plugin);
            Context.ResourceManager.UnregisterAllUriMetaResolvers(plugin);

            pluginList.Remove(plugin);
            pluginMap.Remove(pluginType.id);
        }

        public async UniTask<SerializedPlugin> LoadPluginData(string pluginId) {
            var path = $"Plugins/Data/{pluginId}.json";
            if (!Context.PersistentDataManager.HasFile(path)) return null;
            var data = Context.PersistentDataManager.ReadFile<SerializedPlugin>(path);
            if (data == null) return null;
            if (data.id == default) {
                data.id = Guid.NewGuid(); // Migrate entity change
            }
            return data;
        }

        public void SavePluginData(Plugin plugin) {
            Context.PersistentDataManager.WriteFile($"Plugins/Data/{plugin.Type.PluginType.id}.json", JsonConvert.SerializeObject(plugin.Serialize()));
        }

        public void SavePluginData() {
            foreach (var plugin in GetPlugins()) {
                SavePluginData(plugin);
            }
        }

        public T GetPlugin<T>() where T : Plugin {
            Plugin first = null;
            foreach (var it in pluginMap.Values) {
                if (it.GetType() == typeof(T)) {
                    first = it;
                    break;
                }
            }
            return (T) first;
        }
        
        public Plugin GetPlugin(string pluginId) {
            foreach (var it in pluginMap.Values) {
                if (it.Type.PluginType.id == pluginId) return it;
            }
            return null;
        }

        public List<Plugin> GetPlugins() {
            return pluginList;
        }

        public void Dispose() {
            userPluginMonitor?.Dispose();
            pluginMap.Values.ForEach(it => { 
                if (it.Created) it.Destroy();
            });
            pluginMap.Clear();
        }

        public void OnApplicationQuit() {
            userPluginMonitor?.Dispose();
            pluginMap.Values.ForEach(it => {
                it.OnApplicationQuit();
            });
        }

        public SerializedPluginList Serialize() {
            return new SerializedPluginList {
                plugins = pluginMap.ToDictionary(pair => pair.Value.Type.PluginType.id, pair => pair.Value.Serialize())
            };
        }
    }
}
