using System;
using UnityEngine;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public class MixerTransition2DAsset : AnimancerTransitionAsset<MixerTransition2D>
    {
        public class UnShared : AnimancerTransitionAsset.UnShared<MixerTransition2DAsset, MixerTransition2D, MixerState<Vector2>>, MixerState.ITransition2D
        {
        }
    }

    public class MixerTransition2D : MixerTransition<MixerState<Vector2>, Vector2>, MixerState.ITransition2D
    {
        public enum MixerType
        {
            Cartesian,
            Directional,
        }

        public ref MixerType Type => throw new NotImplementedException();
        public override MixerState<Vector2> CreateState()
        {
            throw new NotImplementedException();
        }
    }
}