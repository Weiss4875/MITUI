using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class FixedMultiNativeList<T> : IDisposable where T : struct
    {
        NativeArray<T> nativeArray;
        int nativeLength;
        List<ChunkData> emptyChunkList = new List<ChunkData>();
        List<ChunkData> useChunkList = new List<ChunkData>();
        int chunkSeed;
        int initLength = 64;
        T emptyElement;
        int useLength;
        public FixedMultiNativeList()
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

        public void RemoveChunk(int chunkNo)
        {
            throw new NotImplementedException();
        }

        public void RemoveChunk(ChunkData chunk)
        {
            throw new NotImplementedException();
        }

        public ChunkData AddData(ChunkData chunk, T data)
        {
            throw new NotImplementedException();
        }

        public ChunkData RemoveData(ChunkData chunk, T data)
        {
            throw new NotImplementedException();
        }

        public ChunkData ClearData(ChunkData chunk)
        {
            throw new NotImplementedException();
        }

        public void Process(ChunkData chunk, Action<T> act)
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
        }

        public NativeArray<T> ToJobArray()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}