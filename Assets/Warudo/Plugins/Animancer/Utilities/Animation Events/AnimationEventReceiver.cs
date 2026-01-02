using System;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;
using System;

namespace Animancer
{
    public struct AnimationEventReceiver
    {
        public AnimancerState Source
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

        public Action<AnimationEvent> Callback { get; set; }

        public AnimationEventReceiver(AnimancerState source, Action<AnimationEvent> callback)
        {
            throw new NotImplementedException();
        }

        public void Set(AnimancerState source, Action<AnimationEvent> callback)
        {
            throw new NotImplementedException();
        }

        public void SetFunctionName(string name)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool HandleEvent(AnimationEvent animationEvent)
        {
            throw new NotImplementedException();
        }
    }
}