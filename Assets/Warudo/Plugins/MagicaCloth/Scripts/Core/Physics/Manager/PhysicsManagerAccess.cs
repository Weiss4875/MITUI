using System;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class PhysicsManagerAccess : IDisposable
    {
        protected MagicaPhysicsManager manager;
        public UpdateTimeManager UpdateTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerParticleData Particle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerBoneData Bone
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerMeshData Mesh
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerTeamData Team
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerWindData Wind
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerComponent Component
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected PhysicsManagerCompute Compute
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetParent(MagicaPhysicsManager manager)
        {
            throw new NotImplementedException();
        }

        public abstract void Create();
        public abstract void Dispose();
    }
}