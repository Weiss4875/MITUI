using System;
using DG.Tweening;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Warudo.Plugins.Core.Utils
{
    public abstract class Tweener<T>
    {
        protected readonly Func<T> Getter;
        protected readonly Action<T> Setter;
        protected readonly float Duration;
        protected readonly float Delay;
        protected readonly Ease Ease;
        protected bool HasTargetValue;
        protected T TargetValue;
        protected Tween Tween;
        protected Tweener(Func<T> getter, Action<T> setter, float duration = 0.2f, float delay = 0f, Ease ease = Ease.OutCubic)
        {
            throw new NotImplementedException();
        }

        public void TweenTo(T targetValue)
        {
            throw new NotImplementedException();
        }

        protected abstract Tween CreateTween();
    }

    public class FloatTweener : Tweener<float>
    {
        public FloatTweener(Func<float> getter, Action<float> setter, float duration = 0.2f, float delay = 0f, Ease ease = Ease.OutCubic) : base(getter, setter, duration, delay, ease)
        {
            throw new NotImplementedException();
        }

        protected override Tween CreateTween()
        {
            throw new NotImplementedException();
        }
    }

    public class Vector3Tweener : Tweener<Vector3>
    {
        public Vector3Tweener(Func<Vector3> getter, Action<Vector3> setter, float duration = 0.2f, float delay = 0f, Ease ease = Ease.OutCubic) : base(getter, setter, duration, delay, ease)
        {
            throw new NotImplementedException();
        }

        protected override Tween CreateTween()
        {
            throw new NotImplementedException();
        }
    }

    public class QuaternionTweener : Tweener<Quaternion>
    {
        public QuaternionTweener(Func<Quaternion> getter, Action<Quaternion> setter, float duration = 0.2f, float delay = 0f, Ease ease = Ease.OutCubic) : base(getter, setter, duration, delay, ease)
        {
            throw new NotImplementedException();
        }

        protected override Tween CreateTween()
        {
            throw new NotImplementedException();
        }
    }
}