using System;
using System.Collections.Generic;
using Unity.Collections;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ExNativeMultiHashMap<TKey, TValue>
        where TKey : unmanaged, IEquatable<TKey> where TValue : unmanaged
    {
        NativeMultiHashMap<TKey, TValue> nativeMultiHashMap;
        int nativeLength;
        Dictionary<TKey, int> useKeyDict = new Dictionary<TKey, int>();
        public ExNativeMultiHashMap()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool IsCreated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Remove(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Remove(Func<TKey, TValue, bool> func)
        {
            throw new NotImplementedException();
        }

        public void Replace(Func<TKey, TValue, bool> func, Func<TValue, TValue> datafunc)
        {
            throw new NotImplementedException();
        }

        public void Process(Action<TKey, TValue> act)
        {
            throw new NotImplementedException();
        }

        public void Process(TKey key, Action<TValue> act)
        {
            throw new NotImplementedException();
        }

        public bool Contains(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(TKey key)
        {
            throw new NotImplementedException();
        }

        public void Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public NativeMultiHashMap<TKey, TValue> Map
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}