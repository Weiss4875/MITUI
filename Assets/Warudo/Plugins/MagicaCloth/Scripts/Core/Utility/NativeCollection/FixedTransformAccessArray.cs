using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class FixedTransformAccessArray : IDisposable
    {
        TransformAccessArray transformArray;
        int nativeLength;
        Queue<int> emptyStack = new Queue<int>();
        Dictionary<int, int> useIndexDict = new Dictionary<int, int>();
        Dictionary<int, int> indexDict = new Dictionary<int, int>();
        Dictionary<int, int> referenceDict = new Dictionary<int, int>();
        public FixedTransformAccessArray(int desiredJobCount = -1)
        {
            throw new NotImplementedException();
        }

        public FixedTransformAccessArray(int capacity, int desiredJobCount)
        {
            throw new NotImplementedException();
        }

        public int Add(Transform element)
        {
            throw new NotImplementedException();
        }

        public void Remove(int index)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int index)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Transform element)
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

        public int Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Transform this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int GetIndex(Transform element)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TransformAccessArray GetTransformAccessArray()
        {
            throw new NotImplementedException();
        }
    }
}