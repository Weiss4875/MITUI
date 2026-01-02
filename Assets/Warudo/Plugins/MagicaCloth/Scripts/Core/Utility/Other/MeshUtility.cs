using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class MeshUtility
    {
        public static GameObject ReplaceSkinnedMeshRendererToMeshRenderer(SkinnedMeshRenderer sren, bool replaceSkinnedMeshRenderer)
        {
            throw new NotImplementedException();
        }

        public static bool CalcMeshWorldPositionNormalTangent(MeshData meshData, List<Transform> boneList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList)
        {
            throw new NotImplementedException();
        }

        public static bool CalcMeshWorldPositionNormalTangent(Renderer ren, Mesh mesh, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList)
        {
            throw new NotImplementedException();
        }

        public static bool CalcMeshLocalNormalTangent(List<int> selectList, Vector3[] vlist, Vector2[] uvlist, int[] triangles, out List<Vector3> lnorList, out List<Vector3> ltanList)
        {
            throw new NotImplementedException();
        }

        public static List<HashSet<int>> GetTriangleToVertexLinkList(int vcnt, List<int> lineList, List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        public static List<HashSet<int>> GetVertexLinkList(int vcnt, HashSet<uint> lineSet)
        {
            throw new NotImplementedException();
        }

        public static Dictionary<int, HashSet<int>> GetVertexToTriangles(List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        public static int RestTriangleVertex(int tindex, int v0, int v1, List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        public static void RestTriangleVertex(int tindex, int v0, List<int> triangleList, out int v1, out int v2)
        {
            throw new NotImplementedException();
        }

        public static bool CheckAdjacentTriangle(int tindex0, int tindex1, List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        public static Dictionary<uint, List<int>> GetTriangleEdgePair(List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        static void AddTriangleEdge(int v0, int v1, int tindex, Dictionary<uint, List<int>> triangleEdgeDict)
        {
            throw new NotImplementedException();
        }

        public static List<ulong> GetTrianglePackList(List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        public static float ClosestPtBoneLine(Vector3 pos, Transform bone, float lineWidth, out Vector3 d)
        {
            throw new NotImplementedException();
        }

        public static List<Transform> GetUseBoneTransformList(Transform[] bones, Mesh mesh)
        {
            throw new NotImplementedException();
        }

        private class TetraVertex
        {
            public int index;
            public Vector3 pos;
            public TetraVertex()
            {
                throw new NotImplementedException();
            }

            public TetraVertex(Vector3 pos, int index)
            {
                throw new NotImplementedException();
            }
        }

        private class Tetra
        {
            public List<TetraVertex> vertexList = new List<TetraVertex>();
            public Vector3 circumCenter;
            public float circumRadius;
            public Vector3 tetraCenter;
            public float tetraSize;
            public Tetra()
            {
                throw new NotImplementedException();
            }

            public Tetra(TetraVertex a, TetraVertex b, TetraVertex c, TetraVertex d)
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

            public bool ContainsPoint(TetraVertex p1)
            {
                throw new NotImplementedException();
            }

            public bool ContainsPoint(TetraVertex p1, TetraVertex p2, TetraVertex p3, TetraVertex p4)
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

        public static void CalcTetraMesh(List<Vector3> posList, out int tetraCount, out List<int> tetraIndexList, out List<float> tetraSizeList)
        {
            throw new NotImplementedException();
        }

        public static Transform GetReplaceBone<T>(Transform now, Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }
    }
}