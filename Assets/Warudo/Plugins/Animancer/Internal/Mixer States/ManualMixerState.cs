using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public partial class ManualMixerState : MixerState
    {
        public interface ITransition : ITransition<ManualMixerState>
        {
        }

        public override IList<AnimancerState> ChildStates => throw new NotImplementedException();
        public override int ChildCount => throw new NotImplementedException();
        public override AnimancerState GetChild(int index) => throw new NotImplementedException();
        public override FastEnumerator<AnimancerState> GetEnumerator() => throw new NotImplementedException();
        public virtual void Initialize(int childCount)
        {
            throw new NotImplementedException();
        }

        public void Initialize(params AnimationClip[] clips)
        {
            throw new NotImplementedException();
        }

        public void Initialize(params Object[] animations)
        {
            throw new NotImplementedException();
        }
    }
}