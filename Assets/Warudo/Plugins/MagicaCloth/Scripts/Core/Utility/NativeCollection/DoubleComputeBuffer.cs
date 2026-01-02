using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class DoubleComputeBuffer<T> : IDisposable where T : struct
    {
        ComputeBuffer buffer0;
        ComputeBuffer buffer1;
        NativeArray<T> nativeArrya;
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Swap()
        {
            throw new NotImplementedException();
        }

        public void Create(int size, ComputeBufferType type, ComputeBufferMode usage)
        {
            throw new NotImplementedException();
        }

        public NativeArray<T> GetNativeArray()
        {
            throw new NotImplementedException();
        }

        public ComputeBuffer GetBuffer(int bufferIndex = 0)
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
    }
}