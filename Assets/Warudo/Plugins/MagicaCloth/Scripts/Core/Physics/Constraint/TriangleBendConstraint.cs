using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class TriangleBendConstraint : PhysicsManagerConstraint
    {
        public struct TriangleBendData
        {
            public int vindex0;
            public int vindex1;
            public int vindex2;
            public int vindex3;
            public float restAngle;
            public float direction;
            public float depth;
            public int writeIndex0;
            public int writeIndex1;
            public int writeIndex2;
            public int writeIndex3;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }

            public bool IsPositionBend()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<TriangleBendData> dataList;
        FixedChunkNativeArray<short> groupIndexList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        FixedChunkNativeArray<float3> writeBuffer;
        public struct TriangleBendGroupData
        {
            public int teamId;
            public int active;
            public int algorithm;
            public CurveParam stiffness;
            public ChunkData dataChunk;
            public ChunkData groupIndexChunk;
            public ChunkData refDataChunk;
            public ChunkData writeDataChunk;
        }

        FixedNativeList<TriangleBendGroupData> groupList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, ClothParams.Algorithm algorithm, BezierParam stiffness, TriangleBendData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam stiffness)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct TriangleBendCalcJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public NativeArray<TriangleBendGroupData> triangleBendGroupDataList;
            public NativeArray<TriangleBendData> triangleBendList;
            public NativeArray<short> groupIndexList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> basePosList;
            public NativeArray<float3> writeBuffer;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        struct TriangleBendSumJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<TriangleBendGroupData> triangleBendGroupDataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<float3> writeBuffer;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> inoutNextPosList;
            public NativeArray<float3> posList;
            public void Execute(int pindex)
            {
                throw new NotImplementedException();
            }
        }
    }
}