using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class RenderMeshDeformer : BaseMeshDeformer, IBoneReplace
    {
        public enum RecalculateMode
        {
            None = 0,
            UpdateNormalPerFrame = 1,
            UpdateNormalAndTangentPerFrame = 2,
        }

        public enum BoundsMode
        {
            None = 0,
            ExpandedAtInitialization = 1,
        }

        Renderer renderer;
        MeshFilter meshFilter;
        SkinnedMeshRenderer skinMeshRenderer;
        Transform[] originalBones;
        Transform[] boneList;
        Mesh cloneMesh = null;
        GraphicsBuffer vertexBuffer;
        bool IsChangePosition { get; set; }

        bool IsChangeNormalTangent { get; set; }

        bool IsChangeBoneWeights { get; set; }

        bool oldUse;
        internal bool IsWriteSkip { get; set; }

        internal bool IsFasterWriteUpdate { get; private set; }

        internal bool IsWriteMeshPosition { get; private set; }

        internal bool IsWriteMeshBoneWeight { get; private set; }

        bool IsWriteMeshNormal;
        bool IsWriteMeshTangent;
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public Mesh SharedMesh
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal bool IsFasterWrite { get; private set; }

        public void OnValidate()
        {
            throw new NotImplementedException();
        }

        protected override void OnInit()
        {
            throw new NotImplementedException();
        }

        protected override void OnActive()
        {
            throw new NotImplementedException();
        }

        protected override void OnInactive()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        void SetRecalculateNormalAndTangentMode()
        {
            throw new NotImplementedException();
        }

        public override void ChangeUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        public void ChangeCalculation(bool sw)
        {
            throw new NotImplementedException();
        }

        public override bool IsMeshUse()
        {
            throw new NotImplementedException();
        }

        public override bool IsActiveMesh()
        {
            throw new NotImplementedException();
        }

        public override void AddUseMesh(System.Object parent)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUseMesh(System.Object parent)
        {
            throw new NotImplementedException();
        }

        public bool IsRendererVisible
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal bool HasNormal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal override void MeshCalculation(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal override void NormalWriting(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal bool FasterWriting(int bufferIndex, ComputeShader compute, int kernel, int index, ref int maxVertexCount)
        {
            throw new NotImplementedException();
        }

        public void ChangeNormalTangentUpdateMode()
        {
            throw new NotImplementedException();
        }

        public void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }

        public HashSet<Transform> GetUsedBones()
        {
            throw new NotImplementedException();
        }

        public override int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList)
        {
            throw new NotImplementedException();
        }

        public override List<int> GetEditorTriangleList()
        {
            throw new NotImplementedException();
        }

        public override List<int> GetEditorLineList()
        {
            throw new NotImplementedException();
        }

        public List<int> GetEditorUseList()
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

        public override string GetInformation()
        {
            throw new NotImplementedException();
        }
    }
}