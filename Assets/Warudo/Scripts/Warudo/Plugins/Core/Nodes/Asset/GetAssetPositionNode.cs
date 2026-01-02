using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Graphs;
using Warudo.Plugins.Core.Assets;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Nodes
{
    public class GetAssetPositionNode : Node
    {
        public GameObjectAsset Asset;
        public Vector3 WorldPosition()
        {
            throw new NotImplementedException();
        }
    }
}