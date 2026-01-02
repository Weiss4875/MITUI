using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClampDistanceConstraint : PhysicsManagerConstraint
    {
        public struct ClampDistanceData
        {
            public ushort vertexIndex;
            public ushort targetVertexIndex;
            public float length;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<ClampDistanceData> dataList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public float minRatio;
            public float maxRatio;
            public float velocityInfluence;
            public ChunkData dataChunk;
            public ChunkData refChunk;
        }

        public FixedNativeList<GroupData> groupList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistanceData[] dataArray, ReferenceDataIndex[] refDataArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct ClampDistanceJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<ClampDistanceData> clampDistanceList;
            public NativeArray<GroupData> groupList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> basePosList;
            public NativeArray<float3> posList;
            public NativeArray<float> frictionList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}