using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaBoneSpring : BaseCloth
    {
        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public BoneClothTarget ClothTarget
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MeshData MeshData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void Reset()
        {
            throw new NotImplementedException();
        }

        protected override void OnValidate()
        {
            throw new NotImplementedException();
        }

        protected override void ClothInit()
        {
            throw new NotImplementedException();
        }

        protected override void ClothDispose()
        {
            throw new NotImplementedException();
        }

        protected override void ClothActive()
        {
            throw new NotImplementedException();
        }

        protected override uint UserFlag(int index)
        {
            throw new NotImplementedException();
        }

        protected override Transform UserTransform(int index)
        {
            throw new NotImplementedException();
        }

        protected override float3 UserTransformLocalPosition(int vindex)
        {
            throw new NotImplementedException();
        }

        protected override quaternion UserTransformLocalRotation(int vindex)
        {
            throw new NotImplementedException();
        }

        public override bool IsRequiresDeformer()
        {
            throw new NotImplementedException();
        }

        public override BaseMeshDeformer GetDeformer()
        {
            throw new NotImplementedException();
        }

        protected override MeshData GetMeshData()
        {
            throw new NotImplementedException();
        }

        protected override void WorkerInit()
        {
            throw new NotImplementedException();
        }

        protected override void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer)
        {
            throw new NotImplementedException();
        }

        protected override void ChangeUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        protected override void OnChangeCalculation()
        {
            throw new NotImplementedException();
        }

        public List<Transform> GetTransformList()
        {
            throw new NotImplementedException();
        }

        Transform GetUseTransform(int index)
        {
            throw new NotImplementedException();
        }

        int UseTransformCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override int GetErrorVersion()
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

        public override void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
        {
            throw new NotImplementedException();
        }

        public override HashSet<Transform> GetUsedBones()
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

        public override List<int> GetSelectionList()
        {
            throw new NotImplementedException();
        }

        public override List<int> GetUseList()
        {
            throw new NotImplementedException();
        }

        public override List<ShareDataObject> GetAllShareDataObject()
        {
            throw new NotImplementedException();
        }

        public override ShareDataObject DuplicateShareDataObject(ShareDataObject source)
        {
            throw new NotImplementedException();
        }

        void ResetParams()
        {
            throw new NotImplementedException();
        }
    }
}