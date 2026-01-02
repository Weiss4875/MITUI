using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ColliderCollisionConstraint : PhysicsManagerConstraint
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool useCollision)
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct CollisionJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> radiusList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> localPosList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<int> transformIndexList;
            public NativeArray<int> colliderList;
            public NativeArray<float3> boneSclList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<float> frictionList;
            public NativeArray<int> collisionLinkIdList;
            public NativeArray<float3> collisionNormalList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }

            float SphereColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal)
            {
                throw new NotImplementedException();
            }

            float CapsuleColliderDetection(ref float3 nextpos, float radius, int cindex, float3 dir, out float3 normal)
            {
                throw new NotImplementedException();
            }

            float PlaneColliderDetection(ref float3 nextpos, float radius, int cindex, out float3 normal)
            {
                throw new NotImplementedException();
            }
        }
    }
}