using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClothData : ShareDataObject
    {
        public const uint VertexFlag_End = 0x00010000;
        public const uint VertexFlag_TriangleRotation = 0x00020000;
        public ClothParams.Algorithm triangleBendAlgorithm;
        public ClothParams.Algorithm restoreRotationAlgorithm;
        public ClothParams.Algorithm clampRotationAlgorithm;
        public List<int> useVertexList = new List<int>();
        public List<int> selectionData = new List<int>();
        public uint maxLevel;
        public List<uint> vertexFlagLevelList = new List<uint>();
        public List<float> vertexDepthList = new List<float>();
        public List<int> rootList = new List<int>();
        public List<int> parentList = new List<int>();
        public RestoreDistanceConstraint.RestoreDistanceData[] structDistanceDataList;
        public ReferenceDataIndex[] structDistanceReferenceList;
        public RestoreDistanceConstraint.RestoreDistanceData[] bendDistanceDataList;
        public ReferenceDataIndex[] bendDistanceReferenceList;
        public RestoreDistanceConstraint.RestoreDistanceData[] nearDistanceDataList;
        public ReferenceDataIndex[] nearDistanceReferenceList;
        public ClampDistanceConstraint.ClampDistanceData[] rootDistanceDataList;
        public ReferenceDataIndex[] rootDistanceReferenceList;
        public ClampDistance2Constraint.ClampDistance2Data[] clampDistance2DataList;
        public ClampDistance2Constraint.ClampDistance2RootInfo[] clampDistance2RootInfoList;
        public RestoreRotationConstraint.RotationData[] restoreRotationDataList;
        public ReferenceDataIndex[] restoreRotationReferenceList;
        public ClampRotationConstraint.ClampRotationData[] clampRotationDataList;
        public ClampRotationConstraint.ClampRotationRootInfo[] clampRotationRootInfoList;
        public CompositeRotationConstraint.RotationData[] compositeRotationDataList;
        public CompositeRotationConstraint.RootInfo[] compositeRotationRootInfoList;
        public TwistConstraint.TwistData[] twistDataList;
        public ReferenceDataIndex[] twistReferenceList;
        public AdjustRotationWorker.AdjustRotationData[] adjustRotationDataList;
        public TriangleBendConstraint.TriangleBendData[] triangleBendDataList;
        public ReferenceDataIndex[] triangleBendReferenceList;
        public int triangleBendWriteBufferCount;
        public VolumeConstraint.VolumeData[] volumeDataList;
        public ReferenceDataIndex[] volumeReferenceList;
        public int volumeWriteBufferCount;
        public LineWorker.LineRotationData[] lineRotationDataList;
        public LineWorker.LineRotationRootInfo[] lineRotationRootInfoList;
        public TriangleWorker.TriangleRotationData[] triangleRotationDataList;
        public int[] triangleRotationIndexList;
        public EdgeCollisionConstraint.EdgeCollisionData[] edgeCollisionDataList;
        public ReferenceDataIndex[] edgeCollisionReferenceList;
        public int edgeCollisionWriteBufferCount;
        public PenetrationConstraint.PenetrationData[] penetrationDataList;
        public ReferenceDataIndex[] penetrationReferenceList;
        public float3[] penetrationDirectionDataList;
        public ClothParams.PenetrationMode penetrationMode;
        public BaseSkinningWorker.BaseSkinningData[] baseSkinningDataList;
        public float4x4[] baseSkinningBindPoseList;
        public Vector3 initScale;
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public int VertexUseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int StructDistanceConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BendDistanceConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int NearDistanceConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ClampDistanceConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ClampDistance2ConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int RestoreRotationConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ClampRotationConstraintDataCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ClampRotationConstraintRootCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int AdjustRotationConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int CompositeRotationCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TwistConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TriangleBendConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int EdgeCollisionConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int VolumeConstraintCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int LineRotationWorkerCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TriangleRotationWorkerCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int PenetrationCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BaseSkinningCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int GetClampRotationCount()
        {
            throw new NotImplementedException();
        }

        public int GetRestoreRotationCount()
        {
            throw new NotImplementedException();
        }

        public bool IsInvalidVertex(int vindex)
        {
            throw new NotImplementedException();
        }

        public bool IsFixedVertex(int vindex)
        {
            throw new NotImplementedException();
        }

        public bool IsMoveVertex(int vindex)
        {
            throw new NotImplementedException();
        }

        public bool IsExtendVertex(int vindex)
        {
            throw new NotImplementedException();
        }

        public bool IsLastLevel(int vindex)
        {
            throw new NotImplementedException();
        }

        public bool IsFlag(int vindex, uint flag)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int vindex, uint flag)
        {
            throw new NotImplementedException();
        }

        public int GetLevel(int vindex)
        {
            throw new NotImplementedException();
        }

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        private class RestoreDistanceWork
        {
            public uint vertexPair;
            public float dist;
        }

        private class PenetrationBone
        {
            public Transform bone;
            public Transform childBone;
        }

        private class PenetrationWork
        {
            public Transform bone;
            public Transform childBone;
            public int boneIndex;
            public float distance;
            public float weight;
        }

        public void CreateData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, MeshData meshData, IEditorMesh editMesh, List<int> selData, System.Action<List<int>, List<int>, List<Vector3>, List<Vector3>, List<Vector3>, List<int>, List<int>> extensionAction = null)
        {
            throw new NotImplementedException();
        }

        void CreateVertexData(int vertexCount, List<int> lineList, List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        void CreateConstraintData(PhysicsTeam team, ClothParams clothParams, PhysicsTeamData teamData, int vertexCount, List<Vector3> wposList, List<Vector3> wnorList, List<Vector3> wtanList, List<int> lineList, List<int> triangleList)
        {
            throw new NotImplementedException();
        }

        void RegistTriangleBend(int v0, int v1, int v2, int v3, List<Vector3> wposList, ClothParams clothParams, List<TriangleBendConstraint.TriangleBendData> triangleBendData)
        {
            throw new NotImplementedException();
        }

        List<int> SortTetra(int v0, int v1, int v2, int v3, List<float> meshVertexDepthList)
        {
            throw new NotImplementedException();
        }

        List<int> CheckTetraDirection(int v0, int v1, int v2, int v3, HashSet<ulong> trianglePackSet, List<float> meshVertexDepthList)
        {
            throw new NotImplementedException();
        }

        bool CalcTriangleBendRestAngle(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, out float restAngle)
        {
            throw new NotImplementedException();
        }

        List<float> GetMeshVertexDepthList(int vertexCount, List<float> depthList)
        {
            throw new NotImplementedException();
        }

        List<int> GetUseParentVertexList(int vertexCount, List<HashSet<int>> vlink, List<Vector3> wposList, List<float> depthList)
        {
            throw new NotImplementedException();
        }

        List<int> GetUseRootVertexList(List<int> parentVertexList)
        {
            throw new NotImplementedException();
        }

        private class VertexInfo
        {
            public int vertexIndex;
            public int parentVertexIndex = -1;
            public List<int> childVertexList = new List<int>();
            public VertexInfo parentInfo;
            public List<VertexInfo> childInfoList = new List<VertexInfo>();
        }

        List<VertexInfo> GetUseVertexInfoList(List<int> parentVertexList)
        {
            throw new NotImplementedException();
        }

        List<List<int>> GetUseRootLineList(List<int> parentVertexList)
        {
            throw new NotImplementedException();
        }
    }
}