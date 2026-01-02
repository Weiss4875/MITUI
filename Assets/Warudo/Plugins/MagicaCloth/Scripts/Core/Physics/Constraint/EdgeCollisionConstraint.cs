using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class EdgeCollisionConstraint : PhysicsManagerConstraint
    {
        public struct EdgeCollisionData
        {
            public ushort vindex0;
            public ushort vindex1;
            public int writeIndex0;
            public int writeIndex1;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<EdgeCollisionData> dataList;
        FixedChunkNativeArray<short> groupIndexList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        FixedChunkNativeArray<float3> writeBuffer;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public float edgeRadius;
            public ChunkData dataChunk;
            public ChunkData groupIndexChunk;
            public ChunkData refDataChunk;
            public ChunkData writeDataChunk;
        }

        FixedNativeList<GroupData> groupList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, float edgeRadius, EdgeCollisionData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, float edgeRadius)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct EdgeCollisionCalcJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public NativeArray<GroupData> groupDataList;
            public NativeArray<EdgeCollisionData> dataList;
            public NativeArray<short> groupIndexList;
            public NativeArray<int> colliderList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> radiusList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> localPosList;
            public NativeArray<int> transformIndexList;
            public NativeArray<float3> boneSclList;
            public NativeArray<float3> writeBuffer;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }

            bool SphereColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex)
            {
                throw new NotImplementedException();
            }

            bool CapsuleColliderDetection(float3 nextpos0, float3 nextpos1, ref float3 corr0, ref float3 corr1, float radius, int cindex, float3 dir)
            {
                throw new NotImplementedException();
            }
        }

        struct EdgeCollisionSumJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<GroupData> groupDataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<float3> writeBuffer;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> inoutNextPosList;
            public NativeArray<float> frictionList;
            public void Execute(int pindex)
            {
                throw new NotImplementedException();
            }
        }
    }
}