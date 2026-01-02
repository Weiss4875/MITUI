using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Utils;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Assets.Environment
{
    public abstract class LightAsset : GameObjectAsset
    {
        protected abstract bool IsRangeSupported();
        public Color Color = new(0.9960784314f, 0.9921568627f, 0.9803921569f);
        public float Range = 10f;
        protected bool HideRange() => throw new NotImplementedException();
        public float Intensity = 1f;
        public bool AffectCharacters = true;
        public bool AffectProps = true;
        public bool AffectEnvironment = false;
        public bool ShadowEnabled = false;
        public float ShadowIntensity = 1f;
        public bool SoftShadows = true;
        public float ShadowBias = 0.05f;
        public float ShadowNormalBias = 0.4f;
        protected Light Light;
        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        protected override void OnDestroy()
        {
            throw new NotImplementedException();
        }
    }
}