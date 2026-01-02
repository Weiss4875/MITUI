using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class CompositeRotationConstraint : PhysicsManagerConstraint
    {
        public struct RotationData
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

        FixedChunkNativeArray<RotationData> dataList;
        public struct RootInfo
        {
            public ushort startIndex;
            public ushort dataLength;
        }

        FixedChunkNativeArray<RootInfo> rootInfoList;
        public struct GroupData
        {
            public int teamId;
            public int useClamp;
            public int useRestore;
            public CurveParam maxAngle;
            public CurveParam restorePower;
            public float restoreVelocityInfluence;
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

        public int AddGroup(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence, RotationData[] dataArray, RootInfo[] rootInfoArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool useClamp, BezierParam maxAngle, bool useRestore, BezierParam restorePower, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct RotationRootLineJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public float maxMoveSpeed;
            public NativeArray<RotationData> dataList;
            public NativeArray<RootInfo> rootInfoList;
            public NativeArray<int> rootTeamList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<CurveParam> teamGravityList;
            public NativeArray<float> depthList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> posList;
            public NativeArray<float> lengthBuffer;
            public void Execute(int rootIndex)
            {
                throw new NotImplementedException();
            }

            float GetRotRatio(float3 tv, float3 gravityVector, float gravity, float minRatio = 0.25f, float maxRatio = 0.45f)
            {
                throw new NotImplementedException();
            }
        }
    }
}