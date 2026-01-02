using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaCapsuleCollider : ColliderComponent
    {
        public enum Axis
        {
            X,
            Y,
            Z,
        }

        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        internal override void DataUpdate()
        {
            throw new NotImplementedException();
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public Axis AxisMode
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

        public float Length
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

        public float StartRadius
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

        public float EndRadius
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

        protected override ChunkData CreateColliderParticleReal(int teamId)
        {
            throw new NotImplementedException();
        }

        uint GetCapsuleFlag()
        {
            throw new NotImplementedException();
        }

        public Vector3 GetLocalDir()
        {
            throw new NotImplementedException();
        }

        public Vector3 GetLocalUp()
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