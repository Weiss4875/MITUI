using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerTeamData : PhysicsManagerAccess
    {
        public const uint Flag_Enable = 0x00000001;
        public const uint Flag_Interpolate = 0x00000002;
        public const uint Flag_FixedNonRotation = 0x00000004;
        public const uint Flag_AnimatedPose = 0x00000008;
        public const uint Flag_IgnoreClampPositionVelocity = 0x00000010;
        public const uint Flag_Collision = 0x00000020;
        public const uint Flag_AfterCollision = 0x00000040;
        public const uint Flag_UpdatePhysics = 0x00000080;
        public const uint Flag_Pause = 0x00000100;
        public const uint Flag_Reset_WorldInfluence = 0x00010000;
        public const uint Flag_Reset_Position = 0x00020000;
        public const uint Flag_Reset_Keep = 0x00080000;
        public const uint Flag_Wind = 0x00100000;
        public enum ForceMode
        {
            None,
            VelocityAdd,
            VelocityChange,
            VelocityAddWithoutMass = 10,
            VelocityChangeWithoutMass,
        }

        public struct TeamData
        {
            public ChunkData particleChunk;
            public ChunkData colliderChunk;
            public ChunkData skinningBoneChunk;
            public uint flag;
            public float dynamicFriction;
            public float staticFriction;
            public float selfCollisionRange;
            public int boneIndex;
            public float3 initScale;
            public float scaleRatio;
            public float3 scaleDirection;
            public float4 quaternionScale;
            public float time;
            public float oldTime;
            public float addTime;
            public float timeScale;
            public float nowTime;
            public float startTime;
            public int updateCount;
            public float blendRatio;
            public float3 externalForce;
            public float forceMassInfluence;
            public float forceWindInfluence;
            public float forceWindRandomScale;
            public float forceWindSynchronization;
            public float velocityWeight;
            public float velocityRecoverySpeed;
            public float3 gravityDirection;
            public ForceMode forceMode;
            public float3 impactForce;
            public int calcCount;
            public short restoreDistanceGroupIndex;
            public short triangleBendGroupIndex;
            public short clampDistanceGroupIndex;
            public short clampDistance2GroupIndex;
            public short clampPositionGroupIndex;
            public short clampRotationGroupIndex;
            public short restoreRotationGroupIndex;
            public short adjustRotationGroupIndex;
            public short springGroupIndex;
            public short volumeGroupIndex;
            public short airLineGroupIndex;
            public short lineWorkerGroupIndex;
            public short triangleWorkerGroupIndex;
            public short selfCollisionGroupIndex;
            public short edgeCollisionGroupIndex;
            public short penetrationGroupIndex;
            public short baseSkinningGroupIndex;
            public short twistGroupIndex;
            public short compositeRotationGroupIndex;
            public bool IsActive()
            {
                throw new NotImplementedException();
            }

            public bool IsRunning()
            {
                throw new NotImplementedException();
            }

            public bool IsUpdate(int runCount)
            {
                throw new NotImplementedException();
            }

            public bool IsInterpolate()
            {
                throw new NotImplementedException();
            }

            public bool IsPhysicsUpdate()
            {
                throw new NotImplementedException();
            }

            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsReset()
            {
                throw new NotImplementedException();
            }

            public bool IsPause()
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<TeamData> teamDataList;
        public FixedNativeList<CurveParam> teamMassList;
        public FixedNativeList<CurveParam> teamGravityList;
        public FixedNativeList<CurveParam> teamDragList;
        public FixedNativeList<CurveParam> teamMaxVelocityList;
        public FixedNativeList<CurveParam> teamDepthInfluenceList;
        public struct WorldInfluence
        {
            public CurveParam moveInfluence;
            public CurveParam rotInfluence;
            public float maxMoveSpeed;
            public float maxRotationSpeed;
            public float3 nowPosition;
            public float3 oldPosition;
            public float3 moveOffset;
            public float moveIgnoreRatio;
            public quaternion nowRotation;
            public quaternion oldRotation;
            public quaternion rotationOffset;
            public float rotationIgnoreRatio;
            public int resetTeleport;
            public float teleportDistance;
            public float teleportRotation;
            public ClothParams.TeleportMode teleportMode;
            public float stabilizationTime;
            public float clampRotationLimit;
        }

        public FixedNativeList<WorldInfluence> teamWorldInfluenceList;
        public struct WindInfo
        {
            public int windCount;
            public int4 windDataIndexList;
            public float3x4 windDirectionList;
            public float4 windMainList;
        }

        public FixedNativeList<WindInfo> teamWindInfoList;
        public FixedMultiNativeList<int> colliderList;
        public FixedMultiNativeList<int> skinningBoneList;
        int activeTeamCount;
        int normalUpdateCount = 0;
        int physicsUpdateCount = 0;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public int TeamCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int TeamLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ActiveTeamCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ColliderCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int NormalUpdateCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int PhysicsUpdateCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int PauseCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int CreateTeam(PhysicsTeam team, uint flag)
        {
            throw new NotImplementedException();
        }

        public void RemoveTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public void SetEnable(int teamId, bool sw)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(int teamId)
        {
            throw new NotImplementedException();
        }

        public bool IsValidData(int teamId)
        {
            throw new NotImplementedException();
        }

        public bool IsActive(int teamId)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int teamId, uint flag, bool sw)
        {
            throw new NotImplementedException();
        }

        public bool IsFlag(int teamId, uint flag)
        {
            throw new NotImplementedException();
        }

        public void SetParticleChunk(int teamId, ChunkData chunk)
        {
            throw new NotImplementedException();
        }

        public void SetFriction(int teamId, float dynamicFriction, float staticFriction)
        {
            throw new NotImplementedException();
        }

        public void SetMass(int teamId, BezierParam mass)
        {
            throw new NotImplementedException();
        }

        public void SetGravity(int teamId, BezierParam gravity)
        {
            throw new NotImplementedException();
        }

        public void SetGravityDirection(int teamId, float3 dir)
        {
            throw new NotImplementedException();
        }

        public void SetDrag(int teamId, BezierParam drag)
        {
            throw new NotImplementedException();
        }

        public void SetMaxVelocity(int teamId, BezierParam maxVelocity)
        {
            throw new NotImplementedException();
        }

        public void SetExternalForce(int teamId, float massInfluence, float windInfluence, float windRandomScale, float windSynchronization)
        {
            throw new NotImplementedException();
        }

        public void SetDepthInfluence(int teamId, BezierParam depthInfluence)
        {
            throw new NotImplementedException();
        }

        public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotatinSpeed, BezierParam moveInfluence, BezierParam rotInfluence, bool resetTeleport, float teleportDistance, float teleportRotation, float resetStabilizationTime, ClothParams.TeleportMode teleportMode, bool useClampRotation, BezierParam clampRotation)
        {
            throw new NotImplementedException();
        }

        float CalcClampRotationLimit(bool useClampRotation, BezierParam clampRotation)
        {
            throw new NotImplementedException();
        }

        public void SetWorldInfluence(int teamId, float maxSpeed, float maxRotationSpeed, BezierParam moveInfluence, BezierParam rotInfluence)
        {
            throw new NotImplementedException();
        }

        public void SetAfterTeleport(int teamId, bool resetTeleport, float teleportDistance, float teleportRotation, ClothParams.TeleportMode teleportMode)
        {
            throw new NotImplementedException();
        }

        public void SetStabilizationTime(int teamId, float resetStabilizationTime)
        {
            throw new NotImplementedException();
        }

        public void ResetWorldInfluenceTarget(int teamId, Transform target)
        {
            throw new NotImplementedException();
        }

        public void SetClampRotation(int teamId, bool useClampRotation, BezierParam clampRotation)
        {
            throw new NotImplementedException();
        }

        public void SetSelfCollisionRange(int teamId, float range)
        {
            throw new NotImplementedException();
        }

        public void SetBoneIndex(int teamId, int boneIndex, Vector3 initScale)
        {
            throw new NotImplementedException();
        }

        internal void AddColliderParticle(int teamId, int particleIndex)
        {
            throw new NotImplementedException();
        }

        internal void RemoveColliderParticle(int teamId, int particleIndex)
        {
            throw new NotImplementedException();
        }

        internal void RemoveCollider(int teamId, ColliderComponent collider)
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePredictionCollidere(int teamId)
        {
            throw new NotImplementedException();
        }

        public void AddSkinningBoneIndex(int teamId, List<Transform> boneList)
        {
            throw new NotImplementedException();
        }

        public void RemoveSkinningBoneIndex(int teamId)
        {
            throw new NotImplementedException();
        }

        public void SetTimeScale(int teamId, float timeScale)
        {
            throw new NotImplementedException();
        }

        public float GetTimeScale(int teamId)
        {
            throw new NotImplementedException();
        }

        public void SetBlendRatio(int teamId, float blendRatio)
        {
            throw new NotImplementedException();
        }

        public float GetBlendRatio(int teamId)
        {
            throw new NotImplementedException();
        }

        public void SetImpactForce(int teamId, float3 force, ForceMode mode)
        {
            throw new NotImplementedException();
        }

        public void ResetStabilizationTime(int teamId, float resetStabilizationTime = -1.0f)
        {
            throw new NotImplementedException();
        }

        public void SetUpdateMode(int teamId, PhysicsTeam.TeamUpdateMode updateMode)
        {
            throw new NotImplementedException();
        }

        public void ChangeUseUnityPhysics(int teamId, bool sw)
        {
            throw new NotImplementedException();
        }

        internal void ChangeBoneFlag(int teamId, PhysicsTeam.TeamCullingMode cullingMode, bool isCalculation)
        {
            throw new NotImplementedException();
        }

        internal void EarlyUpdateTeamAlways()
        {
            throw new NotImplementedException();
        }

        internal void PreUpdateTeamAlways()
        {
            throw new NotImplementedException();
        }

        internal int CalcMaxUpdateCount(int ups, float deltaTime, float physicsDeltaTime, float updateDeltaTime)
        {
            throw new NotImplementedException();
        }

        internal void PreUpdateTeamData(float deltaTime, float physicsDeltaTime, float updateDeltaTime, int ups, int maxUpdateCount)
        {
            throw new NotImplementedException();
        }

        struct PreProcessTeamDataJob : IJobParallelFor
        {
            public float deltaTime;
            public float physicsDeltaTime;
            public float updateDeltaTime;
            public float globalTimeScale;
            public int maxUpdateCount;
            public float unityTimeScale;
            public float elapsedTime;
            public NativeArray<TeamData> teamData;
            public NativeArray<WorldInfluence> teamWorldInfluenceList;
            public NativeArray<WindInfo> teamWindInfoList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public int windCount;
            public NativeArray<PhysicsManagerWindData.WindData> windData;
            public void Execute(int teamId)
            {
                throw new NotImplementedException();
            }

            void UpdateTime(ref TeamData tdata, bool reset, float dtime)
            {
                throw new NotImplementedException();
            }

            void Wind(ref TeamData tdata, float3 pos, int teamId)
            {
                throw new NotImplementedException();
            }
        }

        internal void PostUpdateTeamData()
        {
            throw new NotImplementedException();
        }

        struct PostProcessTeamDataJob : IJobParallelFor
        {
            public int fixedUpdateCount;
            public NativeArray<TeamData> teamData;
            public NativeArray<WorldInfluence> teamWorldInfluenceList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}