using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System.Linq;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class BaseCloth : PhysicsTeam
    {
        protected ClothParams clothParams = new ClothParams();
        protected List<int> clothParamDataHashList = new List<int>();
        protected int clothDataHash;
        protected int clothDataVersion;
        protected ClothSetup setup = new ClothSetup();
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public ClothParams Params
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ClothData ClothData
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

        public SelectionData ClothSelection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ClothSetup Setup
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected virtual void Reset()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnValidate()
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

        protected override void OnDispose()
        {
            throw new NotImplementedException();
        }

        internal override void UpdateCullingMode(CoreComponent caller)
        {
            throw new NotImplementedException();
        }

        protected override void OnChangeCalculation()
        {
            throw new NotImplementedException();
        }

        public int GetCullRenderListCount()
        {
            throw new NotImplementedException();
        }

        void BaseClothInit()
        {
            throw new NotImplementedException();
        }

        void BaseClothDispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void ClothInit()
        {
            throw new NotImplementedException();
        }

        protected virtual void ClothActive()
        {
            throw new NotImplementedException();
        }

        protected virtual void ClothInactive()
        {
            throw new NotImplementedException();
        }

        protected virtual void ClothDispose()
        {
            throw new NotImplementedException();
        }

        protected abstract uint UserFlag(int vindex);
        protected abstract Transform UserTransform(int vindex);
        protected abstract float3 UserTransformLocalPosition(int vindex);
        protected abstract quaternion UserTransformLocalRotation(int vindex);
        public abstract bool IsRequiresDeformer();
        public abstract BaseMeshDeformer GetDeformer();
        protected abstract MeshData GetMeshData();
        protected abstract void WorkerInit();
        void SetUseMesh(bool sw)
        {
            throw new NotImplementedException();
        }

        void SetUseVertex(bool sw)
        {
            throw new NotImplementedException();
        }

        protected abstract void SetDeformerUseVertex(bool sw, BaseMeshDeformer deformer);
        internal void DeformerForEach(System.Action<BaseMeshDeformer> act)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlend()
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

        protected override void ChangeUseUnityPhysics(bool sw)
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

        public bool HasChangedParam(ClothParams.ParamType ptype)
        {
            throw new NotImplementedException();
        }

        public Define.Error VerifyAlgorithmVersion()
        {
            throw new NotImplementedException();
        }

        public override bool UpgradeFormat()
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
    }
}