using System;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public sealed class Float1ControllerState : ControllerState
    {
        public new interface ITransition : ITransition<Float1ControllerState>
        {
        }

        public new ParameterID ParameterID
        {
            get => throw new NotImplementedException();
            set
            {
                throw new NotImplementedException();
            }
        }

        public float Parameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Float1ControllerState(RuntimeAnimatorController controller, ParameterID parameter, bool keepStateOnStop = false) : base(controller, keepStateOnStop)
        {
            throw new NotImplementedException();
        }

        public override int ParameterCount => throw new NotImplementedException();
        public override int GetParameterHash(int index) => throw new NotImplementedException();
    }
}