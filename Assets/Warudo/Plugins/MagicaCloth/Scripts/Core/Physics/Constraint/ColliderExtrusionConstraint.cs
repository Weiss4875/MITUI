using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ColliderExtrusionConstraint : PhysicsManagerConstraint
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
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

        struct CollisionExtrusionJob : IJobParallelFor
        {
            public int runCount;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<int> collisionLinkIdList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> collisionNormalList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}