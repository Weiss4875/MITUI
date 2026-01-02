using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MeshParticleWorker : PhysicsManagerWorker
    {
        ExNativeMultiHashMap<int, int> vertexToParticleMap;
        FixedNativeListWithCount<int> vertexToParticleList;
        struct CreateData
        {
            public int vertexIndex;
            public int particleIndex;
        }

        Dictionary<int, List<CreateData>> groupCreateDict = new Dictionary<int, List<CreateData>>();
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public void Add(int group, int vindex, int pindex)
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

        private struct VertexToParticleJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<int> vertexToParticleList;
            public NativeMultiHashMap<int, int> vertexToParticleMap;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<short> virtualVertexMeshIndexList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        private struct ParticleToVertexJob : IJobParallelFor
        {
            public NativeArray<int> vertexToParticleList;
            public NativeMultiHashMap<int, int> vertexToParticleMap;
            public NativeArray<float3> virtualPosList;
            public NativeArray<quaternion> virtualRotList;
            public NativeArray<byte> virtualVertexFlagList;
            public NativeArray<short> virtualVertexMeshIndexList;
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> particleFlagList;
            public NativeArray<float3> particlePosList;
            public NativeArray<quaternion> particleRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}