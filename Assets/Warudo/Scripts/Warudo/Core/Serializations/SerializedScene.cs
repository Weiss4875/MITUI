using System;
using System.Collections.Generic;
using Warudo.Core.Localization;

namespace Warudo.Core.Serializations {
    [Serializable]
    public class SerializedScene : ILocalizable {
        public string name;
        public Guid selectedAssetId;
        public Guid selectedGraphId;
        public List<SerializedAsset> assets;
        public List<SerializedGraph> graphs;
        public Dictionary<string, PluginSceneData> plugins;

        public void Localize() {
            assets.ForEach(it => it.Localize());
            graphs.ForEach(it => it.Localize());
        }
    }

    [Serializable]
    public class PluginSceneData {
        public string version;
        public string data;
    }
}
