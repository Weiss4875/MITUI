using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class RestoreDistanceConstraint : PhysicsManagerConstraint
    {
        public const int StructType = 0;
        public const int BendType = 1;
        public const int NearType = 2;
        public const int TypeCount = 3;
        public struct RestoreDistanceData
        {
            public ushort vertexIndex;
            public ushort targetVertexIndex;
            public float length;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<RestoreDistanceData>[] dataList;
        FixedChunkNativeArray<ReferenceDataIndex>[] refDataList;
        public struct RestoreDistanceGroupData
        {
            public int teamId;
            public CurveParam mass;
            public float velocityInfluence;
            public CurveParam structStiffness;
            public ChunkData structDataChunk;
            public ChunkData structRefChunk;
            public int useBend;
            public CurveParam bendStiffness;
            public ChunkData bendDataChunk;
            public ChunkData bendRefChunk;
            public int useNear;
            public CurveParam nearStiffness;
            public ChunkData nearDataChunk;
            public ChunkData nearRefChunk;
            public bool IsValid(int type)
            {
                throw new NotImplementedException();
            }

            public CurveParam GetStiffness(int type)
            {
                throw new NotImplementedException();
            }

            public ChunkData GetDataChunk(int type)
            {
                throw new NotImplementedException();
            }

            public ChunkData GetRefChunk(int type)
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<RestoreDistanceGroupData> groupList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, RestoreDistanceData[] structDataArray, ReferenceDataIndex[] structRefDataArray, bool useBend, BezierParam bendStiffness, RestoreDistanceData[] bendDataArray, ReferenceDataIndex[] bendRefDataArray, bool useNear, BezierParam nearStiffness, RestoreDistanceData[] nearDataArray, ReferenceDataIndex[] nearRefDataArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, BezierParam mass, float velocityInfluence, BezierParam structStiffness, bool useBend, BezierParam bendStiffness, bool useNear, BezierParam nearStiffness)
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

        struct DistanceJob : IJobParallelFor
        {
            public float updatePower;
            public int runCount;
            public int type;
            public NativeArray<RestoreDistanceData> restoreDistanceDataList;
            public NativeArray<RestoreDistanceGroupData> restoreDistanceGroupDataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> depthList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> basePosList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> outNextPosList;
            public NativeArray<float3> posList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}