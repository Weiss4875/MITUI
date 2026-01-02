using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class PhysicsTeam : CoreComponent
    {
        protected PhysicsTeamData teamData = new PhysicsTeamData();
        public enum TeamUpdateMode
        {
            Normal = 0,
            UnityPhysics = 1,
        }

        public enum TeamCullingMode
        {
            Reset = 0,
            Pause = 10,
            Off = 100,
        }

        public enum TeamSkinningMode
        {
            None = 0,
            UserAnimation = 1,
        }

        protected int teamId = -1;
        protected ChunkData particleChunk = new ChunkData();
        protected Transform influenceTarget;
        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public int TeamId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PhysicsTeamData TeamData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ChunkData ParticleChunk
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Transform InfluenceTarget
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

        public float UserBlendWeight
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

        public TeamUpdateMode UpdateMode
        {
            get
            {
                throw new NotImplementedException();
            }

            protected set
            {
                throw new NotImplementedException();
            }
        }

        public TeamCullingMode CullingMode
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

        public TeamSkinningMode SkinningMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal bool UseAnimatedPose
        {
            get
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

        public bool IsActive()
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ChunkData CreateParticle(int team, int count, System.Func<int, uint> funcFlag, System.Func<int, float3> funcWpos, System.Func<int, quaternion> funcWrot, System.Func<int, float> funcDepth, System.Func<int, float3> funcRadius, System.Func<int, float3> funcTargetLocalPos)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllParticle()
        {
            throw new NotImplementedException();
        }

        public void EnableParticle(System.Func<int, Transform> funcTarget, System.Func<int, float3> funcLpos, System.Func<int, quaternion> funcLrot)
        {
            throw new NotImplementedException();
        }

        public void DisableParticle(System.Func<int, Transform> funcTarget, System.Func<int, float3> funcLpos, System.Func<int, quaternion> funcLrot)
        {
            throw new NotImplementedException();
        }

        public override Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }
    }
}