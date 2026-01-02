using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class VirtualMeshDeformer : BaseMeshDeformer, IBoneReplace
    {
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        protected override void OnInit()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
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

        internal override void MeshCalculation(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        internal override void NormalWriting(int bufferIndex)
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

        public BaseMeshDeformer GetDeformer()
        {
            throw new NotImplementedException();
        }

        public float MergeVertexDistance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float MergeTriangleDistance
        {
            get
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
        }

        public int MaxWeightCount
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
        }

        public int RenderDeformerCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MagicaRenderDeformer GetRenderDeformer(int index)
        {
            throw new NotImplementedException();
        }

        public int GetRenderMeshDeformerIndex(RenderMeshDeformer deformer)
        {
            throw new NotImplementedException();
        }

        public List<MeshData> GetRenderDeformerMeshList()
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

        public override bool AddUseVertex(int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public override bool RemoveUseVertex(int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public override void ResetFuturePrediction()
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

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override void CreateVerifyData()
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