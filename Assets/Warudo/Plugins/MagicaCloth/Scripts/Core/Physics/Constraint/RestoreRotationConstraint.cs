using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class RestoreRotationConstraint : PhysicsManagerConstraint
    {
        public struct RotationData
        {
            public ushort vertexIndex;
            public ushort targetVertexIndex;
            public float3 localPos;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<RotationData> dataList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public CurveParam restorePower;
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

        public int AddGroup(int teamId, bool active, BezierParam power, float velocityInfluence, RotationData[] dataArray, ReferenceDataIndex[] refDataArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam power, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct RotationJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public NativeArray<RotationData> dataList;
            public NativeArray<GroupData> groupList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> depthList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> outNextPosList;
            public NativeArray<float3> posList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}