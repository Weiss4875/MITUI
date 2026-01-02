using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public class HybridAnimancerComponent : NamedAnimancerComponent
    {
        public ref ControllerTransition Controller => throw new NotImplementedException();
        protected override void OnEnable()
        {
            throw new NotImplementedException();
        }

        public override void GatherAnimationClips(ICollection<AnimationClip> clips)
        {
            throw new NotImplementedException();
        }

        public ControllerState PlayController()
        {
            throw new NotImplementedException();
        }

        public void CrossFade(int stateNameHash, float fadeDuration = ControllerState.DefaultFadeDuration, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }

        public AnimancerState CrossFade(string stateName, float fadeDuration = ControllerState.DefaultFadeDuration, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }

        public void CrossFadeInFixedTime(int stateNameHash, float fadeDuration = ControllerState.DefaultFadeDuration, int layer = -1, float fixedTime = 0)
        {
            throw new NotImplementedException();
        }

        public AnimancerState CrossFadeInFixedTime(string stateName, float fadeDuration = ControllerState.DefaultFadeDuration, int layer = -1, float fixedTime = 0)
        {
            throw new NotImplementedException();
        }

        public void Play(int stateNameHash, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }

        public AnimancerState Play(string stateName, int layer = -1, float normalizedTime = float.NegativeInfinity)
        {
            throw new NotImplementedException();
        }

        public void PlayInFixedTime(int stateNameHash, int layer = -1, float fixedTime = 0)
        {
            throw new NotImplementedException();
        }

        public AnimancerState PlayInFixedTime(string stateName, int layer = -1, float fixedTime = 0)
        {
            throw new NotImplementedException();
        }

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
    }
}