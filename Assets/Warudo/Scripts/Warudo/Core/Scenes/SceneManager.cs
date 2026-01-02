using System;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;
using Warudo.Core.Localization;
using Warudo.Core.Serializations;
using Warudo.Core.Server;
using Warudo.Scripts.Warudo.Core.Events;

namespace Warudo.Core.Scenes {
    public class SceneManager {
        public SceneEntry[] GetScenes() {
            return Context.PersistentDataManager.GetFileEntries("Scenes", "*.json")
                .Select(it => new SceneEntry {
                    name = Path.GetFileNameWithoutExtension(it.path),
                    lastModifiedTime = it.lastModifiedTime
                })
                .OrderByDescending(it => it.lastModifiedTime)
                .ToArray();
        }

        public async UniTask SaveScene(string name, SerializedScene serializedScene, bool isNewScene = false) {
            serializedScene.name = name;
            var path = $"Scenes/{name}.json";
            if (Context.PersistentDataManager.HasFile(path)) {
                // Backup the old scene by copying the old file
                var fullPath = Context.PersistentDataManager.GetFullPath(path);
                File.Copy(fullPath, fullPath + ".autobackup", true);
            }
            await Context.PersistentDataManager.WriteFileAsync(path, JsonConvert.SerializeObject(serializedScene));
            // Delete the backup
            if (Context.PersistentDataManager.HasFile(path + ".autobackup")) {
                Context.PersistentDataManager.DeleteFile(path + ".autobackup");
            }
            Context.EventBus.Broadcast(new SceneSaveEvent(name, serializedScene, isNewScene));
            Context.Service?.Toast(ToastSeverity.Success, "SUCCESS", "SAVED_SCENE");
        }

        public void DeleteScene(string name) {
            var path = $"Scenes/{name}.json";
            Context.PersistentDataManager.DeleteFile(path);
        }
        
        public bool HasScene(string name) {
            var path = $"Scenes/{name}.json";
            return Context.PersistentDataManager.HasFile(path);
        }
        
        public async UniTask OpenScene(string name) {
            if (!HasScene(name)) {
                throw new Exception($"Scene {name} does not exist");
            }
            
            var path = $"Scenes/{name}.json";

            var serializedScene = await Context.PersistentDataManager.ReadFileAsync<SerializedScene>(path);
            await Context.Instance.OpenScene(serializedScene);
        }

        public SerializedScene LoadDefaultSceneTemplate() {
            var serializedScene = JsonConvert.DeserializeObject<SerializedScene>(
                Resources.Load<TextAsset>("Templates/Scenes/DefaultScene").text)!;
            
            // Localize asset names
            foreach (var serializedAsset in serializedScene.assets) {
                var assetId = serializedAsset.typeId;
                var asset = Context.AssetTypeRegistry.GetTypeMeta(assetId);
                serializedAsset.name = asset.AssetType.title.Localized();
            }

            return serializedScene;
        }
    }

    [Serializable]
    public class SceneEntry {
        public string name;
        public long lastModifiedTime;
    }
}
