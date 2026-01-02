using System;
using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Animancer.FSM
{
    public partial class StateMachine<TState>
        where TState : class, IState
    {
        public TState CurrentState { get; private set; }

        public TState PreviousState => throw new NotImplementedException();
        public TState NextState => throw new NotImplementedException();
        public StateMachine()
        {
            throw new NotImplementedException();
        }

        public StateMachine(TState state)
        {
            throw new NotImplementedException();
        }

        public bool CanSetState(TState state)
        {
            throw new NotImplementedException();
        }

        public TState CanSetState(IList<TState> states)
        {
            throw new NotImplementedException();
        }

        public bool TrySetState(TState state)
        {
            throw new NotImplementedException();
        }

        public bool TrySetState(IList<TState> states)
        {
            throw new NotImplementedException();
        }

        public bool TryResetState(TState state)
        {
            throw new NotImplementedException();
        }

        public bool TryResetState(IList<TState> states)
        {
            throw new NotImplementedException();
        }

        public void ForceSetState(TState state)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => throw new NotImplementedException();
        public void SetAllowNullStates(bool allow = true)
        {
            throw new NotImplementedException();
        }
    }
}