using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class ColliderComponent : ParticleComponent
    {
        protected bool isGlobal;
        public Vector3 Center
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

        protected override void OnInit()
        {
            throw new NotImplementedException();
        }

        protected override void OnDispose()
        {
            throw new NotImplementedException();
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public abstract bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning);
        public Vector3 CalcLocalPos(Vector3 pos)
        {
            throw new NotImplementedException();
        }

        public Vector3 CalcLocalDir(Vector3 dir)
        {
            throw new NotImplementedException();
        }

        public ChunkData CreateColliderParticle(int teamId)
        {
            throw new NotImplementedException();
        }

        public void RemoveColliderParticle(int teamId)
        {
            throw new NotImplementedException();
        }

        protected abstract ChunkData CreateColliderParticleReal(int teamId);
    }
}