using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClampRotationConstraint : PhysicsManagerConstraint
    {
        public struct ClampRotationData
        {
            public int vertexIndex;
            public int parentVertexIndex;
            public float3 localPos;
            public quaternion localRot;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<ClampRotationData> dataList;
        public struct ClampRotationRootInfo
        {
            public ushort startIndex;
            public ushort dataLength;
        }

        FixedChunkNativeArray<ClampRotationRootInfo> rootInfoList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public CurveParam maxAngle;
            public float velocityInfluence;
            public ChunkData dataChunk;
            public ChunkData rootInfoChunk;
        }

        public FixedNativeList<GroupData> groupList;
        FixedChunkNativeArray<int> rootTeamList;
        FixedChunkNativeArray<float> lengthBuffer;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, BezierParam maxAngle, float velocityInfluence, ClampRotationData[] dataArray, ClampRotationRootInfo[] rootInfoArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam maxAngle, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct ClampRotationJob : IJobParallelFor
        {
            public int runCount;
            public float maxMoveLength;
            public NativeArray<ClampRotationData> dataList;
            public NativeArray<ClampRotationRootInfo> rootInfoList;
            public NativeArray<int> rootTeamList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<float> depthList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> posList;
            public NativeArray<float> lengthBuffer;
            public void Execute(int rootIndex)
            {
                throw new NotImplementedException();
            }
        }
    }
}