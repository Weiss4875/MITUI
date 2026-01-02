using System;
using System.Collections.Generic;
using Unity.Collections;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ExNativeHashMap<TKey, TValue>
        where TKey : unmanaged, IEquatable<TKey> where TValue : unmanaged
    {
        NativeHashMap<TKey, TValue> nativeHashMap;
        int nativeLength;
        HashSet<TKey> useKeySet = new HashSet<TKey>();
        public ExNativeHashMap()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public TValue Get(TKey key)
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

        public NativeHashMap<TKey, TValue> Map
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public HashSet<TKey> UseKeySet
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}