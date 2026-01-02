using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaMeshSpring : BaseCloth
    {
        public enum Axis
        {
            X,
            Y,
            Z,
            InverseX,
            InverseY,
            InverseZ,
        }

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

        public SpringData SpringData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int UseVertexCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Transform CenterTransform
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

        public Axis DirectionAxis
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

        public Vector3 CenterTransformDirection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public SpringData.DeformerData GetDeformerData()
        {
            throw new NotImplementedException();
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

        public void VerifyDeformer()
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