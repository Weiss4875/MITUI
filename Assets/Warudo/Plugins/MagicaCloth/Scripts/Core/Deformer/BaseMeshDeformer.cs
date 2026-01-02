using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class BaseMeshDeformer : IEditorMesh, IDataVerify, IDataHash
    {
        protected int dataHash;
        protected int dataVersion;
        protected RuntimeStatus status = new RuntimeStatus();
        public CoreComponent Parent
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

        public virtual MeshData MeshData
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

        public GameObject TargetObject
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

        public RuntimeStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int MeshIndex { get; protected set; }

        public int VertexCount { get; protected set; }

        public int SkinningVertexCount { get; protected set; }

        public int TriangleCount { get; protected set; }

        public virtual void Init()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnInit()
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual void OnEnable()
        {
            throw new NotImplementedException();
        }

        public virtual void OnDisable()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        internal abstract void MeshCalculation(int bufferIndex);
        internal abstract void NormalWriting(int bufferIndex);
        protected void OnUpdateStatus()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnActive()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnInactive()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsMeshUse()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsActiveMesh()
        {
            throw new NotImplementedException();
        }

        public bool IsSkinning
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void AddUseMesh(System.Object parent)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveUseMesh(System.Object parent)
        {
            throw new NotImplementedException();
        }

        public virtual bool AddUseVertex(int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public virtual bool RemoveUseVertex(int vindex, bool fix)
        {
            throw new NotImplementedException();
        }

        public virtual void ResetFuturePrediction()
        {
            throw new NotImplementedException();
        }

        public virtual void ChangeUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        public virtual int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public int SaveDataHash
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int SaveDataVersion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public abstract int GetVersion();
        public virtual Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        public virtual void CreateVerifyData()
        {
            throw new NotImplementedException();
        }

        public virtual string GetInformation()
        {
            throw new NotImplementedException();
        }

        public abstract int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList);
        public abstract List<int> GetEditorTriangleList();
        public abstract List<int> GetEditorLineList();
    }
}