using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class GridHash
    {
        public class Point
        {
            public int id;
            public float3 pos;
        }

        protected Dictionary<uint, List<Point>> gridMap;
        protected float gridSize = 0.1f;
        public virtual void Create(float gridSize = 0.1f)
        {
            throw new NotImplementedException();
        }

        public virtual void AddPoint(float3 pos, int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(float3 pos, int id)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public static int3 GetGridPos(float3 pos, float gridSize)
        {
            throw new NotImplementedException();
        }

        public static uint GetGridHash(int3 pos)
        {
            throw new NotImplementedException();
        }

        public static uint GetGridHash(float3 pos, float gridSize)
        {
            throw new NotImplementedException();
        }
    }
}