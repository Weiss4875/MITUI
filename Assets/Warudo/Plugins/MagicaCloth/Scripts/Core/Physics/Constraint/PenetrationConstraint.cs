using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PenetrationConstraint : PhysicsManagerConstraint
    {
        public struct PenetrationData
        {
            public short vertexIndex;
            public short colliderIndex;
            public float3 localPos;
            public float3 localDir;
            public float distance;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<PenetrationData> dataList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        FixedChunkNativeArray<float3> bonePenetrationDataList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public int mode;
            public float maxDepth;
            public CurveParam radius;
            public CurveParam distance;
            public ChunkData dataChunk;
            public ChunkData refDataChunk;
            public ChunkData bonePenetrationDataChunk;
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

        public int AddGroup(int teamId, bool active, ClothParams.PenetrationMode mode, BezierParam distance, BezierParam radius, float maxDepth, PenetrationData[] moveLimitDataList, ReferenceDataIndex[] refDataArray, float3[] bonePenetrationDataArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam distance, BezierParam radius, float maxDepth)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct PenetrationJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<GroupData> groupList;
            public NativeArray<PenetrationData> dataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<float3> bonePenetrationDataList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<int> transformIndexList;
            public NativeArray<float> depthList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<int> colliderList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> skinningBoneList;
            public NativeArray<float3> outNextPosList;
            public NativeArray<float3> posList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}