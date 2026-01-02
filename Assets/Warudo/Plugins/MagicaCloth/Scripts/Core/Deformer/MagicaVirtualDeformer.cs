using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaVirtualDeformer : CoreComponent
    {
        internal PhysicsTeam.TeamCullingMode cullModeCash { get; private set; }

        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public VirtualMeshDeformer Deformer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        void OnValidate()
        {
            throw new NotImplementedException();
        }

        protected override void OnInit()
        {
            throw new NotImplementedException();
        }

        protected override void OnDispose()
        {
            throw new NotImplementedException();
        }

        protected override void OnUpdate()
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

        protected override void ChangeUseUnityPhysics(bool sw)
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
    }
}