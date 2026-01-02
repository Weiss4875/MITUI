using System;
using System.Collections.Generic;
using Unity.Collections;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class FixedNativeList<T> : IDisposable where T : struct
    {
        NativeArray<T> nativeArray0;
        NativeArray<T> nativeArray1;
        int nativeLength;
        Queue<int> emptyStack = new Queue<int>();
        HashSet<int> useIndexSet = new HashSet<int>();
        int useLength;
        public FixedNativeList()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Add(T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int index)
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

        public NativeArray<T> ToJobArray(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        public void SyncBuffer()
        {
            throw new NotImplementedException();
        }
    }
}