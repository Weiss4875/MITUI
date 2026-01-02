using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class RenderMeshWorker : PhysicsManagerWorker
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

        private struct CalcVertexUseFlagJob : IJobParallelFor
        {
            public uint updateFlag;
            public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;
            public NativeArray<PhysicsManagerMeshData.SharedRenderMeshInfo> sharedRenderMeshInfoList;
            public NativeArray<byte> virtualVertexUseList;
            public NativeArray<byte> virtualVertexFixList;
            public NativeArray<uint> sharedChildVertexInfoList;
            public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList;
            public NativeArray<float3> sharedRenderVertices;
            public NativeArray<float3> sharedRenderNormals;
            public NativeArray<float4> sharedRenderTangents;
            public NativeArray<byte> sharedBonesPerVertexList;
            public NativeArray<int> sharedBonesPerVertexStartList;
            public NativeArray<BoneWeight1> sharedBoneWeightList;
            public NativeArray<float3> renderPosList;
            public NativeArray<float3> renderNormalList;
            public NativeArray<float4> renderTangentList;
            public NativeArray<BoneWeight1> renderBoneWeightList;
            public NativeArray<uint> renderVertexFlagList;
            public void Execute(int rmindex)
            {
                throw new NotImplementedException();
            }
        }

        public override JobHandle PreUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        public override JobHandle PostUpdate(JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        private struct CollectLocalPositionNormalTangentForEachMeshJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;
            public NativeArray<float3> transformPosList;
            public NativeArray<quaternion> transformRotList;
            public NativeArray<float3> transformSclList;
            public NativeArray<uint> sharedChildVertexInfoList;
            public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<quaternion> virtualRotList;
            public NativeArray<uint> renderVertexFlagList;
            public NativeArray<float3> renderPosList;
            public NativeArray<float3> renderNormalList;
            public NativeArray<float4> renderTangentList;
            public void Execute(int rmindex)
            {
                throw new NotImplementedException();
            }
        }

        private struct CollectLocalPositionNormalTangentForEachVertexJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerMeshData.RenderMeshInfo> renderMeshInfoList;
            public NativeArray<float3> transformPosList;
            public NativeArray<quaternion> transformRotList;
            public NativeArray<float3> transformSclList;
            public NativeArray<uint> sharedChildVertexInfoList;
            public NativeArray<MeshData.VertexWeight> sharedChildVertexWeightList;
            public NativeArray<float3> virtualPosList;
            public NativeArray<quaternion> virtualRotList;
            public NativeArray<uint> renderVertexFlagList;
            public NativeArray<float3> renderPosList;
            public NativeArray<float3> renderNormalList;
            public NativeArray<float4> renderTangentList;
            public void Execute(int vindex)
            {
                throw new NotImplementedException();
            }
        }
    }
}