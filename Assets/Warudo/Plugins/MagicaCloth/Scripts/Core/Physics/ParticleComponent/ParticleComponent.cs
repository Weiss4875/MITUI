using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class ParticleComponent : BaseComponent, IDataHash
    {
        protected Dictionary<int, ChunkData> particleDict = new Dictionary<int, ChunkData>();
        protected RuntimeStatus status = new RuntimeStatus();
        public RuntimeStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public abstract int GetDataHash();
        public int CenterParticleIndex
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

        void Init()
        {
            throw new NotImplementedException();
        }

        protected void OnUpdateStatus()
        {
            throw new NotImplementedException();
        }

        public virtual bool VerifyData()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnInit()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnUpdate()
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

        protected void EnableParticle()
        {
            throw new NotImplementedException();
        }

        protected void DisableParticle()
        {
            throw new NotImplementedException();
        }

        protected void EnableTeamParticle(int teamId)
        {
            throw new NotImplementedException();
        }

        protected void DisableTeamParticle(int teamId)
        {
            throw new NotImplementedException();
        }

        protected void ReserveDataUpdate()
        {
            throw new NotImplementedException();
        }

        internal virtual void DataUpdate()
        {
            throw new NotImplementedException();
        }

        internal void UpdateStatus()
        {
            throw new NotImplementedException();
        }

        protected ChunkData CreateParticle(uint flag, int teamId, float depth, float3 radius, float3 localPos)
        {
            throw new NotImplementedException();
        }

        protected void RemoveTeamParticle(int teamId)
        {
            throw new NotImplementedException();
        }

        protected void RemoveParticle()
        {
            throw new NotImplementedException();
        }

        protected Transform UserTransform(int vindex)
        {
            throw new NotImplementedException();
        }

        protected float3 UserTransformLocalPosition(int vindex)
        {
            throw new NotImplementedException();
        }

        protected quaternion UserTransformLocalRotation(int vindex)
        {
            throw new NotImplementedException();
        }
    }
}