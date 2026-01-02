using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public class ControllerState : AnimancerState
    {
        public interface ITransition : ITransition<ControllerState>
        {
        }

        public RuntimeAnimatorController Controller { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override Object MainObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AnimatorControllerPlayable Playable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool KeepStateOnStop
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public int[] DefaultStateHashes { get; set; }

        public override void CopyIKFlags(AnimancerNode node)
        {
            throw new NotImplementedException();
        }

        public override bool ApplyAnimatorIK
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public override bool ApplyFootIK
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public ControllerState(RuntimeAnimatorController controller, bool keepStateOnStop = false)
        {
            throw new NotImplementedException();
        }

        protected override void CreatePlayable(out Playable playable)
        {
            throw new NotImplementedException();
        }

        public override void RecreatePlayable()
        {
            throw new NotImplementedException();
        }

        public AnimatorStateInfo StateInfo
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

        public override float Length => throw new NotImplementedException();
        public override bool IsLooping => throw new NotImplementedException();
        public void GatherDefaultStates()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public void ResetToDefaultStates()
        {
            throw new NotImplementedException();
        }

        public override void GatherAnimationClips(ICollection<AnimationClip> clips)
        {
            throw new NotImplementedException();
        }

        public override void Destroy()
        {
            throw new NotImplementedException();
        }

        public const float DefaultFadeDuration = -1;
        public static float GetFadeDuration(float fadeDuration) => throw new NotImplementedException();
        public void CrossFade(int stateNameHash, float fadeDuration = DefaultFadeDuration, int layer = -1, float normalizedTime = float.NegativeInfinity) => throw new NotImplementedException();
        public void CrossFade(string stateName, float fadeDuration = DefaultFadeDuration, int layer = -1, float normalizedTime = float.NegativeInfinity) => throw new NotImplementedException();
        public void CrossFadeInFixedTime(int stateNameHash, float fadeDuration = DefaultFadeDuration, int layer = -1, float fixedTime = 0) => throw new NotImplementedException();
        public void CrossFadeInFixedTime(string stateName, float fadeDuration = DefaultFadeDuration, int layer = -1, float fixedTime = 0) => throw new NotImplementedException();
        public void Play(int stateNameHash, int layer = -1, float normalizedTime = float.NegativeInfinity) => throw new NotImplementedException();
        public void Play(string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity) => throw new NotImplementedException();
        public void PlayInFixedTime(int stateNameHash, int layer = -1, float fixedTime = 0) => throw new NotImplementedException();
        public void PlayInFixedTime(string stateName, int layer = -1, float fixedTime = 0) => throw new NotImplementedException();
        public bool GetBool(int id) => throw new NotImplementedException();
        public bool GetBool(string name) => throw new NotImplementedException();
        public void SetBool(int id, bool value) => throw new NotImplementedException();
        public void SetBool(string name, bool value) => throw new NotImplementedException();
        public float GetFloat(int id) => throw new NotImplementedException();
        public float GetFloat(string name) => throw new NotImplementedException();
        public void SetFloat(int id, float value) => throw new NotImplementedException();
        public void SetFloat(string name, float value) => throw new NotImplementedException();
        public int GetInteger(int id) => throw new NotImplementedException();
        public int GetInteger(string name) => throw new NotImplementedException();
        public void SetInteger(int id, int value) => throw new NotImplementedException();
        public void SetInteger(string name, int value) => throw new NotImplementedException();
        public void SetTrigger(int id) => throw new NotImplementedException();
        public void SetTrigger(string name) => throw new NotImplementedException();
        public void ResetTrigger(int id) => throw new NotImplementedException();
        public void ResetTrigger(string name) => throw new NotImplementedException();
        public AnimatorControllerParameter GetParameter(int index) => throw new NotImplementedException();
        public int GetParameterCount() => throw new NotImplementedException();
        public bool IsParameterControlledByCurve(int id) => throw new NotImplementedException();
        public bool IsParameterControlledByCurve(string name) => throw new NotImplementedException();
        public float GetLayerWeight(int layerIndex) => throw new NotImplementedException();
        public void SetLayerWeight(int layerIndex, float weight) => throw new NotImplementedException();
        public int GetLayerCount() => throw new NotImplementedException();
        public int GetLayerIndex(string layerName) => throw new NotImplementedException();
        public string GetLayerName(int layerIndex) => throw new NotImplementedException();
        public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex = 0) => throw new NotImplementedException();
        public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex = 0) => throw new NotImplementedException();
        public bool HasState(int layerIndex, int stateID) => throw new NotImplementedException();
        public bool IsInTransition(int layerIndex = 0) => throw new NotImplementedException();
        public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex = 0) => throw new NotImplementedException();
        public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex = 0) => throw new NotImplementedException();
        public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) => throw new NotImplementedException();
        public int GetCurrentAnimatorClipInfoCount(int layerIndex = 0) => throw new NotImplementedException();
        public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex = 0) => throw new NotImplementedException();
        public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips) => throw new NotImplementedException();
        public int GetNextAnimatorClipInfoCount(int layerIndex = 0) => throw new NotImplementedException();
        public readonly struct ParameterID
        {
            public readonly string Name;
            public readonly int Hash;
            public ParameterID(string name)
            {
                throw new NotImplementedException();
            }

            public ParameterID(int hash)
            {
                throw new NotImplementedException();
            }

            public ParameterID(string name, int hash)
            {
                throw new NotImplementedException();
            }

            public static implicit operator ParameterID(string name)
            {
                throw new NotImplementedException();
            }

            public static implicit operator ParameterID(int hash)
            {
                throw new NotImplementedException();
            }

            public static implicit operator int (ParameterID parameter)
            {
                throw new NotImplementedException();
            }

            public void ValidateHasParameter(RuntimeAnimatorController controller, AnimatorControllerParameterType type)
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

        public virtual int ParameterCount => throw new NotImplementedException();
        public virtual int GetParameterHash(int index) => throw new NotImplementedException();
    }
}