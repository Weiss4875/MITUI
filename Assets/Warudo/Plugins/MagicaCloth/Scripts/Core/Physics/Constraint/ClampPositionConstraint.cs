using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClampPositionConstraint : PhysicsManagerConstraint
    {
        public struct GroupData
        {
            public int teamId;
            public int active;
            public CurveParam limitLength;
            public float3 axisRatio;
            public float velocityInfluence;
            public bool IsAxisCheck()
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<GroupData> groupList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Release()
        {
            throw new NotImplementedException();
        }

        public int AddGroup(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void ChangeParam(int teamId, bool active, BezierParam limitLength, float3 axisRatio, float velocityInfluence)
        {
            throw new NotImplementedException();
        }

        public override JobHandle SolverConstraint(int runCount, float dtime, float updatePower, int iteration, JobHandle jobHandle)
        {
            throw new NotImplementedException();
        }

        struct ClampPositionJob : IJobParallelFor
        {
            public int runCount;
            public float maxMoveLength;
            public NativeArray<GroupData> clampPositionGroupList;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<int> teamIdList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<float> depthList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> nextPosList;
            public NativeArray<float3> posList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}