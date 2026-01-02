using System;
using System.Collections.Generic;
using Unity.Collections;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class FixedNativeListWithCount<T> : IDisposable where T : unmanaged
    {
        NativeList<T> nativeList;
        int nativeLength;
        Queue<int> emptyStack = new Queue<int>();
        HashSet<int> useIndexSet = new HashSet<int>();
        Dictionary<T, int> indexDict = new Dictionary<T, int>();
        Dictionary<T, int> countDict = new Dictionary<T, int>();
        T emptyElement;
        public FixedNativeListWithCount()
        {
            throw new NotImplementedException();
        }

        public FixedNativeListWithCount(int capacity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SetEmptyElement(T empty)
        {
            throw new NotImplementedException();
        }

        public int Add(T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new NotImplementedException();
        }

        public bool Exist(T element)
        {
            throw new NotImplementedException();
        }

        public int GetUseCount(T element)
        {
            throw new NotImplementedException();
        }

        public int Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public T this[int index]
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

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public NativeArray<T> ToJobArray()
        {
            throw new NotImplementedException();
        }
    }
}