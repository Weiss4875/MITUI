using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class MeshData : ReductionMeshAccess
    {
        public class WeightData
        {
            public int boneIndex;
            public float boneWeight;
        }

        public class Vertex
        {
            public int meshIndex;
            public int vertexIndex;
            public Vector3 wpos;
            public Vector3 wnor;
            public Vector3 wtan;
            public float tanw;
            public Vector2 uv;
            public int parentIndex;
            public List<WeightData> boneWeightList = new List<WeightData>();
        }

        public List<Vertex> originalVertexList = new List<Vertex>();
        public class MeshInfo
        {
            public int index;
            public Mesh mesh;
            public int vertexCount;
            public List<Vertex> vertexList = new List<Vertex>();
        }

        public List<MeshInfo> meshInfoList = new List<MeshInfo>();
        public class ShareVertex
        {
            public int sindex;
            public Vector3 wpos;
            public Vector3 wnor;
            public Vector3 wtan;
            public float tanw;
            public Vector2 uv;
            public Matrix4x4 worldToLocalMatrix;
            public Matrix4x4 bindpose;
            public List<WeightData> boneWeightList = new List<WeightData>();
            public List<Vertex> vertexList = new List<Vertex>();
            public HashSet<ShareVertex> linkShareVertexSet = new HashSet<ShareVertex>();
            public HashSet<Triangle> linkTriangleSet = new HashSet<Triangle>();
            public void AddLink(ShareVertex mv)
            {
                throw new NotImplementedException();
            }

            public void ReplaseLink(ShareVertex old, ShareVertex mv)
            {
                throw new NotImplementedException();
            }

            public void RecalcCoordinate()
            {
                throw new NotImplementedException();
            }

            public void CalcNormalTangentFromTriangle()
            {
                throw new NotImplementedException();
            }

            public Vector3 CalcLocalPos(Vector3 pos)
            {
                throw new NotImplementedException();
            }

            public Vector3 CalcLocalDir(Vector3 dir)
            {
                throw new NotImplementedException();
            }

            public Matrix4x4 CalcWorldToLocalMatrix()
            {
                throw new NotImplementedException();
            }

            public void CalcBoneWeight(ReductionMesh.ReductionWeightMode weightMode, float weightPow)
            {
                throw new NotImplementedException();
            }

            public BoneWeight GetBoneWeight()
            {
                throw new NotImplementedException();
            }
        }

        public List<ShareVertex> shareVertexList = new List<ShareVertex>();
        public class Triangle
        {
            public int tindex;
            public List<ShareVertex> shareVertexList = new List<ShareVertex>();
            public Vector3 wnor;
            public Vector3 wtan;
            public bool flipLock;
            public void GetEdge(out uint edge0, out uint edge1, out uint edge2)
            {
                throw new NotImplementedException();
            }

            public Vector3 CalcTriangleNormal()
            {
                throw new NotImplementedException();
            }

            public void Flip()
            {
                throw new NotImplementedException();
            }

            public Vector3 CalcTriangleTangent()
            {
                throw new NotImplementedException();
            }

            public ShareVertex GetNonEdgeVertex(int edgev0, int edgev1)
            {
                throw new NotImplementedException();
            }

            public ulong GetTriangleHash()
            {
                throw new NotImplementedException();
            }

            public static float GetTriangleArea(ShareVertex sv0, ShareVertex sv1, ShareVertex sv2)
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

        Dictionary<ulong, Triangle> triangleDict = new Dictionary<ulong, Triangle>();
        private class Line
        {
            public List<ShareVertex> shareVertexList = new List<ShareVertex>();
        }

        Dictionary<uint, Line> lineDict = new Dictionary<uint, Line>();
        public List<Transform> boneList = new List<Transform>();
        public enum UvWrapMode
        {
            None,
            Sphere,
        }

        public class Square
        {
            public ulong shash;
            public List<Triangle> triangleList = new List<Triangle>();
            public float angle;
            public override string ToString()
            {
                throw new NotImplementedException();
            }
        }

        public class Tetra
        {
            public List<ShareVertex> shareVertexList = new List<ShareVertex>();
            public Vector3 circumCenter;
            public float circumRadius;
            public Vector3 tetraCenter;
            public float tetraSize;
            public Tetra()
            {
                throw new NotImplementedException();
            }

            public Tetra(ShareVertex a, ShareVertex b, ShareVertex c, ShareVertex d)
            {
                throw new NotImplementedException();
            }

            public ulong GetTetraHash()
            {
                throw new NotImplementedException();
            }

            public void CalcCircumcircle()
            {
                throw new NotImplementedException();
            }

            public bool IntersectCircumcircle(Vector3 pos)
            {
                throw new NotImplementedException();
            }

            public bool CheckSame(Tetra tri)
            {
                throw new NotImplementedException();
            }

            public bool ContainsPoint(ShareVertex p1)
            {
                throw new NotImplementedException();
            }

            public bool ContainsPoint(ShareVertex p1, ShareVertex p2, ShareVertex p3, ShareVertex p4)
            {
                throw new NotImplementedException();
            }

            public void CalcSize()
            {
                throw new NotImplementedException();
            }

            public bool Verification()
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

        public int MeshCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float WeightPow
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int MaxWeightCount
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float SameSurfaceAngle
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool RemoveSameTrianglePair
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public float RemoveSameTrianglePairAngle
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList)
        {
            throw new NotImplementedException();
        }

        public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null)
        {
            throw new NotImplementedException();
        }

        public void CombineVertex(ShareVertex sv0, ShareVertex sv1)
        {
            throw new NotImplementedException();
        }

        public void UpdateMeshData(bool createTetra)
        {
            throw new NotImplementedException();
        }

        void CalcUV(UvWrapMode wrapMode)
        {
            throw new NotImplementedException();
        }

        public FinalData GetFinalData(Transform root)
        {
            throw new NotImplementedException();
        }

        void CreateOriginalMeshInfo(FinalData final, Transform root, float weightLength)
        {
            throw new NotImplementedException();
        }

        private class LinkInfo
        {
            public ShareVertex sv;
            public float length;
            public int count;
        }

        private class VertexLengthInfo
        {
            public ShareVertex sv;
            public float length;
        }

        public void CalcMeshWorldPositionNormalTangent(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList)
        {
            throw new NotImplementedException();
        }
    }
}