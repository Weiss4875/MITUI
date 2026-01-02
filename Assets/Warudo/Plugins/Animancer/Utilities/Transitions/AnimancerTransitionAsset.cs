using UnityEngine;
using System;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public class AnimancerTransitionAsset : AnimancerTransitionAsset<ITransition>
    {
        public class UnShared<TAsset, TTransition, TState> : ITransition<TState>, ITransitionWithEvents, IWrapper where TAsset : AnimancerTransitionAsset<TTransition> where TTransition : ITransition<TState>, IHasEvents where TState : AnimancerState
        {
            public ref TAsset Asset => throw new NotImplementedException();
            object IWrapper.WrappedObject => throw new NotImplementedException();
            public ref TTransition Transition => throw new NotImplementedException();
            public virtual bool IsValid => throw new NotImplementedException();
            public AnimancerState BaseState
            {
                get => throw new NotImplementedException();
                private set
                {
                    throw new NotImplementedException();
                }
            }

            public TState State
            {
                get
                {
                    throw new NotImplementedException();
                }

                protected set
                {
                    throw new NotImplementedException();
                }
            }

            public virtual AnimancerEvent.Sequence Events
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            public virtual ref AnimancerEvent.Sequence.Serializable SerializedEvents => throw new NotImplementedException();
            public virtual void Apply(AnimancerState state)
            {
                throw new NotImplementedException();
            }

            public virtual object Key => throw new NotImplementedException();
            public virtual float FadeDuration => throw new NotImplementedException();
            public virtual FadeMode FadeMode => throw new NotImplementedException();
            public virtual TState CreateState() => throw new NotImplementedException();
            AnimancerState ITransition.CreateState() => throw new NotImplementedException();
        }
    }
}