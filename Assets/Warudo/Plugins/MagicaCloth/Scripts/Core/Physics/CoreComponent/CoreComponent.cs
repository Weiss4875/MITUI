using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace
    {
        protected int dataHash;
        protected int dataVersion;
        protected RuntimeStatus status = new RuntimeStatus();
        public RuntimeStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsVisible { get; protected set; }

        protected int calculateValue = -1;
        public bool IsCalculate => throw new NotImplementedException();
        public abstract int GetDataHash();
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

        protected virtual void Start()
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

        protected virtual void OnDestroy()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        protected abstract void OnInit();
        protected abstract void OnDispose();
        protected abstract void OnUpdate();
        protected abstract void OnActive();
        protected abstract void OnInactive();
        protected virtual void OnUpdateStatus()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDisconnectedStatus()
        {
            throw new NotImplementedException();
        }

        public void SetUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        protected virtual void ChangeUseUnityPhysics(bool sw)
        {
            throw new NotImplementedException();
        }

        protected bool IsUseUnityPhysics()
        {
            throw new NotImplementedException();
        }

        public virtual List<ShareDataObject> GetAllShareDataObject()
        {
            throw new NotImplementedException();
        }

        public abstract ShareDataObject DuplicateShareDataObject(ShareDataObject source);
        protected void SetUserEnable(bool sw)
        {
            throw new NotImplementedException();
        }

        internal virtual void UpdateCullingMode(CoreComponent Caller)
        {
            throw new NotImplementedException();
        }

        protected virtual void OnChangeCalculation()
        {
            throw new NotImplementedException();
        }

        public abstract int GetVersion();
        public abstract int GetErrorVersion();
        public virtual Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        public Define.Error VerifyDataVersion()
        {
            throw new NotImplementedException();
        }

        public bool IsOldDataVertion()
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

        public virtual bool UpgradeFormat()
        {
            throw new NotImplementedException();
        }

        public void ChangeAvatar<T>(Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }

        public virtual void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
            where T : class
        {
            throw new NotImplementedException();
        }

        public virtual HashSet<Transform> GetUsedBones()
        {
            throw new NotImplementedException();
        }

        public virtual int GetEditorPositionNormalTangent(out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector3> wtanList)
        {
            throw new NotImplementedException();
        }

        public virtual List<int> GetEditorTriangleList()
        {
            throw new NotImplementedException();
        }

        public virtual List<int> GetEditorLineList()
        {
            throw new NotImplementedException();
        }

        public virtual List<int> GetSelectionList()
        {
            throw new NotImplementedException();
        }

        public virtual List<int> GetUseList()
        {
            throw new NotImplementedException();
        }
    }
}