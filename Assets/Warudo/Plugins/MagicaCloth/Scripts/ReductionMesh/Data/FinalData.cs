using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class FinalData
    {
        public List<Vector3> vertices = new List<Vector3>();
        public List<Vector3> normals = new List<Vector3>();
        public List<Vector4> tangents = new List<Vector4>();
        public List<Vector2> uvs = new List<Vector2>();
        public List<BoneWeight> boneWeights = new List<BoneWeight>();
        public List<Matrix4x4> bindPoses = new List<Matrix4x4>();
        public List<Transform> bones = new List<Transform>();
        public List<int> lines = new List<int>();
        public List<int> triangles = new List<int>();
        public List<int> tetras = new List<int>();
        public List<float> tetraSizes = new List<float>();
        public List<Matrix4x4> vertexBindPoses = new List<Matrix4x4>();
        public class MeshIndexData
        {
            public List<uint> meshIndexPackList = new List<uint>();
        }

        public List<MeshIndexData> vertexToMeshIndexList = new List<MeshIndexData>();
        public List<int> vertexToTriangleCountList = new List<int>();
        public List<int> vertexToTriangleStartList = new List<int>();
        public List<int> vertexToTriangleIndexList = new List<int>();
        public class MeshInfo
        {
            public int meshIndex;
            public Mesh mesh;
            public List<Vector3> vertices = new List<Vector3>();
            public List<Vector3> normals = new List<Vector3>();
            public List<Vector4> tangents = new List<Vector4>();
            public List<BoneWeight> boneWeights = new List<BoneWeight>();
            public List<int> parents = new List<int>();
            public int VertexCount
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

        public List<MeshInfo> meshList = new List<MeshInfo>();
        public bool IsValid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int LineCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TriangleCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TetraCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSkinning
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int MeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}