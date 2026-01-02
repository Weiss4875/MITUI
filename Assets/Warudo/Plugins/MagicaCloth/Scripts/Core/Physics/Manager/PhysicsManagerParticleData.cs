using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerParticleData : PhysicsManagerAccess
    {
        public const uint Flag_Enable = 0x00000001;
        public const uint Flag_Kinematic = 0x00000002;
        public const uint Flag_Hold = 0x00000004;
        public const uint Flag_Collider = 0x00000010;
        public const uint Flag_Plane = 0x00000020;
        public const uint Flag_CapsuleX = 0x00000040;
        public const uint Flag_CapsuleY = 0x00000080;
        public const uint Flag_CapsuleZ = 0x00000100;
        public const uint Flag_Box = 0x00000200;
        public const uint Flag_TriangleRotation = 0x00000400;
        public const uint Flag_Transform_Read_Pos = 0x00001000;
        public const uint Flag_Transform_Read_Rot = 0x00002000;
        public const uint Flag_Transform_Read_Base = 0x00004000;
        public const uint Flag_Transform_Read_Local = 0x00008000;
        public const uint Flag_Transform_Read_Scl = 0x00010000;
        public const uint Flag_Transform_Write = 0x00020000;
        public const uint Flag_Transform_Restore = 0x00040000;
        public const uint Flag_Transform_UnityPhysics = 0x00080000;
        public const uint Flag_Transform_Parent = 0x00100000;
        public const uint Flag_Step_Update = 0x01000000;
        public const uint Flag_Reset_Position = 0x02000000;
        public struct ParticleFlag
        {
            public uint flag;
            public ParticleFlag(params uint[] flags)
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

            public bool IsValid()
            {
                throw new NotImplementedException();
            }

            public void SetEnable(bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsFixed()
            {
                throw new NotImplementedException();
            }

            public bool IsMove()
            {
                throw new NotImplementedException();
            }

            public bool IsKinematic()
            {
                throw new NotImplementedException();
            }

            public bool IsHold()
            {
                throw new NotImplementedException();
            }

            public bool IsCollider()
            {
                throw new NotImplementedException();
            }

            public bool IsReadTransform()
            {
                throw new NotImplementedException();
            }

            public bool IsWriteTransform()
            {
                throw new NotImplementedException();
            }

            public bool IsRestoreTransform()
            {
                throw new NotImplementedException();
            }

            public bool IsUnityPhysics()
            {
                throw new NotImplementedException();
            }

            public bool IsReadSclTransform()
            {
                throw new NotImplementedException();
            }

            public bool IsParentTransform()
            {
                throw new NotImplementedException();
            }
        }

        public FixedChunkNativeArray<ParticleFlag> flagList;
        public FixedChunkNativeArray<int> teamIdList;
        public FixedChunkNativeArray<float3> posList;
        public FixedChunkNativeArray<quaternion> rotList;
        public FixedChunkNativeArray<float3> oldPosList;
        public FixedChunkNativeArray<quaternion> oldRotList;
        public FixedChunkNativeArray<float3> oldSlowPosList;
        public FixedChunkNativeArray<float3> localPosList;
        public FixedChunkNativeArray<float3> basePosList;
        public FixedChunkNativeArray<quaternion> baseRotList;
        public FixedChunkNativeArray<float3> snapBasePosList;
        public FixedChunkNativeArray<quaternion> snapBaseRotList;
        public FixedChunkNativeArray<float3> oldBasePosList;
        public FixedChunkNativeArray<quaternion> oldBaseRotList;
        public FixedChunkNativeArray<float> depthList;
        public FixedChunkNativeArray<float3> radiusList;
        public FixedChunkNativeArray<int> restoreTransformIndexList;
        public FixedChunkNativeArray<int> transformIndexList;
        public FixedChunkNativeArray<float> frictionList;
        public FixedChunkNativeArray<float> staticFrictionList;
        public FixedChunkNativeArray<float3> velocityList;
        public FixedChunkNativeArray<int> collisionLinkIdList;
        public FixedChunkNativeArray<float3> collisionNormalList;
        FixedChunkNativeArray<float3> nextPos0List;
        FixedChunkNativeArray<float3> nextPos1List;
        int nextPosSwitch = 0;
        FixedChunkNativeArray<quaternion> nextRot0List;
        FixedChunkNativeArray<quaternion> nextRot1List;
        int nextRotSwitch = 0;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public ChunkData CreateParticle(uint flag, int team, float3 wpos, quaternion wrot, float depth, float3 radius, float3 targetLocalPos)
        {
            throw new NotImplementedException();
        }

        public ChunkData CreateParticle(int team, int count, System.Func<int, uint> funcFlag, System.Func<int, float3> funcWpos, System.Func<int, quaternion> funcWrot, System.Func<int, float> funcDepth, System.Func<int, float3> funcRadius, System.Func<int, float3> funcTargetLocalPos)
        {
            throw new NotImplementedException();
        }

        public void RemoveParticle(ChunkData c)
        {
            throw new NotImplementedException();
        }

        public void SetEnable(ChunkData c, bool sw, System.Func<int, Transform> funcTarget, System.Func<int, float3> funcLpos, System.Func<int, quaternion> funcLrot)
        {
            throw new NotImplementedException();
        }

        public void SetRadius(int index, float3 radius)
        {
            throw new NotImplementedException();
        }

        public void SetLocalPos(int index, Vector3 lpos)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Length
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

        public bool IsValid(int index)
        {
            throw new NotImplementedException();
        }

        public int GetTeamId(int index)
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePredictionTransform(int index)
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePredictionTransform(ChunkData c)
        {
            throw new NotImplementedException();
        }

        public FixedChunkNativeArray<float3> InNextPosList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FixedChunkNativeArray<float3> OutNextPosList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SwitchingNextPosList()
        {
            throw new NotImplementedException();
        }

        public FixedChunkNativeArray<quaternion> InNextRotList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FixedChunkNativeArray<quaternion> OutNextRotList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SwitchingNextRotList()
        {
            throw new NotImplementedException();
        }

        public void UpdateBoneToParticle()
        {
            throw new NotImplementedException();
        }

        struct CopyBoneToParticleJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerTeamData.TeamData> teamData;
            public NativeArray<PhysicsManagerTeamData.WorldInfluence> teamWorldInfluenceList;
            public NativeArray<ParticleFlag> flagList;
            public NativeArray<float> depthList;
            public NativeArray<int> transformIndexList;
            public NativeArray<float3> localPosList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> velocityList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<float3> posList;
            public NativeArray<float3> oldPosList;
            public NativeArray<quaternion> oldRotList;
            public NativeArray<float3> oldSlowPosList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> oldBasePosList;
            public NativeArray<quaternion> oldBaseRotList;
            public NativeArray<float3> nextPosList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        public void UpdateResetParticle()
        {
            throw new NotImplementedException();
        }

        struct ResetParticleJob : IJobParallelFor
        {
            public NativeArray<PhysicsManagerTeamData.TeamData> teamData;
            public NativeArray<ParticleFlag> flagList;
            public NativeArray<int> teamIdList;
            public NativeArray<float3> snapBasePosList;
            public NativeArray<quaternion> snapBaseRotList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> oldBasePosList;
            public NativeArray<quaternion> oldBaseRotList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeArray<float3> oldPosList;
            public NativeArray<quaternion> oldRotList;
            public NativeArray<float3> oldSlowPosList;
            public NativeArray<float3> velocityList;
            public NativeArray<float3> nextPosList;
            public NativeArray<quaternion> nextRotList;
            public NativeArray<float3> localPosList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        public bool UpdateParticleToBone()
        {
            throw new NotImplementedException();
        }

        struct CopyParticleToBoneJob : IJobParallelFor
        {
            public NativeArray<ParticleFlag> flagList;
            public NativeArray<float3> posList;
            public NativeArray<quaternion> rotList;
            public NativeMultiHashMap<int, int> transformParticleIndexMap;
            public NativeArray<int> writeBoneIndexList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}