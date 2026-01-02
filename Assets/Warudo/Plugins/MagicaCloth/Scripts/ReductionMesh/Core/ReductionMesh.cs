using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class ReductionMesh
    {
        public enum ReductionWeightMode
        {
            Distance = 0,
            Average = 1,
            DistanceAverage = 2,
        }

        public ReductionWeightMode WeightMode { get; set; }

        public MeshData MeshData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ReductionData ReductionData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DebugData DebugData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int AddMesh(bool isSkinning, Mesh mesh, List<Transform> bones, Matrix4x4[] bindPoseList, BoneWeight[] boneWeightList)
        {
            throw new NotImplementedException();
        }

        public int AddMesh(Renderer ren)
        {
            throw new NotImplementedException();
        }

        public int AddMesh(Transform root, List<Vector3> posList, List<Vector3> norList = null, List<Vector4> tanList = null, List<Vector2> uvList = null, List<int> triangleList = null)
        {
            throw new NotImplementedException();
        }

        public void Reduction(float zeroRadius, float radius, float polygonLength, bool createTetra)
        {
            throw new NotImplementedException();
        }

        public FinalData GetFinalData(Transform root)
        {
            throw new NotImplementedException();
        }
    }
}