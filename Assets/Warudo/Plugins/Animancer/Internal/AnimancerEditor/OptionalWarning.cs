using System;
using UnityEngine;
using UnityEngine.Playables;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public enum OptionalWarning
    {
        ProOnly = 1 << 0,
        CreateGraphWhileDisabled = 1 << 1,
        CreateGraphDuringGuiEvent = 1 << 2,
        NativeControllerHumanoid = 1 << 3,
        NativeControllerHybrid = 1 << 4,
        DuplicateEvent = 1 << 5,
        EndEventInterrupt = 1 << 6,
        UselessEvent = 1 << 7,
        UnsupportedEvents = 1 << 8,
        UnsupportedSpeed = 1 << 9,
        UnsupportedIK = 1 << 10,
        MixerMinChildren = 1 << 11,
        MixerSynchronizeZeroLength = 1 << 12,
        CustomFadeBounds = 1 << 13,
        CustomFadeNotNull = 1 << 14,
        AnimatorSpeed = 1 << 15,
        UnusedNode = 1 << 16,
        PlayableAssetAnimatorBinding = 1 << 17,
        All = ~0,
    }

    public static partial class Validate
    {
        public static void Disable(this OptionalWarning type)
        {
            throw new NotImplementedException();
        }

        public static void Enable(this OptionalWarning type)
        {
            throw new NotImplementedException();
        }

        public static void SetEnabled(this OptionalWarning type, bool enable)
        {
            throw new NotImplementedException();
        }

        public static void Log(this OptionalWarning type, string message, object context = null)
        {
            throw new NotImplementedException();
        }
    }
}