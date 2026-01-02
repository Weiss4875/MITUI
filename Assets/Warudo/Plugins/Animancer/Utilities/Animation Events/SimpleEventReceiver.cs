using UnityEngine;
using UnityEngine.Serialization;
using System;
using Object = UnityEngine.Object;

namespace Animancer
{
    public class SimpleEventReceiver : MonoBehaviour
    {
        public ref AnimationEventReceiver OnEvent => throw new NotImplementedException();
    }
}