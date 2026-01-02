using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class AdjustRotationWorker : PhysicsManagerWorker
    {
        const int AdjustMode_Fixed = 0;
        const int AdjustMode_XYMove = 1;
        const int AdjustMode_XZMove = 2;
        const int AdjustMode_YZMove = 3;
        public struct AdjustRotationData
        {
            public int keyIndex;
            public int targetIndex;
            public float3 localPos;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<AdjustRotationData> dataList;
        public struct GroupData
        {
            public int teamId;
            public int active;
            public int adjustMode;
            public float3 axisRotationPower;
            public ChunkData chunk;
        }

        public FixedNativeList<GroupData> groupList;
        ExNativeMultiHashMap<int, int> particleMap;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, int adjustMode, float3 axisRotationPower, AdjustRotationData[] dataArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, int adjustMode, float3 axisRotationPower)
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

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct AdjustRotationJob : IJobParallelFor
        {
            public NativeArray<AdjustRotationData> dataList;
            public NativeArray<GroupData> groupList;
            public NativeMultiHashMap<int, int> particleMap;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}