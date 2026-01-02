using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class FixedChunkNativeArray<T> : IDisposable where T : struct
    {
        NativeArray<T> nativeArray0;
        NativeArray<T> nativeArray1;
        int nativeLength;
        List<ChunkData> emptyChunkList = new List<ChunkData>();
        List<ChunkData> useChunkList = new List<ChunkData>();
        int chunkSeed;
        int initLength = 64;
        T emptyElement;
        int useLength;
        public FixedChunkNativeArray()
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

        public ChunkData AddChunk(int length)
        {
            throw new NotImplementedException();
        }

        public ChunkData Add(T data)
        {
            throw new NotImplementedException();
        }

        public void RemoveChunk(int chunkNo)
        {
            throw new NotImplementedException();
        }

        public void RemoveChunk(ChunkData chunk)
        {
            throw new NotImplementedException();
        }

        public void Fill(ChunkData chunk, T data)
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

        public int ChunkCount
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

        public NativeArray<T> ToJobArray()
        {
            throw new NotImplementedException();
        }

        public NativeArray<T> ToJobArray(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        public void SwapBuffer()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}