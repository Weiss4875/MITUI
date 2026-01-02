using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class LineWorker : PhysicsManagerWorker
    {
        public struct LineRotationData
        {
            public int vertexIndex;
            public int childCount;
            public int childStartDataIndex;
            public float3 localPos;
            public quaternion localRot;
        }

        FixedChunkNativeArray<LineRotationData> dataList;
        public struct LineRotationRootInfo
        {
            public ushort startIndex;
            public ushort dataLength;
        }

        FixedChunkNativeArray<LineRotationRootInfo> rootInfoList;
        public struct GroupData
        {
            public int teamId;
            public int avarage;
            public ChunkData dataChunk;
            public ChunkData rootInfoChunk;
        }

        public FixedNativeList<GroupData> groupList;
        FixedChunkNativeArray<int> rootTeamList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool avarage, LineRotationData[] dataArray, LineRotationRootInfo[] rootInfoArray)
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool avarage)
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

        struct LineRotationJob : IJobParallelFor
        {
            public int fixedUpdateCount;
            public NativeArray<LineRotationData> dataList;
            public NativeArray<LineRotationRootInfo> rootInfoList;
            public NativeArray<int> rootTeamList;
            public NativeArray<GroupData> groupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public void Execute(int rootIndex)
            {
                throw new NotImplementedException();
            }
        }
    }
}