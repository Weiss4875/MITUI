using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class VolumeConstraint : PhysicsManagerConstraint
    {
        public struct VolumeData
        {
            public int vindex0;
            public int vindex1;
            public int vindex2;
            public int vindex3;
            public float3x3 ivMat;
            public float depth;
            public int direction;
            public int writeIndex0;
            public int writeIndex1;
            public int writeIndex2;
            public int writeIndex3;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<VolumeData> dataList;
        FixedChunkNativeArray<short> groupIndexList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        FixedChunkNativeArray<float3> writeBuffer;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public CurveParam stretchStiffness;
            public CurveParam shearStiffness;
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

        public int AddGroup(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness, VolumeData[] dataArray, ReferenceDataIndex[] refDataArray, int writeBufferCount)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam stretchStiffness, BezierParam shearStiffness)
        {
            throw new NotImplementedException();
        }

        public override int GetIterationCount()
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct VolumeCalcJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public NativeArray<GroupData> groupDataList;
            public NativeArray<VolumeData> dataList;
            public NativeArray<short> groupIndexList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> writeBuffer;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        struct VolumeSumJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<GroupData> groupDataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<float3> writeBuffer;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> inoutNextPosList;
            public void Execute(int pindex)
            {
                throw new NotImplementedException();
            }
        }
    }
}