using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class VirtualMeshWorker : PhysicsManagerWorker
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public override void RemoveGroup(int group)
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

        private struct ReadMeshPositionJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;
            public NativeArray<short> virtualVertexMeshIndexList;
            public NativeArray<byte> virtualVertexUseList;
            public NativeArray<int> virtualTransformIndexList;
            public NativeArray<uint> sharedVirtualVertexInfoList;
            public NativeArray<MeshData.VertexWeight> sharedVirtualWeightList;
            public NativeArray<float3> transformPosList;
            public NativeArray<quaternion> transformRotList;
            public NativeArray<float3> transformSclList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<quaternion> virtualRotList;
            public NativeArray<byte> virtualVertexFlagList;
            public void Execute(int vindex)
            {
                throw new NotImplementedException();
            }
        }

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        private struct CalcMeshTriangleNormalTangentJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;
            public NativeArray<ushort> virtualTriangleMeshIndexList;
            public NativeArray<byte> virtualVertexUseList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<int> sharedTriangles;
            public NativeArray<float2> sharedMeshUv;
            public NativeArray<float3> virtualTriangleNormalList;
            public NativeArray<float3> virtualTriangleTangentList;
            public NativeArray<float3> transformSclList;
            public void Execute(int tindex)
            {
                throw new NotImplementedException();
            }
        }

        private struct CalcVertexNormalTangentFromTriangleJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;
            public NativeArray<short> virtualVertexMeshIndexList;
            public NativeArray<byte> virtualVertexUseList;
            public NativeArray<byte> virtualVertexFlagList;
            public NativeArray<uint> sharedVirtualVertexToTriangleInfoList;
            public NativeArray<int> sharedVirtualVertexToTriangleIndexList;
            public NativeArray<float3> virtualTriangleNormalList;
            public NativeArray<float3> virtualTriangleTangentList;
            public NativeArray<quaternion> virtualRotList;
            public void Execute(int vindex)
            {
                throw new NotImplementedException();
            }
        }

        private struct CalcMeshTriangleNormalTangentForEachMeshJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.VirtualMeshInfo> virtualMeshInfoList;
            public NativeArray<PhysicsManagerMeshData.SharedVirtualMeshInfo> sharedVirtualMeshInfoList;
            public NativeArray<byte> virtualVertexUseList;
            public NativeArray<byte> virtualVertexFlagList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<int> sharedTriangles;
            public NativeArray<float2> sharedMeshUv;
            public NativeArray<uint> sharedVirtualVertexToTriangleInfoList;
            public NativeArray<int> sharedVirtualVertexToTriangleIndexList;
            public NativeArray<float3> transformSclList;
            public NativeArray<float3> virtualTriangleNormalList;
            public NativeArray<float3> virtualTriangleTangentList;
            public NativeArray<quaternion> virtualRotList;
            public void Execute(int mindex)
            {
                throw new NotImplementedException();
            }
        }
    }
}