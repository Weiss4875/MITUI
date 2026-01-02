using System.Collections.Generic;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class NearPointSearch : GridHash
    {
        float radius;
        Dictionary<int, int> nearDict = new Dictionary<int, int>();
        Dictionary<int, float> distDict = new Dictionary<int, float>();
        HashSet<uint> lockPairSet = new HashSet<uint>();
        public void Create(float3[] positionList, float radius)
        {
            throw new NotImplementedException();
        }

        public void SearchNearPointAll()
        {
            throw new NotImplementedException();
        }

        public void SearchNearPoint(int id, float3 pos)
        {
            throw new NotImplementedException();
        }

        public void SearchNearPoint(float3 pos, float r)
        {
            throw new NotImplementedException();
        }

        public override void AddPoint(float3 pos, int id)
        {
            throw new NotImplementedException();
        }

        public override void Remove(float3 pos, int id)
        {
            throw new NotImplementedException();
        }

        public void AddLockPair(int id1, int id2)
        {
            throw new NotImplementedException();
        }

        public bool GetNearPointPair(out int id1, out int id2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}