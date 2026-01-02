using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerMeshData : PhysicsManagerAccess
    {
        public const uint MeshFlag_Active = 0x00000001;
        public const uint MeshFlag_Skinning = 0x00000004;
        public const uint Meshflag_CalcNormal = 0x00000008;
        public const uint Meshflag_CalcTangent = 0x00000010;
        public const uint Meshflag_Pause = 0x00000020;
        public const uint MeshFlag_ExistNormals = 0x00010000;
        public const uint MeshFlag_ExistTangents = 0x00020000;
        public const uint MeshFlag_ExistWeights = 0x00040000;
        public const uint MeshFlag_UpdateUseVertexFront = 0x01000000;
        public const uint MeshFlag_UpdateUseVertexBack = 0x02000000;
        public const uint MeshFlag_FasterWrite = 0x04000000;
        public const uint MeshFlag_MeshLink = 0x10000000;
        public struct SharedVirtualMeshInfo
        {
            public int uid;
            public int useCount;
            public int sharedChildMeshStartIndex;
            public int sharedChildMeshCount;
            public ChunkData vertexChunk;
            public ChunkData weightChunk;
            public ChunkData triangleChunk;
            public ChunkData vertexToTriangleChunk;
        }

        public FixedNativeList<SharedVirtualMeshInfo> sharedVirtualMeshInfoList;
        public Dictionary<int, int> sharedVirtualMeshIdToIndexDict = new Dictionary<int, int>();
        public FixedChunkNativeArray<float2> sharedVirtualUvList;
        public FixedChunkNativeArray<uint> sharedVirtualVertexInfoList;
        public FixedChunkNativeArray<MeshData.VertexWeight> sharedVirtualWeightList;
        public FixedChunkNativeArray<int> sharedVirtualTriangleList;
        public FixedChunkNativeArray<uint> sharedVirtualVertexToTriangleInfoList;
        public FixedChunkNativeArray<int> sharedVirtualVertexToTriangleIndexList;
        public const byte VirtualVertexFlag_Use = 0x01;
        public struct VirtualMeshInfo
        {
            public uint flag;
            public int sharedVirtualMeshIndex;
            public int meshUseCount;
            public int vertexUseCount;
            public ChunkData vertexChunk;
            public ChunkData boneChunk;
            public ChunkData triangleChunk;
            public int transformIndex;
            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsActive()
            {
                throw new NotImplementedException();
            }

            public bool IsUse()
            {
                throw new NotImplementedException();
            }

            public bool IsPause()
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<VirtualMeshInfo> virtualMeshInfoList;
        public FixedChunkNativeArray<short> virtualVertexMeshIndexList;
        public FixedChunkNativeArray<byte> virtualVertexUseList;
        public FixedChunkNativeArray<byte> virtualVertexFixList;
        public FixedChunkNativeArray<byte> virtualVertexFlagList;
        public FixedChunkNativeArray<float3> virtualPosList;
        public FixedChunkNativeArray<quaternion> virtualRotList;
        public FixedChunkNativeArray<int> virtualTransformIndexList;
        public FixedChunkNativeArray<float3> virtualTriangleNormalList;
        public FixedChunkNativeArray<float3> virtualTriangleTangentList;
        public FixedChunkNativeArray<ushort> virtualTriangleMeshIndexList;
        public struct SharedChildMeshInfo
        {
            public long cuid;
            public int sharedVirtualMeshIndex;
            public int virtualMeshIndex;
            public int meshUseCount;
            public ChunkData vertexChunk;
            public ChunkData weightChunk;
        }

        public FixedNativeList<SharedChildMeshInfo> sharedChildMeshInfoList;
        public Dictionary<long, int> sharedChildMeshIdToSharedVirtualMeshIndexDict = new Dictionary<long, int>();
        public FixedChunkNativeArray<uint> sharedChildVertexInfoList;
        public FixedChunkNativeArray<MeshData.VertexWeight> sharedChildWeightList;
        public struct SharedRenderMeshInfo
        {
            public int uid;
            public int useCount;
            public uint flag;
            public ChunkData vertexChunk;
            public ChunkData bonePerVertexChunk;
            public ChunkData boneWeightsChunk;
            public int rendererBoneIndex;
            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsSkinning()
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<SharedRenderMeshInfo> sharedRenderMeshInfoList;
        public Dictionary<int, int> sharedRenderMeshIdToIndexDict = new Dictionary<int, int>();
        public FixedChunkNativeArray<float3> sharedRenderVertices;
        public FixedChunkNativeArray<float3> sharedRenderNormals;
        public FixedChunkNativeArray<float4> sharedRenderTangents;
        public FixedChunkNativeArray<byte> sharedBonesPerVertexList;
        public FixedChunkNativeArray<int> sharedBonesPerVertexStartList;
        public FixedChunkNativeArray<BoneWeight1> sharedBoneWeightList;
        public const uint RenderVertexFlag_Use = 0x00010000;
        public const int MaxRenderMeshLinkCount = 4;
        public struct RenderMeshInfo
        {
            public uint flag;
            public int renderSharedMeshIndex;
            public int sharedRenderMeshVertexStartIndex;
            public int meshUseCount;
            public int4 childMeshVertexStartIndex;
            public int4 childMeshWeightStartIndex;
            public int4 virtualMeshVertexStartIndex;
            public int4 sharedVirtualMeshVertexStartIndex;
            public int4 linkMeshCount;
            public ChunkData vertexChunk;
            public ChunkData boneWeightsChunk;
            public int transformIndex;
            public float baseScale;
            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsActive()
            {
                throw new NotImplementedException();
            }

            public bool IsUse()
            {
                throw new NotImplementedException();
            }

            public bool IsLinkMesh(int index)
            {
                throw new NotImplementedException();
            }

            public bool IsPause()
            {
                throw new NotImplementedException();
            }

            public bool IsFasterWrite()
            {
                throw new NotImplementedException();
            }

            public bool IsSkinning()
            {
                throw new NotImplementedException();
            }

            public bool AddLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart)
            {
                throw new NotImplementedException();
            }

            public bool RemoveLinkMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart)
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<RenderMeshInfo> renderMeshInfoList;
        public const uint RenderStateFlag_Use = 0x00000001;
        public const uint RenderStateFlag_ExistNormal = 0x00000002;
        public const uint RenderStateFlag_ExistTangent = 0x00000004;
        public const uint RenderStateFlag_FasterWrite = 0x00000008;
        public const uint RenderStateFlag_DelayedCalculated = 0x00000100;
        public class RenderMeshState
        {
            public uint flag;
            public int RenderSharedMeshIndex;
            public int RenderSharedMeshId;
            public int VertexChunkStart;
            public int VertexChunkLength;
            public int BoneWeightChunkStart;
            public int BoneWeightChunkLength;
            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }
        }

        public Dictionary<int, RenderMeshState> renderMeshStateDict = new Dictionary<int, RenderMeshState>();
        public FixedChunkNativeArray<uint> renderVertexFlagList;
        public FixedChunkNativeArray<float3> renderPosList;
        public FixedChunkNativeArray<float3> renderNormalList;
        public FixedChunkNativeArray<float4> renderTangentList;
        public FixedChunkNativeArray<BoneWeight1> renderBoneWeightList;
        HashSet<BaseMeshDeformer> renderMeshSet = new HashSet<BaseMeshDeformer>();
        List<RenderMeshDeformer> normalWriteList = new List<RenderMeshDeformer>();
        List<RenderMeshDeformer> fasterWritePositionList = new List<RenderMeshDeformer>();
        List<RenderMeshDeformer> fasterWritePositionNormalList = new List<RenderMeshDeformer>();
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public void AddMesh(BaseMeshDeformer bmesh)
        {
            throw new NotImplementedException();
        }

        public void RemoveMesh(BaseMeshDeformer bmesh)
        {
            throw new NotImplementedException();
        }

        public int AddVirtualMesh(int uid, int vertexCount, int weightCount, int boneCount, int triangleCount, int vertexToTriangleIndexCount, Transform transform)
        {
            throw new NotImplementedException();
        }

        public bool IsEmptySharedVirtualMesh(int uid)
        {
            throw new NotImplementedException();
        }

        public void SetSharedVirtualMeshData(int virtualMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedWeightList, Vector2[] sharedUv, int[] sharedTriangles, uint[] vertexToTriangleInfoList, int[] vertexToTriangleIndexList)
        {
            throw new NotImplementedException();
        }

        public void RemoveVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public bool ExistsVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public VirtualMeshInfo GetVirtualMeshInfo(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsUseVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsActiveVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void SetVirtualMeshActive(int virtualMeshIndex, bool sw)
        {
            throw new NotImplementedException();
        }

        public void AddUseVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveUseVirtualMesh(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public bool AddUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUseVirtualVertex(int virtualMeshIndex, int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public void CopyToVirtualMeshWorldData(int virtualMeshIndex, Vector3[] vertices, Vector3[] normals, Vector3[] tangents)
        {
            throw new NotImplementedException();
        }

        public void AddVirtualMeshBone(int virtualMeshIndex, List<Transform> boneList)
        {
            throw new NotImplementedException();
        }

        public void RemoveVirtualMeshBone(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePredictionVirtualMeshBone(int virtualMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void ChangeVirtualMeshUseUnityPhysics(int virtualMeshIndex, bool sw)
        {
            throw new NotImplementedException();
        }

        public void SetVirtualMeshFlag(int virtualMeshIndex, uint flag, bool sw)
        {
            throw new NotImplementedException();
        }

        public int SharedVirtualMeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshVertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshTriangleCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshVertexUseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshUseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VirtualMeshPauseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int AddSharedChildMesh(long cuid, int virtualMeshIndex, int vertexCount, int weightCount)
        {
            throw new NotImplementedException();
        }

        public bool IsEmptySharedChildMesh(long cuid)
        {
            throw new NotImplementedException();
        }

        public void SetSharedChildMeshData(int sharedMeshIndex, uint[] sharedVertexInfoList, MeshData.VertexWeight[] sharedVertexWeightList)
        {
            throw new NotImplementedException();
        }

        public void RemoveSharedChildMesh(int sharedChildMeshIndex)
        {
            throw new NotImplementedException();
        }

        public int SharedRenderMeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int SharedChildMeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int AddRenderMesh(int uid, bool isSkinning, bool isFasterWrite, Vector3 baseScale, int vertexCount, int rendererBoneIndex, int boneWeightCount)
        {
            throw new NotImplementedException();
        }

        public void UpdateMeshState(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void AddRenderMeshBone(int renderMeshIndex, Transform rendererTransform)
        {
            throw new NotImplementedException();
        }

        public bool IsEmptySharedRenderMesh(int uid)
        {
            throw new NotImplementedException();
        }

        public void SetRenderSharedMeshData(int renderMeshIndex, bool isSkinning, Vector3[] sharedVertices, Vector3[] sharedNormals, Vector4[] sharedTangents, NativeArray<byte> sharedBonesPerVertex, NativeArray<BoneWeight1> sharedBoneWeights)
        {
            throw new NotImplementedException();
        }

        public void RemoveRenderMesh(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveRenderMeshBone(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void ChangeRenderMeshUseUnityPhysics(int renderMeshIndex, bool sw)
        {
            throw new NotImplementedException();
        }

        public bool IsUseRenderMesh(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public bool IsActiveRenderMesh(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void SetRenderMeshFlag(int renderMeshIndex, uint flag, bool sw)
        {
            throw new NotImplementedException();
        }

        public bool IsRenderMeshFlag(int renderMeshIndex, uint flag)
        {
            throw new NotImplementedException();
        }

        public void SetRenderMeshActive(int renderMeshIndex, bool sw)
        {
            throw new NotImplementedException();
        }

        public void AddUseRenderMesh(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveUseRenderMesh(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public void LinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart)
        {
            throw new NotImplementedException();
        }

        public void UnlinkRenderMesh(int renderMeshIndex, int childMeshVertexStart, int childMeshWeightStart, int virtualMeshVertexStart, int sharedVirtualMeshVertexStart)
        {
            throw new NotImplementedException();
        }

        internal void CopyToRenderMeshLocalPositionData(int renderMeshIndex, Mesh mesh, int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal void CopyToRenderMeshLocalNormalTangentData(int renderMeshIndex, Mesh mesh, int bufferIndex, bool normal, bool tangent)
        {
            throw new NotImplementedException();
        }

        internal void CopyToRenderMeshBoneWeightData(int renderMeshIndex, Mesh mesh, Mesh sharedMesh, int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal void CopyToRenderMeshWorldData(int renderMeshIndex, Transform target, Vector3[] vertices, Vector3[] normals, Vector3[] tangents)
        {
            throw new NotImplementedException();
        }

        internal List<int> GetVertexUseList(int renderMeshIndex)
        {
            throw new NotImplementedException();
        }

        public int RenderMeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RenderMeshVertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RenderMeshUseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RenderMeshVertexUseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RenderMeshPauseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal void SetDelayedCalculatedFlag()
        {
            throw new NotImplementedException();
        }

        internal void ClearWritingList()
        {
            throw new NotImplementedException();
        }

        internal void MeshCalculation(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal void NormalWriting(int bufferIndex)
        {
            throw new NotImplementedException();
        }
    }
}