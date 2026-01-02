using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class CreateSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static void InitMember()
        {
            throw new NotImplementedException();
        }

        public static T Instance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static bool IsInstance()
        {
            throw new NotImplementedException();
        }

        protected virtual void Awake()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDestroy()
        {
            throw new NotImplementedException();
        }

        protected virtual void DuplicateDetection(T duplicate)
        {
            throw new NotImplementedException();
        }

        protected abstract void InitSingleton();
    }
}