using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public partial class MagicaPhysicsManager : CreateSingleton<MagicaPhysicsManager>
    {
        UpdateTimeManager updateTime = new UpdateTimeManager();
        PhysicsManagerParticleData particle = new PhysicsManagerParticleData();
        PhysicsManagerBoneData bone = new PhysicsManagerBoneData();
        PhysicsManagerMeshData mesh = new PhysicsManagerMeshData();
        PhysicsManagerTeamData team = new PhysicsManagerTeamData();
        PhysicsManagerWindData wind = new PhysicsManagerWindData();
        PhysicsManagerComponent component = new PhysicsManagerComponent();
        PhysicsManagerCompute compute = new PhysicsManagerCompute();
        public PhysicsManagerPreUpdateEvent OnPreUpdate = new PhysicsManagerPreUpdateEvent();
        public PhysicsManagerPostUpdateEvent OnPostUpdate = new PhysicsManagerPostUpdateEvent();
        public UpdateTimeManager UpdateTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerParticleData Particle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerBoneData Bone
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerMeshData Mesh
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerTeamData Team
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerWindData Wind
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerComponent Component
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsManagerCompute Compute
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDelay
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsActive
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

        public bool IsFasterWrite
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal ComputeShader MeshWriterShader
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override void Awake()
        {
            throw new NotImplementedException();
        }

        protected override void InitSingleton()
        {
            throw new NotImplementedException();
        }

        protected override void DuplicateDetection(MagicaPhysicsManager duplicate)
        {
            throw new NotImplementedException();
        }

        protected void OnEnable()
        {
            throw new NotImplementedException();
        }

        protected void OnDisable()
        {
            throw new NotImplementedException();
        }

        protected override void OnDestroy()
        {
            throw new NotImplementedException();
        }

        public static void InitCustomGameLoop()
        {
            throw new NotImplementedException();
        }

        public static void SetCustomGameLoop(ref PlayerLoopSystem playerLoop)
        {
            throw new NotImplementedException();
        }
    }
}