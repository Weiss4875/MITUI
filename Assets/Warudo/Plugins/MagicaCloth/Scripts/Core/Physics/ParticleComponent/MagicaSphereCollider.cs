using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaSphereCollider : ColliderComponent
    {
        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        internal override void DataUpdate()
        {
            throw new NotImplementedException();
        }

        public float Radius
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

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        protected override ChunkData CreateColliderParticleReal(int teamId)
        {
            throw new NotImplementedException();
        }

        public float GetScale()
        {
            throw new NotImplementedException();
        }

        public override bool CalcNearPoint(Vector3 pos, out Vector3 p, out Vector3 dir, out Vector3 d, bool skinning)
        {
            throw new NotImplementedException();
        }
    }
}