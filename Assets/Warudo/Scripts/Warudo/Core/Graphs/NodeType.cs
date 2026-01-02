using System;
using Warudo.Core.Localization;

namespace Warudo.Core.Graphs {
    [Serializable]
    public class NodeType : ILocalizable {
        public string id;
        public string title;
        public string category;
        public string searchHint;
        public float width = 1f;

        public void Localize() {
            title = title.Localized();
            category = category.Localized();
        }
        
        public NodeType Clone() {
            return new NodeType{
                id = id,
                title = title,
                category = category,
                searchHint = searchHint,
                width = width
            };
        }
    }
}
