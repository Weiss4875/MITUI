using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Profiling;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerBoneData : PhysicsManagerAccess
    {
        public const byte Flag_Reset = 0x01;
        public const byte Flag_Restore = 0x10;
        public const byte Flag_Write = 0x20;
        public FixedTransformAccessArray boneList;
        public FixedNativeList<byte> boneFlagList;
        public FixedNativeList<float3> bonePosList;
        public FixedNativeList<quaternion> boneRotList;
        public FixedNativeList<float3> boneSclList;
        public FixedNativeList<int> boneParentIndexList;
        public FixedNativeList<float3> basePosList;
        public FixedNativeList<quaternion> baseRotList;
        public FixedNativeList<short> boneUnityPhysicsList;
        public FixedNativeList<float3> futurePosList;
        public FixedNativeList<quaternion> futureRotList;
        public FixedTransformAccessArray restoreBoneList;
        public FixedNativeList<float3> restoreBoneLocalPosList;
        public FixedNativeList<quaternion> restoreBoneLocalRotList;
        public FixedNativeList<int> restoreBoneIndexList;
        public FixedTransformAccessArray writeBoneList;
        public FixedNativeList<int> writeBoneIndexList;
        public ExNativeMultiHashMap<int, int> writeBoneParticleIndexMap;
        Dictionary<int, int> boneToWriteIndexDict = new Dictionary<int, int>();
        public FixedNativeList<float3> writeBonePosList;
        public FixedNativeList<quaternion> writeBoneRotList;
        public bool hasBoneChanged { get; private set; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public int AddRestoreBone(Transform target, float3 lpos, quaternion lrot, int boneIndex)
        {
            throw new NotImplementedException();
        }

        public void RemoveRestoreBone(int restoreBoneIndex)
        {
            throw new NotImplementedException();
        }

        public int RestoreBoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int AddBone(Transform target, int pindex = -1, bool addParent = false)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBone(int boneIndex, int pindex = -1)
        {
            throw new NotImplementedException();
        }

        public void ChangeUnityPhysicsCount(int boneIndex, bool sw)
        {
            throw new NotImplementedException();
        }

        public void ResetFuturePrediction(int boneIndex)
        {
            throw new NotImplementedException();
        }

        public int ReadBoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int WriteBoneCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ResetBoneFromTransform(bool fixedUpdate)
        {
            throw new NotImplementedException();
        }

        struct RestoreBoneJob : IJobParallelForTransform
        {
            public bool fixedUpdate;
            public NativeArray<short> boneUnityPhysicsList;
            public NativeArray<byte> boneFlagList;
            public NativeArray<float3> restoreBoneLocalPosList;
            public NativeArray<quaternion> restoreBoneLocalRotList;
            public NativeArray<int> restoreBoneIndexList;
            public void Execute(int index, TransformAccess transform)
            {
                throw new NotImplementedException();
            }
        }

        public void ReadBoneFromTransform()
        {
            throw new NotImplementedException();
        }

        struct ReadBoneJob0 : IJobParallelForTransform
        {
            public int fixedUpdateCount;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<float3> futurePosList;
            public NativeArray<quaternion> futureRotList;
            public NativeArray<short> boneUnityPhysicsList;
            public NativeArray<byte> boneFlagList;
            public void Execute(int index, TransformAccess transform)
            {
                throw new NotImplementedException();
            }
        }

        struct ReadBoneJob1 : IJobParallelForTransform
        {
            public int fixedUpdateCount;
            public float normalFutureRatio;
            public float fixedFutureRatio;
            public float normalDeltaTime;
            public float fixedDeltaTime;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<float3> basePosList;
            public NativeArray<quaternion> baseRotList;
            public NativeArray<short> boneUnityPhysicsList;
            public NativeArray<float3> futurePosList;
            public NativeArray<quaternion> futureRotList;
            public NativeArray<byte> boneFlagList;
            public void Execute(int index, TransformAccess transform)
            {
                throw new NotImplementedException();
            }
        }

        public void ConvertWorldToLocal()
        {
            throw new NotImplementedException();
        }

        struct ConvertWorldToLocalJob : IJobParallelFor
        {
            public NativeArray<int> writeBoneIndexList;
            public NativeArray<byte> boneFlagList;
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> boneSclList;
            public NativeArray<int> boneParentIndexList;
            public NativeArray<float3> writeBonePosList;
            public NativeArray<quaternion> writeBoneRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        public void WriteBoneToTransform(int bufferIndex)
        {
            throw new NotImplementedException();
        }

        struct WriteBontToTransformJob2 : IJobParallelForTransform
        {
            public int fixedUpdateCount;
            public NativeArray<byte> boneFlagList;
            public NativeArray<int> writeBoneIndexList;
            public NativeArray<int> boneParentIndexList;
            public NativeArray<float3> writeBonePosList;
            public NativeArray<quaternion> writeBoneRotList;
            public NativeArray<short> boneUnityPhysicsList;
            public void Execute(int index, TransformAccess transform)
            {
                throw new NotImplementedException();
            }
        }

        public void CopyBoneBuffer()
        {
            throw new NotImplementedException();
        }

        struct CopyBoneJob0 : IJobParallelFor
        {
            public NativeArray<float3> bonePosList;
            public NativeArray<quaternion> boneRotList;
            public NativeArray<float3> backBonePosList;
            public NativeArray<quaternion> backBoneRotList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        struct CopyBoneJob1 : IJobParallelFor
        {
            public NativeArray<int> writeBoneIndexList;
            public NativeArray<int> backWriteBoneIndexList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }

        struct CopyBoneJob2 : IJobParallelFor
        {
            public NativeArray<byte> boneFlagList;
            public NativeArray<byte> backBoneFlagList;
            public void Execute(int index)
            {
                throw new NotImplementedException();
            }
        }
    }
}