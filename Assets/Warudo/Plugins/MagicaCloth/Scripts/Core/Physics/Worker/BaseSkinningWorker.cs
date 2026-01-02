using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class BaseSkinningWorker : PhysicsManagerWorker
    {
        public struct BaseSkinningData
        {
            public float3 localPos;
            public float3 localNor;
            public float3 localTan;
            public int4 boneIndices;
            public float4 weights;
            public short weightCount;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<BaseSkinningData> dataList;
        FixedChunkNativeArray<float4x4> bindPoseList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public int updateFixed;
            public ChunkData dataChunk;
            public ChunkData bindPoseChunk;
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

        public int AddGroup(int teamId, bool active, bool updateFixed, BaseSkinningData[] skinningDataList, float4x4[] skinningBindPoseList)
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool updateFixed)
        {
            throw new NotImplementedException();
        }

        public override void Warmup()
        {
            throw new NotImplementedException();
        }

        public override JobHandle PreUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct BaseSkinningJob : IJobParallelFor
        {
            public NativeArray<GroupData> groupList;
            public NativeArray<BaseSkinningData> dataList;
            public NativeArray<float4x4> bindPoseList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> skinningBoneList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }
    }
}