using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClampDistance2Constraint : PhysicsManagerConstraint
    {
        public struct ClampDistance2Data
        {
            public int vertexIndex;
            public int parentVertexIndex;
            public float length;
        }

        FixedChunkNativeArray<ClampDistance2Data> dataList;
        public struct ClampDistance2RootInfo
        {
            public ushort startIndex;
            public ushort dataLength;
        }

        FixedChunkNativeArray<ClampDistance2RootInfo> rootInfoList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public float minRatio;
            public float maxRatio;
            public float velocityInfluence;
            public ChunkData dataChunk;
            public ChunkData rootInfoChunk;
        }

        public FixedNativeList<GroupData> groupList;
        FixedChunkNativeArray<int> rootTeamList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, float minRatio, float maxRatio, float velocityInfluence, ClampDistance2Data[] dataArray, ClampDistance2RootInfo[] rootInfoArray)
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

        struct ClampDistance2Job : IJobParallelFor
        {
            public int runCount;
            public NativeArray<ClampDistance2Data> dataList;
            public NativeArray<ClampDistance2RootInfo> rootInfoList;
            public NativeArray<int> rootTeamList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> posList;
            public void Execute(int rootIndex)
            {
                throw new NotImplementedException();
            }
        }
    }
}