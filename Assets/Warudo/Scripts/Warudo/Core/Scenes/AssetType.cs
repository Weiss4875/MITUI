using System;
using Newtonsoft.Json;
using Warudo.Core.Localization;
using Warudo.Core.Rendering;

namespace Warudo.Core.Scenes {
    [Serializable]
    public class AssetType : ILocalizable {
        public string id;
        public string title;
        public string category;
        public int categoryOrder;
        public bool userModifiable;
        public bool singleton;
        public RenderingPipeline[] supportedRenderingPipelines;

        public void Localize() {
            title = title.Localized();
            category = category.Localized();
        }
        
        public AssetType Clone() {
            return new AssetType {
                id = id,
                title = title,
                category = category,
                categoryOrder = categoryOrder,
                userModifiable = userModifiable,
                singleton = singleton,
                supportedRenderingPipelines = supportedRenderingPipelines
            };
        }
    }
}
