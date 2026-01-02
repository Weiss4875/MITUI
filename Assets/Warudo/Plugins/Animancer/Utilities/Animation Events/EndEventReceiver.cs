using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public class EndEventReceiver : MonoBehaviour
    {
        public ref AnimancerComponent Animancer => throw new NotImplementedException();
        public static AnimationEvent CurrentEvent { get; private set; }

        public static bool End(AnimancerComponent animancer, AnimationEvent animationEvent)
        {
            throw new NotImplementedException();
        }

        public static float GetFadeOutDuration(float minDuration)
        {
            throw new NotImplementedException();
        }

        public static float GetFadeOutDuration() => throw new NotImplementedException();
    }
}