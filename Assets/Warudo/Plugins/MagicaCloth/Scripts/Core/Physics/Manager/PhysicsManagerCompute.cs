using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Jobs;
using UnityEngine.Profiling;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerCompute : PhysicsManagerAccess
    {
        List<PhysicsManagerConstraint> constraints = new List<PhysicsManagerConstraint>();
        public ClampPositionConstraint ClampPosition { get; private set; }

        public ClampDistanceConstraint ClampDistance { get; private set; }

        public ClampRotationConstraint ClampRotation { get; private set; }

        public SpringConstraint Spring { get; private set; }

        public RestoreDistanceConstraint RestoreDistance { get; private set; }

        public RestoreRotationConstraint RestoreRotation { get; private set; }

        public TriangleBendConstraint TriangleBend { get; private set; }

        public ColliderCollisionConstraint Collision { get; private set; }

        public PenetrationConstraint Penetration { get; private set; }

        public ColliderExtrusionConstraint ColliderExtrusion { get; private set; }

        public TwistConstraint Twist { get; private set; }

        public CompositeRotationConstraint CompositeRotation { get; private set; }

        List<PhysicsManagerWorker> workers = new List<PhysicsManagerWorker>();
        public RenderMeshWorker RenderMeshWorker { get; private set; }

        public VirtualMeshWorker VirtualMeshWorker { get; private set; }

        public MeshParticleWorker MeshParticleWorker { get; private set; }

        public SpringMeshWorker SpringMeshWorker { get; private set; }

        public AdjustRotationWorker AdjustRotationWorker { get; private set; }

        public LineWorker LineWorker { get; private set; }

        public TriangleWorker TriangleWorker { get; private set; }

        public BaseSkinningWorker BaseSkinningWorker { get; private set; }

        JobHandle jobHandle;
        public CustomSampler SamplerCalcMesh { get; set; }

        public CustomSampler SamplerWriteMesh { get; set; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        internal void UpdateRestoreBone(PhysicsTeam.TeamUpdateMode updateMode)
        {
            throw new NotImplementedException();
        }

        internal void UpdateReadBone()
        {
            throw new NotImplementedException();
        }

        internal void UpdateTeamAlways()
        {
            throw new NotImplementedException();
        }

        internal void UpdateStartSimulation(UpdateTimeManager update)
        {
            throw new NotImplementedException();
        }

        internal void UpdateCompleteSimulation()
        {
            throw new NotImplementedException();
        }

        internal void UpdateWriteBone()
        {
            throw new NotImplementedException();
        }

        internal void MeshCalculation()
        {
            throw new NotImplementedException();
        }

        internal void NormalWritingMesh()
        {
            throw new NotImplementedException();
        }

        internal void UpdateReadWriteBone()
        {
            throw new NotImplementedException();
        }

        internal void UpdateSyncBuffer()
        {
            throw new NotImplementedException();
        }

        internal void UpdateSwapBuffer()
        {
            throw new NotImplementedException();
        }

        public JobHandle MasterJob
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

        public void InitJob()
        {
            throw new NotImplementedException();
        }

        public void ScheduleJob()
        {
            throw new NotImplementedException();
        }

        public void CompleteJob()
        {
            throw new NotImplementedException();
        }

        public int SwapIndex
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        void UpdatePhysics(int updateCount, int runCount, float updatePower, float updateDeltaTime)
        {
            throw new NotImplementedException();
        }

        struct ForceAndVelocityJob : IJobParallelFor
        {
            public float updateDeltaTime;
            public float updatePower;
            public int runCount;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<CurveParam> teamMassList;
            public NativeArray<CurveParam> teamGravityList;
            public NativeArray<CurveParam> teamDragList;
            public NativeArray<CurveParam> teamDepthInfluenceList;
            public NativeArray<PhysicsManagerTeamData.WindInfo> teamWindInfoList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float> depthList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> oldBasePosList;
            public NativeArray<quaternion> oldBaseRotList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> oldPosList;
            public NativeArray<quaternion> oldRotList;
            public NativeArray<float3> velocityList;
            public NativeArray<PhysicsManagerWindData.WindData> windDataList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }

            float3 Wind(int teamId, in PhysicsManagerTeamData.TeamData teamData, in float3 pos)
            {
                throw new NotImplementedException();
            }
        }

        struct FixPositionJob : IJobParallelFor
        {
            public float updatePower;
            public float updateDeltaTime;
            public int runCount;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<CurveParam> teamMaxVelocityList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float> depthList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float> frictionList;
            public NativeArray<float3> velocityList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> oldPosList;
            public NativeArray<quaternion> oldRotList;
            public NativeArray<float3> posList;
            public NativeArray<float3> localPosList;
            public NativeArray<float3> collisionNormalList;
            public NativeArray<float> staticFrictionList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        void PostUpdatePhysics(float updateDeltaTime)
        {
            throw new NotImplementedException();
        }

        struct PostUpdatePhysicsJob : IJobParallelFor
        {
            public float updateDeltaTime;
            public NativeArray<PhysicsManagerTeamData.TeamData> teamDataList;
            public NativeArray<PhysicsManagerParticleData.ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> oldBasePosList;
            public NativeArray<quaternion> oldBaseRotList;
            public NativeArray<float3> velocityList;
            public NativeArray<float3> localPosList;
            public NativeArray<float3> oldPosList;
            public NativeArray<quaternion> oldRotList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> oldSlowPosList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        void WarmupWorker()
        {
            throw new NotImplementedException();
        }
    }
}