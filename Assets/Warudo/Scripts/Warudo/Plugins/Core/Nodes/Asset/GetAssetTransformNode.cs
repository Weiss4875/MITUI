using Warudo.Core.Attributes;
using Warudo.Core.Data;
using Warudo.Core.Data.Models;
using Warudo.Core.Graphs;
using Warudo.Plugins.Core.Assets;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Nodes
{
    public class GetAssetTransformNode : Node
    {
        public GameObjectAsset Asset;
        public TransformData Transform()
        {
            throw new NotImplementedException();
        }
    }
}