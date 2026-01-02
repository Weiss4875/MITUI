using System;
using System.Text;
using UnityEngine;
using UnityEngine.Animations;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public abstract class MixerState<TParameter> : ManualMixerState
    {
        public TParameter Parameter
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasThresholds => throw new NotImplementedException();
        public TParameter GetThreshold(int index) => throw new NotImplementedException();
        public void SetThreshold(int index, TParameter threshold)
        {
            throw new NotImplementedException();
        }

        public void SetThresholds(params TParameter[] thresholds)
        {
            throw new NotImplementedException();
        }

        public bool ValidateThresholdCount()
        {
            throw new NotImplementedException();
        }

        public virtual void OnThresholdsChanged()
        {
            throw new NotImplementedException();
        }

        public void CalculateThresholds(Func<AnimancerState, TParameter> calculate)
        {
            throw new NotImplementedException();
        }

        public override void RecreatePlayable()
        {
            throw new NotImplementedException();
        }

        public override void Initialize(int portCount)
        {
            throw new NotImplementedException();
        }

        public void Initialize(AnimationClip[] clips, TParameter[] thresholds)
        {
            throw new NotImplementedException();
        }

        public void Initialize(AnimationClip[] clips, Func<AnimancerState, TParameter> calculateThreshold)
        {
            throw new NotImplementedException();
        }

        public ClipState CreateChild(int index, AnimationClip clip, TParameter threshold)
        {
            throw new NotImplementedException();
        }

        public AnimancerState CreateChild(int index, Animancer.ITransition transition, TParameter threshold)
        {
            throw new NotImplementedException();
        }

        public void SetChild(int index, AnimancerState state, TParameter threshold)
        {
            throw new NotImplementedException();
        }

        public override string GetDisplayKey(AnimancerState state) => throw new NotImplementedException();
        protected override void AppendDetails(StringBuilder text, string separator)
        {
            throw new NotImplementedException();
        }

        public virtual void AppendParameter(StringBuilder description, TParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}