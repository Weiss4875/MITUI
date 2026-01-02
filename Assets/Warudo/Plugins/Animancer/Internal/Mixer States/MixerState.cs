using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public abstract partial class MixerState : AnimancerState
    {
        public interface ITransition2D : ITransition<MixerState<Vector2>>
        {
        }

        public override bool KeepChildrenConnected => throw new NotImplementedException();
        public override AnimationClip Clip => throw new NotImplementedException();
        public abstract IList<AnimancerState> ChildStates { get; }

        public override int ChildCount => throw new NotImplementedException();
        public override AnimancerState GetChild(int index) => throw new NotImplementedException();
        public override FastEnumerator<AnimancerState> GetEnumerator() => throw new NotImplementedException();
        protected override void OnSetIsPlaying()
        {
            throw new NotImplementedException();
        }

        public override bool IsLooping
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override float RawTime
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void MoveTime(float time, bool normalized)
        {
            throw new NotImplementedException();
        }

        public override float Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void CreatePlayable(out Playable playable)
        {
            throw new NotImplementedException();
        }

        public ClipState CreateChild(int index, AnimationClip clip)
        {
            throw new NotImplementedException();
        }

        public AnimancerState CreateChild(int index, ITransition transition)
        {
            throw new NotImplementedException();
        }

        public AnimancerState CreateChild(int index, Object state)
        {
            throw new NotImplementedException();
        }

        public void SetChild(int index, AnimancerState state) => throw new NotImplementedException();
        protected internal override void OnAddChild(AnimancerState state)
        {
            throw new NotImplementedException();
        }

        protected internal override void OnRemoveChild(AnimancerState state)
        {
            throw new NotImplementedException();
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public void DestroyChildren()
        {
            throw new NotImplementedException();
        }

        public AnimationScriptPlayable CreatePlayable<T>(AnimancerPlayable root, T job, bool processInputs = false)
            where T : struct, IAnimationJob
        {
            throw new NotImplementedException();
        }

        protected void CreatePlayable<T>(out Playable playable, T job, bool processInputs = false)
            where T : struct, IAnimationJob
        {
            throw new NotImplementedException();
        }

        public T GetJobData<T>()
            where T : struct, IAnimationJob => throw new NotImplementedException();
        public void SetJobData<T>(T value)
            where T : struct, IAnimationJob => throw new NotImplementedException();
        protected internal override void Update(out bool needsMoreUpdates)
        {
            throw new NotImplementedException();
        }

        public bool WeightsAreDirty { get; set; }

        public bool RecalculateWeights()
        {
            throw new NotImplementedException();
        }

        protected virtual void ForceRecalculateWeights()
        {
            throw new NotImplementedException();
        }

        public static bool AutoSynchronizeChildren { get; set; }

        public static float MinimumSynchronizeChildrenWeight { get; set; }

        public AnimancerState[] SynchronizedChildren
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public int SynchronizedChildCount => throw new NotImplementedException();
        public bool IsSynchronized(AnimancerState state)
        {
            throw new NotImplementedException();
        }

        public void Synchronize(AnimancerState state)
        {
            throw new NotImplementedException();
        }

        public void DontSynchronize(AnimancerState state)
        {
            throw new NotImplementedException();
        }

        public void DontSynchronizeChildren()
        {
            throw new NotImplementedException();
        }

        public void InitializeSynchronizedChildren(params bool[] synchronizeChildren)
        {
            throw new NotImplementedException();
        }

        public MixerState GetParentMixer()
        {
            throw new NotImplementedException();
        }

        public static MixerState GetParentMixer(IPlayableWrapper node)
        {
            throw new NotImplementedException();
        }

        public static bool IsChildOf(IPlayableWrapper child, IPlayableWrapper parent)
        {
            throw new NotImplementedException();
        }

        protected void ApplySynchronizeChildren(ref bool needsMoreUpdates)
        {
            throw new NotImplementedException();
        }

        public float CalculateRealEffectiveSpeed()
        {
            throw new NotImplementedException();
        }

        public override bool ApplyAnimatorIK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override bool ApplyFootIK { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float CalculateTotalWeight(IList<AnimancerState> states)
        {
            throw new NotImplementedException();
        }

        public void SetChildrenTime(float value, bool normalized = false)
        {
            throw new NotImplementedException();
        }

        protected void DisableRemainingStates(int previousIndex)
        {
            throw new NotImplementedException();
        }

        protected AnimancerState GetNextState(ref int index)
        {
            throw new NotImplementedException();
        }

        public void NormalizeWeights(float totalWeight)
        {
            throw new NotImplementedException();
        }

        public virtual string GetDisplayKey(AnimancerState state) => throw new NotImplementedException();
        public override Vector3 AverageVelocity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void NormalizeDurations()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        protected override void AppendDetails(StringBuilder text, string separator)
        {
            throw new NotImplementedException();
        }

        public override void GatherAnimationClips(ICollection<AnimationClip> clips) => throw new NotImplementedException();
    }
}