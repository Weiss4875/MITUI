using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class TriangleWorker : PhysicsManagerWorker
    {
        public struct TriangleRotationData
        {
            public int targetIndex;
            public int triangleCount;
            public int triangleStartIndex;
            public quaternion localRot;
            public bool IsValid()
            {
                throw new NotImplementedException();
            }
        }

        FixedChunkNativeArray<TriangleRotationData> triangleDataList;
        FixedChunkNativeArray<int> triangleIndexList;
        public struct GroupData
        {
            public int teamId;
            public ChunkData triangleDataChunk;
            public ChunkData triangleIndexChunk;
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

        public int AddGroup(int teamId, TriangleRotationData[] dataArray, int[] indexArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int teamId)
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

        struct TriangleRotationJob : IJobParallelFor
        {
            public NativeArray<TriangleRotationData> triangleDataList;
            public NativeArray<int> triangleIndexList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}