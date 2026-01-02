using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class BaseComponent : MonoBehaviour
    {
        public abstract ComponentType GetComponentType();
    }
}