using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;
using Warudo.Core.Data;
using Warudo.Core.Events;
using Warudo.Core.Graphs;
using Warudo.Core.Localization;
using Warudo.Core.Scenes;
using Warudo.Core.Serializations;
using Warudo.Core.Utils;
using Warudo.Plugins.Core.Events;
using WebSocketSharp;

namespace Warudo.Core.Server {
    public class Service : WebSocketService, IClient, IService {

        public const int Port = 19052;

        public static void Clear() {
            ReceivedConfirmations.Clear();
            ReceivedStructuredDataInputs.Clear();
            PromptMessageQueue.Clear();
        }
        
        private static Scene Scene => Context.OpenedScene;
        private static Context Context => Context.Instance;
        
        private static readonly Dictionary<string, Dictionary<Guid, bool?>> ReceivedConfirmations = new();
        private static readonly Dictionary<string, Dictionary<Guid, StructuredDataResult>> ReceivedStructuredDataInputs = new();
        private static readonly List<(string header, string message, bool markdown)> PromptMessageQueue = new();

        private enum StructuredDataResult {
            Waiting, Submitted, Canceled
        }
        
        protected override async UniTask<bool> HandleAction(string action, JObject data) {
            await UniTask.SwitchToMainThread();
            switch (action) {
                // Prompts
                case "confirmation":
                    if (!ReceivedConfirmations.ContainsKey(ID)) {
                        ReceivedConfirmations[ID] = new();
                    }
                    ReceivedConfirmations[ID][Guid.Parse((string)data["id"])] = (bool)data["confirm"];
                    if (Flags.Get("DebugService", false)) {
                        Debug.Log($"Received confirmation from client {ID} for id {data["id"]}, confirmed: {data["confirm"]}");
                    }
                    return true;
                case "structuredDataInput":
                    if (!ReceivedStructuredDataInputs.ContainsKey(ID)) {
                        ReceivedStructuredDataInputs[ID] = new();
                    }
                    ReceivedStructuredDataInputs[ID][Guid.Parse((string)data["id"])] = (bool) data["cancel"] ? StructuredDataResult.Canceled : StructuredDataResult.Submitted;
                    if (Flags.Get("DebugService", false)) {
                        Debug.Log($"Received structured data input from client {ID} for id {data["id"]}, canceled: {data["cancel"]}");
                    }
                    return true;
                // Entities
                case "setEntityDataInputPortValue":
                    SetEntityDataInputPortValue(Guid.Parse((string) data["id"]), (string) data["port"], (string) data["value"]);
                    return true;
                case "resetEntityDataInputPortValue":
                    ResetEntityDataInputPortValue(Guid.Parse((string) data["id"]), (string) data["port"]);
                    return true;
                case "invokeEntityTriggerPort":
                    InvokeEntityTriggerPort(Guid.Parse((string) data["id"]), (string) data["port"]);
                    return true;
                case "appendEntityDataInputPortArray":
                    AppendEntityDataInputPortArray(Guid.Parse((string)data["id"]), (string)data["port"]);
                    return true;
                case "setEntityDataInputPortArrayElement":
                    SetEntityDataInputPortArrayElement(Guid.Parse((string)data["id"]), (string)data["port"], (int)data["index"], (string) data["value"]);
                    return true;
                case "removeEntityDataInputPortArrayElement":
                    RemoveEntityDataInputPortArrayElement(Guid.Parse((string)data["id"]), (string)data["port"], (int)data["index"]);
                    return true;
                case "moveEntityDataInputPortArrayElement":
                    MoveEntityDataInputPortArrayElement(Guid.Parse((string)data["id"]), (string)data["port"], (int)data["fromIndex"], (int)data["toIndex"]);
                    return true;
                // Plugins
                case "getPlugins":
                    GetPlugins();
                    return true;
                // Assets
                case "getSelectedAsset":
                    GetSelectedAsset();
                    return true;
                case "setSelectedAsset":
                    SetSelectedAsset((string) data["asset"] != null ? Guid.Parse((string) data["asset"]) : Guid.Empty);
                    return true;
                case "getAssetTypeList":
                    GetAssetTypeList();
                    return true;
                case "addAssetOfType":
                    AddAssetOfType((string) data["type"]);
                    return true;
                case "addAsset":
                    AddAsset(((JObject)data["asset"]).ToObject<SerializedAsset>());
                    return true;
                case "removeAsset":
                    RemoveAsset(Guid.Parse((string) data["asset"]));
                    return true;
                case "setAssetName":
                    SetAssetName(Guid.Parse((string) data["asset"]), (string) data["name"]);
                    return true;
                case "duplicateAsset":
                    DuplicateAsset(Guid.Parse((string) data["asset"]));
                    return true;
                case "importAsset":
                    ImportAsset((string) data["json"]);
                    return true;
                case "applyAssetProperties":
                    ApplyAssetProperties(Guid.Parse((string) data["asset"]), (string) data["json"]);
                    return true;
                case "exportAsset":
                    ExportAsset(Guid.Parse((string) data["asset"]));
                    return true;
                // Graphs
                case "addGraph":
                    AddGraph();
                    return true;
                case "removeGraph":
                    RemoveGraph(Guid.Parse((string) data["graph"]));
                    return true;
                case "setGraphName":
                    SetGraphName(Guid.Parse((string) data["graph"]), (string) data["name"]);
                    return true;
                case "setGraphEnabled":
                    SetGraphEnabled(Guid.Parse((string) data["graph"]), (bool) data["enabled"]);
                    return true;
                case "getSelectedGraph":
                    GetSelectedGraph();
                    return true;
                case "setSelectedGraph":
                    SetSelectedGraph((string) data["graph"] != null ? Guid.Parse((string) data["graph"]) : Guid.Empty);
                    return true;
                case "getNodeTypeList":
                    GetNodeTypeList();
                    return true;
                case "addDataConnection":
                    AddDataConnection(Guid.Parse((string)data["graph"]), Guid.Parse((string)data["outputNode"]), Guid.Parse((string)data["inputNode"]), (string)data["outputPort"], (string)data["inputPort"]);
                    return true;
                case "addFlowConnection":
                    AddFlowConnection(Guid.Parse((string)data["graph"]), Guid.Parse((string)data["outputNode"]), Guid.Parse((string)data["inputNode"]), (string)data["outputPort"], (string)data["inputPort"]);
                    return true;
                case "removeDataConnection":
                    RemoveDataConnection(Guid.Parse((string)data["graph"]), Guid.Parse((string)data["outputNode"]), Guid.Parse((string)data["inputNode"]), (string)data["outputPort"], (string)data["inputPort"]);
                    return true;
                case "removeFlowConnection":
                    RemoveFlowConnection(Guid.Parse((string)data["graph"]), Guid.Parse((string)data["outputNode"]), Guid.Parse((string)data["inputNode"]), (string)data["outputPort"], (string)data["inputPort"]);
                    return true;
                case "addNodeOfType":
                    AddNodeOfType(Guid.Parse((string)data["graph"]), (string)data["type"], (float) data["x"], (float) data["y"]);
                    return true;
                case "addNode":
                    AddNode(Guid.Parse((string)data["graph"]), ((JObject)data["node"]).ToObject<SerializedNode>());
                    return true;
                case "removeNode":
                    RemoveNode(Guid.Parse((string)data["graph"]), Guid.Parse((string)data["node"]));
                    return true;
                case "setNodePosition":
                    SetNodePosition(Guid.Parse((string)data["graph"]), Guid.Parse((string) data["node"]), (float) data["x"], (float) data["y"]);
                    return true;
                case "setPanning":
                    SetPanning(Guid.Parse((string)data["graph"]), (float) data["x"], (float) data["y"]);
                    return true;
                case "setScaling":
                    SetScaling(Guid.Parse((string)data["graph"]), (float) data["scaling"]);
                    return true;
                case "duplicateGraph":
                    DuplicateGraph(Guid.Parse((string) data["graph"]));
                    return true;
                case "importGraph":
                    ImportGraph((string) data["json"]);
                    return true;
                case "exportGraph":
                    ExportGraph(Guid.Parse((string) data["graph"]));
                    return true;
                case "invokeFlowAtInput":
                    InvokeFlowAtInput(Guid.Parse((string) data["graph"]), Guid.Parse((string) data["node"]), (string) data["inputPort"]);
                    return true;
                // Others
                case "getAutoCompleteLists":
                    GetAutoCompleteLists(data["ids"].ToObject<string[]>()!.Select(Guid.Parse));
                    return true;
                case "resolveResourceUriMeta":
                    ResolveResourceUriMeta(data["uris"].ToObject<string[]>()!
                        .Select(s => Uri.TryCreate(s, UriKind.Absolute, out var uri) ? uri : null)
                        .Where(it => it != null));
                    return true;
                case "getEnumTypes":
                    GetEnumTypes(data["types"].ToObject<string[]>()!);
                    return true;
                case "getActiveLanguage":
                    GetActiveLanguage();
                    return true;
                case "getDataConverters":
                    GetDataConverters();
                    return true;
                case "sendPluginMessage":
                    SendPluginMessage((string) data["pluginId"], (string) data["action"], (string) data["payload"]);
                    return true;
                case "setStructuredDataCollapsed":
                    SetStructuredDataCollapsed(Guid.Parse((string) data["structuredDataId"]), (bool) data["collapsed"]);
                    return true;
                case "onConnected":
                    OnConnected();
                    return true;
            }
            return false;
        }
        
        #region Entities
        
        public void SetEntityDataInputPortValue(Guid entityId, string portKey, string value) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(portKey);
            if (port == null) throw new Exception($"Data input port {portKey} does not exist on entity {entityId}");
            
            port.SetSerializedValue(value, Scene, entity);
            Respond("setEntityDataInputPortValue", true);
            // var newSerializedValue = port.SerializeValue();
            // if (newSerializedValue != value) {
            //     // TODO: Can this really happen?
            //     // BroadcastEntityDataInputPortValue(entityId, portKey, newSerializedValue);
            //     Respond("setEntityDataInputPortValue", false);
            // } else {
            //     Respond("setEntityDataInputPortValue", true);
            // }
        }
        
        public void ResetEntityDataInputPortValue(Guid entityId, string portKey) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(portKey);
            if (port == null) throw new Exception($"Data input port {portKey} does not exist on entity {entityId}");

            entity.ResetDataInput(portKey);
            Respond("resetEntityDataInputPortValue", true);
        }
        
        public void InvokeEntityTriggerPort(Guid entityId, string portKey) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.TriggerPortCollection.GetPort(portKey);
            if (port == null) throw new Exception($"Trigger port {portKey} does not exist on entity {entityId}");

            port.OnTrigger();
            Respond("invokeEntityTriggerPort", true);
        }
        
        public void AppendEntityDataInputPortArray(Guid entityId, string arrayPortKey) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(arrayPortKey);
            if (port == null) throw new Exception($"Data input port {arrayPortKey} does not exist on entity {entityId}");

            if (!port.Type.GetKind().IsArray()) throw new Exception($"Data input port {arrayPortKey} on entity {entityId} is not an array");
            
            var el = port.AppendArray(Scene, entity.StructuredDataParent);
            
            // TODO: Broadcast array change
            Respond("appendEntityDataInputPortArray", DataInputPort.Serialize(port.Type.GetElementType()!, el));
        }
        
        public void SetEntityDataInputPortArrayElement(Guid entityId, string arrayPortKey, int index, string value) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(arrayPortKey);
            if (port == null) throw new Exception($"Data input port {arrayPortKey} does not exist on entity {entityId}");
            
            if (!port.Type.GetKind().IsArray()) throw new Exception($"Data input port {arrayPortKey} on entity {entityId} is not an array");
            
            var el = port.SetSerializedArrayElement(index, value, Scene, entity);
            
            // TODO: Broadcast array change
            Respond("setEntityDataInputPortArrayElement", DataInputPort.Serialize(port.Type.GetElementType()!, el));
        }
        
        public void RemoveEntityDataInputPortArrayElement(Guid entityId, string arrayPortKey, int index) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(arrayPortKey);
            if (port == null) throw new Exception($"Data input port {arrayPortKey} does not exist on entity {entityId}");

            if (!port.Type.GetKind().IsArray()) throw new Exception($"Data input port {arrayPortKey} on entity {entityId} is not an array");
            port.RemoveArrayElement(index);
            
            // TODO: Broadcast array change
            Respond("removeEntityDataInputPortArrayElement", true);
        }
        
        public void MoveEntityDataInputPortArrayElement(Guid entityId, string arrayPortKey, int fromIndex, int toIndex) {
            var entity = Context.EntityStore.Get(entityId);
            if (entity == null) throw new Exception($"Entity {entityId} does not exist");

            var port = entity.DataInputPortCollection.GetPort(arrayPortKey);
            if (port == null) throw new Exception($"Data input port {arrayPortKey} does not exist on entity {entityId}");

            if (!port.Type.GetKind().IsArray()) throw new Exception($"Data input port {arrayPortKey} on entity {entityId} is not an array");
            port.MoveArrayElement(fromIndex, toIndex);
            
            // TODO: Broadcast array change
            Respond("moveEntityDataInputPortArrayElement", true);
        }

        #endregion

        #region Plugins

        public void GetPlugins() {
            var plugins = Context.PluginManager.Serialize();
            
            Respond("getPlugins", plugins);
        }

        #endregion
        
        #region Assets
        
        public void GetSelectedAsset() {
            if (Scene == null) {
                Respond("getSelectedAsset", null);
                return;
            }
            var asset = Scene.GetSelectedAsset();

            Respond("getSelectedAsset", asset?.Id);
        }
        
        public void SetSelectedAsset(Guid assetId) {
            if (Scene == null) {
                Respond("setSelectedAsset", true);
                return;
            }
            Scene.SetSelectedAsset(assetId);
            
            Respond("setSelectedAsset", true);
        }        
        
        public void GetAssetTypeList() {
            Respond("getAssetTypeList", Context.AssetTypeRegistry.Serialize());
        }
        
        public void AddAssetOfType(string type) {
            var asset = Scene.AddAsset(type);
            asset.EvaluateClientFunctions();
            Context.EventBus.Broadcast(new ServiceAddAssetEvent(asset));
            Respond("addAssetOfType", asset.Serialize());
        }

        public void AddAsset(SerializedAsset asset) {
            var instance = Scene.DeserializeAsset(asset);
            if (instance == null) {
                throw new Exception($"Could not add asset {asset.id}");
            }
            instance.EvaluateClientFunctions();
            Context.EventBus.Broadcast(new ServiceAddAssetEvent(instance));
            Respond("addAsset", instance.Serialize());
        }

        public void RemoveAsset(Guid assetId) {
            var asset = Scene.GetAsset(assetId);
            if (asset == null) throw new Exception($"Asset {assetId} does not exist");

            Scene.RemoveAsset(assetId);

            Respond("removeAsset", true);
        }
        
        public void DuplicateAsset(Guid assetId) {
            var asset = Scene.GetAsset(assetId);
            if (asset == null) throw new Exception($"Asset {assetId} does not exist");

            var serializedAsset = asset.Serialize();
            serializedAsset.id = Guid.NewGuid();
            
            var duplicatedAsset = Scene.DeserializeAsset(serializedAsset);
            
            Respond("duplicateAsset:" + assetId, duplicatedAsset?.Serialize());
        }

        public void SetAssetName(Guid assetId, string name) {
            var asset = Scene.GetAsset(assetId);
            if (asset == null) throw new Exception($"Asset {assetId} does not exist");
            
            asset.Name = name;
            Respond("setAssetName", true);
        }
        
        public void ImportAsset(string serializedAssetString) {
            try {
                var serializedAsset = JsonConvert.DeserializeObject<SerializedAsset>(serializedAssetString);
                if (serializedAsset == null) throw new Exception("Could not deserialize asset");

                if (Scene.GetAssets().ContainsKey(serializedAsset.id)) {
                    serializedAsset.id = Guid.NewGuid();
                }

                var asset = Scene.DeserializeAsset(serializedAsset);
                Respond("importAsset", asset.Serialize());
            } catch (Exception e) {
                Log.UserError("Could not import asset", e);
                
                Respond("importAsset", false);
            }
        }

        public void ApplyAssetProperties(Guid assetId, string serializedAssetString) {
            try {
                var serializedAsset = JsonConvert.DeserializeObject<SerializedAsset>(serializedAssetString);
                if (serializedAsset == null) throw new Exception("Could not deserialize asset");

                if (!Scene.GetAssets().ContainsKey(assetId)) {
                    throw new Exception($"Asset {assetId} does not exist");
                }
                
                var asset = Scene.GetAsset(assetId);
                serializedAsset.id = assetId;
                asset.Deserialize(serializedAsset);
                Respond("applyAssetProperties:" + assetId, asset.Serialize());
            } catch (Exception e) {
                Log.UserError("Could not apply asset properties", e);
                
                Respond("applyAssetProperties:" + assetId, false);
            }
        }
        
        public void ExportAsset(Guid assetId) {
            var asset = Scene.GetAsset(assetId);
            if (asset == null) throw new Exception($"Asset {assetId} does not exist");
            
            var serializedAsset = asset.Serialize();
            Respond("exportAsset:" + assetId, JsonConvert.SerializeObject(new ReducedSerializedAsset(serializedAsset)));
        }

        public void AddGraph() {
            var graph = new Graph();
            graph.Name = "NEW_GRAPH".Localized();
            graph.Enabled = true;
            Scene.AddGraph(graph);

            Respond("addGraph", graph.Serialize());
        }

        public void RemoveGraph(Guid graphId) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) {
                throw new Exception($"Graph {graphId} does not exist");
            }

            Scene.RemoveGraph(graphId);
            Respond("removeGraph", true);
        }
        
        public void DuplicateGraph(Guid graphId) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) {
                throw new Exception($"Graph {graphId} does not exist");
            }

            var serializedGraph = graph.Serialize();
            serializedGraph.id = Guid.NewGuid();
            
            // Change IDs of nodes
            var duplicatedNodes = new Dictionary<Guid, SerializedNode>();
            var idMapping = new Dictionary<Guid, Guid>();
            foreach (var (id, serializedNode) in serializedGraph.nodes) {
                var newId = Guid.NewGuid();
                idMapping[id] = newId;
                serializedNode.id = newId;
                duplicatedNodes[newId] = serializedNode;
            }
            serializedGraph.nodes = duplicatedNodes;
            
            // Change node IDs of connections
            serializedGraph.dataConnections = serializedGraph.dataConnections.Select(it => it.Clone()).ToList();
            foreach (var serializedConnection in serializedGraph.dataConnections) {
                serializedConnection.outputNode = idMapping[serializedConnection.outputNode];
                serializedConnection.inputNode = idMapping[serializedConnection.inputNode];
            }
            serializedGraph.flowConnections = serializedGraph.flowConnections.Select(it => it.Clone()).ToList();
            foreach (var serializedConnection in serializedGraph.flowConnections) {
                serializedConnection.outputNode = idMapping[serializedConnection.outputNode];
                serializedConnection.inputNode = idMapping[serializedConnection.inputNode];
            }
            
            // Change ID of properties structured data
            serializedGraph.properties.id = Guid.NewGuid();
            
            var duplicatedGraph = Scene.DeserializeGraph(serializedGraph);
            
            Respond("duplicateGraph:" + graphId, duplicatedGraph.Serialize());
        }

        public void SetGraphName(Guid graphId, string name) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) {
                throw new Exception($"Graph {graphId} does not exist");
            }

            graph.Name = name;
            Respond("setGraphName", true);
        }
        
        public void SetGraphEnabled(Guid graphId, bool enabled) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) {
                throw new Exception($"Graph {graphId} does not exist");
            }

            graph.Enabled = enabled;
            Respond("setGraphEnabled", true);
        }

        #endregion
        
        #region Graphs

        public void GetSelectedGraph() {
            var graph = Scene.GetSelectedGraph();

            Respond("getSelectedGraph", graph?.Id);
        }
        
        public void SetSelectedGraph(Guid graphId) {
            Scene.SetSelectedGraph(graphId);
            
            Respond("setSelectedGraph", true);
        }

        public void GetNodeTypeList() {
            Respond("getNodeTypeList", Context.NodeTypeRegistry.Serialize());
        }

        public void AddDataConnection(Guid graphId, Guid outputNodeId, Guid inputNodeId, string outputPortKey, string inputPortKey) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var outputNode = graph.GetNode(outputNodeId);
            if (outputNode == null) throw new Exception($"Node {outputNodeId} does not exist");
            var inputNode = graph.GetNode(inputNodeId);
            if (inputNode == null) throw new Exception($"Node {inputNodeId} does not exist");

            Respond("addDataConnection", graph.AddDataConnection(outputNode, outputPortKey, inputNode, inputPortKey));
        }

        public void AddFlowConnection(Guid graphId, Guid outputNodeId, Guid inputNodeId, string outputPortKey, string inputPortKey) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var outputNode = graph.GetNode(outputNodeId);
            if (outputNode == null) throw new Exception($"Node {outputNodeId} does not exist");
            var inputNode = graph.GetNode(inputNodeId);
            if (inputNode == null) throw new Exception($"Node {inputNodeId} does not exist");

            Respond("addFlowConnection", graph.AddFlowConnection(outputNode, outputPortKey, inputNode, inputPortKey));
        }
        
        public void RemoveDataConnection(Guid graphId, Guid outputNodeId, Guid inputNodeId, string outputPortKey, string inputPortKey) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var outputNode = graph.GetNode(outputNodeId);
            if (outputNode == null) throw new Exception($"Node {outputNodeId} does not exist");
            var inputNode = graph.GetNode(inputNodeId);
            if (inputNode == null) throw new Exception($"Node {inputNodeId} does not exist");
            
            graph.RemoveDataConnection(outputNode, outputPortKey, inputNode, inputPortKey);

            Respond("removeDataConnection", true);
        }
        
        public void RemoveFlowConnection(Guid graphId, Guid outputNodeId, Guid inputNodeId, string outputPortKey, string inputPortKey) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var outputNode = graph.GetNode(outputNodeId);
            if (outputNode == null) throw new Exception($"Node {outputNodeId} does not exist");
            var inputNode = graph.GetNode(inputNodeId);
            if (inputNode == null) throw new Exception($"Node {inputNodeId} does not exist");
            
            graph.RemoveFlowConnection(outputNode, outputPortKey, inputNode, inputPortKey);

            Respond("removeFlowConnection", true);
        }

        public void AddNodeOfType(Guid graphId, string type, float x, float y) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            
            var node = graph.AddNode(type);
            node.GraphPosition = new Vector2(x, y);
            node.EvaluateClientFunctions();
            
            Respond("addNodeOfType", node.Serialize());
        }
        
        public void AddNode(Guid graphId, SerializedNode node) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");

            var instance = graph.DeserializeNode(node);
            instance.EvaluateClientFunctions();
            
            Respond("addNode:" + node.id, instance.Serialize());
        }

        public void RemoveNode(Guid graphId, Guid nodeId) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var node = graph.GetNode(nodeId);
            if (node != null) {
                graph.RemoveNode(nodeId);
            }

            Respond("removeNode", true);
        }

        public void SetNodePosition(Guid graphId, Guid nodeId, float x, float y) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            var node = graph.GetNode(nodeId);
            if (node == null) throw new Exception($"Node {nodeId} does not exist");

            node.GraphPosition = new Vector2(x, y);
        }

        public void SetPanning(Guid graphId, float x, float y) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            graph.PanningX = x;
            graph.PanningY = y;
        }

        public void SetScaling(Guid graphId, float scaling) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            graph.Scaling = scaling;
        }
        
        public void ImportGraph(string serializedGraphString) {
            try {
                var serializedGraph = JsonConvert.DeserializeObject<SerializedGraph>(serializedGraphString);
                if (serializedGraph == null) throw new Exception("Could not deserialize graph");

                if (Scene.GetGraphs().ContainsKey(serializedGraph.id)) {
                    serializedGraph.id = Guid.NewGuid();
                }
                
                var newNodes = new Dictionary<Guid, SerializedNode>();
                var idMapping = new Dictionary<Guid, Guid>();
                
                // Replace node IDs that already exist
                foreach (var (id, serializedNode) in serializedGraph.nodes) {
                    if (Scene.GetGraphs().Any(it => it.Value.GetNode(id) != null)) {
                        var newId = Guid.NewGuid();
                        idMapping[id] = newId;
                        serializedNode.id = newId;
                    }
                    newNodes[serializedNode.id] = serializedNode;
                }
                serializedGraph.nodes = newNodes;
                
                // Change node IDs of connections
                foreach (var serializedConnection in serializedGraph.dataConnections) {
                    if (idMapping.ContainsKey(serializedConnection.outputNode)) {
                        serializedConnection.outputNode = idMapping[serializedConnection.outputNode];
                    }
                    if (idMapping.ContainsKey(serializedConnection.inputNode)) {
                        serializedConnection.inputNode = idMapping[serializedConnection.inputNode];
                    }
                }
                foreach (var serializedConnection in serializedGraph.flowConnections) {
                    if (idMapping.ContainsKey(serializedConnection.outputNode)) {
                        serializedConnection.outputNode = idMapping[serializedConnection.outputNode];
                    }
                    if (idMapping.ContainsKey(serializedConnection.inputNode)) {
                        serializedConnection.inputNode = idMapping[serializedConnection.inputNode];
                    }
                }
                
                // Change ID of properties structured data
                serializedGraph.properties.id = Guid.NewGuid();

                var graph = Scene.DeserializeGraph(serializedGraph);
                
                Respond("importGraph", graph.Serialize());
            } catch (Exception e) {
                Log.UserError($"Could not import graph", e);
                
                Respond("importGraph", false);
            }
        }
        
        public void ExportGraph(Guid graphId) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");
            
            var serializedGraph = graph.Serialize();
            Respond("exportGraph:" + graphId, JsonConvert.SerializeObject(new ReducedSerializedGraph(serializedGraph)));
        }
        
        public void InvokeFlowAtInput(Guid graphId, Guid nodeId, string inputPortKey) {
            var graph = Scene.GetGraph(graphId);
            if (graph == null) throw new Exception($"Graph {graphId} does not exist");

            var node = graph.GetNode(nodeId);
            if (node == null) throw new Exception($"Node {nodeId} does not exist");

            graph.InvokeFlowAtInput(node, inputPortKey, true);
            Respond("invokeFlowAtInput", true);
        }

        #endregion

        #region Others

        public void GetEnumTypes(IEnumerable<string> types) {
            var result = new Dictionary<string, EnumType>();
            foreach (var type in types) {
                if (result.ContainsKey(type)) continue;
                
                var enumType = Context.TypeRegistry.GetType(type);
                if (enumType == null) {
                    Log.Error($"Enum type {type} does not exist");
                    result[type] = null;
                    continue;
                }
                var serializedEnumType = Context.TypeRegistry.GetSerializedEnumType(enumType);
                // Filter out known unwanted enum values
                if (enumType == typeof(HumanBodyBones)) {
                    serializedEnumType.members = serializedEnumType.members.Where(it => it.value != (long)HumanBodyBones.LastBone).OrderBy(it => it.value).ToArray();
                } else if (enumType == typeof(Ease)) {
                    serializedEnumType.members = serializedEnumType.members.Where(it => it.value != (long)Ease.INTERNAL_Custom).OrderBy(it => it.value).ToArray();
                }
                
                serializedEnumType.Localize();
                result[type] = serializedEnumType;
            }
            Respond("getEnumTypes", result);
        }
        
        public async void GetAutoCompleteLists(IEnumerable<Guid> ids) {
            var result = new Dictionary<string, AutoCompleteList>();
            foreach (var id in ids) {
                if (result.ContainsKey(id.ToString())) continue;
                try {
                    var list = await Context.AutoCompleteManager.Provide(id);
                    list.Localize();
                    result[id.ToString()] = list;
                } catch (Exception e) {
                    Log.UserError("Failed to provide auto complete lists", e);
                    var list = AutoCompleteList.Message("AN_ERROR_HAS_OCCURRED");
                    list.Localize();
                    result[id.ToString()] = list;
                }
            }
            Respond("getAutoCompleteLists", result);
        }
        
        public async void ResolveResourceUriMeta(IEnumerable<Uri> uris) {
            Respond("resolveResourceUriMeta", await Context.ResourceManager.ResolveResourceUriMeta(uris));
        }

        public void GetActiveLanguage() {
            var activeLanguage = Context.LocalizationManager.GetActiveLanguage();
            Respond("getActiveLanguage", activeLanguage);
        }
        
        public void GetDataConverters() {
            Respond("getDataConverters", DataConverters.Serialize());
        }
        
        public void OnConnected() {
            Respond("onConnected", true);
            
            if (PromptMessageQueue.Count > 0) {
                for (var index = PromptMessageQueue.Count - 1; index >= 0; index--) {
                    var message = PromptMessageQueue[index];
                    PromptMessage(message.header, message.message, message.markdown);
                }
                PromptMessageQueue.Clear();
            }

            Context.EventBus.Broadcast(new ClientConnectedEvent(MostRecentClientId));
        }
        
        public void SendPluginMessage(string pluginId, string action, string payload) {
            var plugin = Context.PluginManager.GetPlugin(pluginId);
            if (plugin == null) throw new Exception($"Plugin {pluginId} does not exist");
            plugin.OnMessageReceived(action, payload);
            Respond("sendPluginMessage", true);
        }
        
        public void SetStructuredDataCollapsed(Guid structuredDataId, bool collapsed) {
            var sd = Context.EntityStore.Get(structuredDataId);
            if (sd == null) throw new Exception($"Structured data {structuredDataId} does not exist");
            if (sd is not StructuredData structuredData) throw new Exception($"Entity {structuredDataId} is not a structured data");
            structuredData.CollapsedSelf = collapsed;
            Respond("setStructuredDataCollapsed", true);
        }

        #endregion

        #region Service

        public void BroadcastOpenedScene() {
            if (Scene == null) return;
            Broadcast("scene", Scene.Serialize());
        }

        public void BroadcastPluginSceneData(string pluginId) {
            Broadcast("pluginSceneData", new {
                pluginId,
                data = Scene.GetPluginData(pluginId)
            });
        }

        public void BroadcastEntityDataInputPortValue(Guid id, string port, string value) {
            Broadcast("entityDataInputPortValue", new {
                id,
                port,
                value
            });
        }
        
        public void BroadcastFrameUpdate(FrameUpdate update) {
            var jObject = new JObject();
            if (update.entities.Count > 0) {
                jObject["entities"] = JToken.FromObject(update.entities);
            }
            if (update.entityData.Count > 0) {
                jObject["entityData"] = JToken.FromObject(update.entityData);
            }
            if (update.entityDataInputProperties.Count > 0) {
                jObject["entityDataInputProperties"] = JToken.FromObject(update.entityDataInputProperties
                    .ToDictionary(e => e.Key, e => e.Value.ToDictionary(x => x.Key, x => {
                        var localizedDataProperties = x.Value.Clone();
                        localizedDataProperties.Localize();
                        return localizedDataProperties;
                    })));
            }
            if (update.entityDataOutputProperties.Count > 0) {
                jObject["entityDataOutputProperties"] = JToken.FromObject(update.entityDataOutputProperties
                    .ToDictionary(e => e.Key, e => e.Value.ToDictionary(x => x.Key, x => {
                        var localizedDataProperties = x.Value.Clone();
                        localizedDataProperties.Localize();
                        return localizedDataProperties;
                    })));
            }
            if (update.entityTriggerProperties.Count > 0) {
                jObject["entityTriggerProperties"] = JToken.FromObject(update.entityTriggerProperties
                    .ToDictionary(e => e.Key, e => e.Value.ToDictionary(x => x.Key, x => {
                        var localizedTriggerProperties = x.Value.Clone();
                        localizedTriggerProperties.Localize();
                        return localizedTriggerProperties;
                    })));
            }
            if (update.structuredDataHeaders.Count > 0) {
                jObject["structuredDataHeaders"] = JToken.FromObject(update.structuredDataHeaders
                    .ToDictionary(e => e.Key, e => e.Value.Localized()));
            }
            if (update.assetActiveStates.Count > 0) {
                jObject["assetActiveStates"] = JToken.FromObject(update.assetActiveStates);
            }
            if (update.messages.Count > 0) {
                jObject["messages"] = JToken.FromObject(update.messages);
            }
            Broadcast("frameUpdate", jObject);
        }

        public void BroadcastDataConverters(SerializedDataConverters dataConverters) {
            if (debouncedBroadcastDataConverters == null) {
                debouncedBroadcastDataConverters = Debouncer.Create<SerializedDataConverters>(it => {
                    Broadcast("dataConverters", it);
                }, TimeSpan.FromSeconds(1));
            }
            debouncedBroadcastDataConverters(dataConverters);
        }

        private Action<SerializedDataConverters> debouncedBroadcastDataConverters;

        public void BroadcastAssetTypeList(SerializedAssetTypeList assetTypes) {
            Broadcast("assetTypeList", assetTypes);
        }

        public void BroadcastAssetRemoved(Guid assetId) {
            Broadcast("assetRemoved", new {
                asset = assetId
            });
        }
        
        public void BroadcastGraphEnabled(Guid graphId, bool enabled) {
            Broadcast("graphEnabled", new {
                graph = graphId,
                enabled
            });
        }

        public void BroadcastNodeTypeList(SerializedNodeTypeList nodeTypeList) {
            Broadcast("nodeTypeList", nodeTypeList);
        }

        public void BroadcastFlow(Guid graphId, SerializedFlow flow) {
            Broadcast("flow", new {
                graph = graphId,
                flow
            }, false);
        }

        public void BroadcastActiveLanguage(string activeLanguage) {
            Broadcast("activeLanguage", activeLanguage);
        }
        
        public void Toast(ToastSeverity severity, string header, string summary, string message = null, TimeSpan duration = default) {
            if (duration == default) {
                duration = TimeSpan.FromSeconds(5);
            }
            Broadcast("toast", new {
                severity,
                header = header.Localized(),
                summary = summary.Localized(),
                message = message.Localized(),
                duration = duration.TotalMilliseconds
            });
        }
        
        public void Toast(string clientId, ToastSeverity severity, string header, string summary, string message = null, TimeSpan duration = default) {
            if (duration == default) {
                duration = TimeSpan.FromSeconds(5);
            }
            SendToClient(clientId, "toast", new {
                severity,
                header = header.Localized(),
                summary = summary.Localized(),
                message = message.Localized(),
                duration = duration.TotalMilliseconds
            });
        }

        public void PromptMessage(string header, string message, bool markdown = false) {
            PromptMessage(MostRecentClientId, header, message, markdown);
        }
        
        public void PromptMessage(string clientId, string header, string message, bool markdown = false) {
            if (clientId == null || Sessions == null || Sessions.Count == 0) {
                PromptMessageQueue.Add((header, message, markdown));
                return;
            }
            SendToClient(clientId, "promptMessage", new {
                header = header.Localized(),
                message = message.Localized(),
                markdown
            });
        }

        public async UniTask<bool> PromptConfirmation(string header, string message) {
            return await PromptConfirmation(MostRecentClientId, header, message);
        }
        
        public async UniTask<bool> PromptConfirmation(string clientId, string header, string message) {
            if (!ReceivedConfirmations.ContainsKey(clientId)) {
                ReceivedConfirmations[clientId] = new();
            }
            
            var id = Guid.NewGuid();
            ReceivedConfirmations[clientId][id] = null;
            SendToClient(clientId, "promptConfirmation", new {
                id,
                header = header.Localized(),
                message = message.Localized()
            });
            
            if (Flags.Get("DebugService", false)) {
                Debug.Log("Started waiting for confirmation from client " + clientId + " for id " + id);
            }
            await UniTask.WaitUntil(() => ReceivedConfirmations[clientId][id].HasValue);
            SendToClient(clientId, "confirmation:" + id, true);
            return ReceivedConfirmations[clientId][id]!.Value;
        }

        public async UniTask<T> PromptStructuredDataInput<T>(string header, T structuredData = default) where T : StructuredData {
            return await PromptStructuredDataInput(MostRecentClientId, header, structuredData);
        }
        
        public async UniTask<T> PromptStructuredDataInput<T>(string header, Action<T> structuredDataInitializer) where T : StructuredData {
            return await PromptStructuredDataInput(MostRecentClientId, header, null, structuredDataInitializer);
        }
        
        public async UniTask<T> PromptStructuredDataInput<T>(string clientId, string header, T structuredData = default, Action<T> structuredDataInitializer = null) where T : StructuredData {
            if (!ReceivedStructuredDataInputs.ContainsKey(clientId)) {
                ReceivedStructuredDataInputs[clientId] = new();
            }

            structuredData ??= (T)Context.StructuredDataTypeRegistry.CreateEntity(typeof(T));
            structuredData.Scene = Context.OpenedScene;
            structuredDataInitializer?.Invoke(structuredData);

            var id = Guid.NewGuid();
            ReceivedStructuredDataInputs[clientId][id] = StructuredDataResult.Waiting;
            SendToClient(clientId, "promptStructuredDataInput", new {
                id,
                header = header.Localized(),
                structuredData = structuredData.Serialize()
            });

            if (Flags.Get("DebugService", false)) {
                Debug.Log("Started waiting for structured data input from client " + clientId + " for id " + id);
            }
            await UniTask.WaitUntil(() => ReceivedStructuredDataInputs[clientId][id] != StructuredDataResult.Waiting);
            SendToClient(clientId, "structuredDataInput:" + id, true);
            return ReceivedStructuredDataInputs[clientId][id] == StructuredDataResult.Submitted ? structuredData : null;
        }

        public void ShowProgress(string message, float progress = -1f, TimeSpan timeout = default) {
            if (timeout == default) {
                timeout = TimeSpan.FromSeconds(30);
            }
            Broadcast("showProgress", new {
                message = message.Localized(),
                progress,
                timeout = timeout.TotalMilliseconds
            });
        }

        public void HideProgress() {
            Broadcast("hideProgress", new {});
        }

        public void NavigateToAsset(Guid assetId, string port = default) {
            Scene.SetSelectedAsset(assetId);
            Broadcast("navigateToAsset", new {
                assetId,
                port
            });
        }
        
        public void NavigateToGraph(Guid graphId, Guid nodeId = default) {
            Scene.SetSelectedGraph(graphId);
            Broadcast("navigateToGraph", new {
                graphId,
                nodeId
            });
        }
        
        public void NavigateToPlugin(string pluginId, string port = default) {
            Broadcast("navigateToPlugin", new {
                pluginId,
                port
            });
        }

        protected override void OnClose(CloseEventArgs e) {
            if (ReceivedConfirmations.ContainsKey(ID)) {
                foreach (var (key, _) in ReceivedConfirmations[ID]) {
                    ReceivedConfirmations[ID][key] = false;
                }
            }
            if (ReceivedStructuredDataInputs.ContainsKey(ID)) {
                foreach (var (key, _) in ReceivedStructuredDataInputs[ID]) {
                    ReceivedStructuredDataInputs[ID][key] = StructuredDataResult.Canceled;
                }
            }
        }

        #endregion
    }
}
