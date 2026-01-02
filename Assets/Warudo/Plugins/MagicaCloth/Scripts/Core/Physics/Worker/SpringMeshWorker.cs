using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class SpringMeshWorker : PhysicsManagerWorker
    {
        public struct SpringData
        {
            public int particleIndex;
            public float weight;
        }

        ExNativeMultiHashMap<int, SpringData> springMap;
        FixedNativeListWithCount<int> springVertexList;
        Dictionary<int, List<int>> groupIndexDict = new Dictionary<int, List<int>>();
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public void Add(int group, int vertexIndex, int particleIndex, float weight)
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int group)
        {
            throw new NotImplementedException();
        }

        public override void Warmup()
        {
            throw new NotImplementedException();
        }

        public override JobHandle PreUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        private struct SpringJob : IJobParallelFor
        {
            public NativeArray<int> springVertexList;
            public NativeMultiHashMap<int, SpringData> springMap;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> particlePosList;
            public NativeArray<quaternion> particleRotList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<byte> virtualVertexFlagList;
            public NativeArray<short> virtualVertexMeshIndexList;
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            NativeMultiHashMapIterator<int> iterator;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}