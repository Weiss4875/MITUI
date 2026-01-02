using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class TwistConstraint : PhysicsManagerConstraint
    {
        public struct TwistData
        {
            public ushort vertexIndex0;
            public ushort vertexIndex1;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<TwistData> dataList;
        FixedChunkNativeArray<ReferenceDataIndex> refDataList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public float recoveryPower;
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

        public int AddGroup(int teamId, bool active, float recoveryPower, TwistData[] dataArray, ReferenceDataIndex[] refArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, float recoveryPower)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct TwistJob2 : IJobParallelFor
        {
            public int runCount;
            public float updatePower;
            public NativeArray<TwistData> dataList;
            public NativeArray<ReferenceDataIndex> refDataList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> basePosList;
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