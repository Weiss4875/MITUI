using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClothParams
    {
        public enum Algorithm
        {
            Algorithm_1 = 0,
            Algorithm_2 = 1,
        }

        public enum TeleportMode
        {
            Reset = 0,
            Keep = 1,
        }

        public enum AdjustMode
        {
            Fixed = 0,
            XYMove = 1,
            XZMove = 2,
            YZMove = 3,
        }

        public enum PenetrationMode
        {
            SurfacePenetration = 0,
            ColliderPenetration = 1,
        }

        public enum PenetrationAxis
        {
            X = 0,
            Y = 1,
            Z = 2,
            InverseX = 3,
            InverseY = 4,
            InverseZ = 5,
        }

        public enum ParamType
        {
            Radius = 0,
            Mass = 1,
            Gravity = 2,
            Drag = 3,
            MaxVelocity = 4,
            WorldInfluence = 5,
            ClampDistance = 6,
            ClampPosition = 7,
            ClampRotation = 8,
            RestoreDistance = 9,
            RestoreRotation = 10,
            Spring = 11,
            AdjustRotation = 12,
            AirLine = 13,
            TriangleBend = 14,
            Volume = 15,
            ColliderCollision = 16,
            RotationInterpolation = 17,
            DistanceDisable = 18,
            ExternalForce = 19,
            Penetration = 20,
            Algorithm = 21,
            BaseSkinning = 22,
            Max,
        }

        public void SetChangeParam(ParamType ptype)
        {
            throw new NotImplementedException();
        }

        public bool ChangedParam(ParamType ptype)
        {
            throw new NotImplementedException();
        }

        public void ClearChangeParam()
        {
            throw new NotImplementedException();
        }

        public int GetParamHash(BaseCloth cloth, ParamType ptype)
        {
            throw new NotImplementedException();
        }

        public Algorithm AlgorithmType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetRadius(float sval, float eval)
        {
            throw new NotImplementedException();
        }

        public float GetRadius(float depth)
        {
            throw new NotImplementedException();
        }

        public BezierParam GetRadius()
        {
            throw new NotImplementedException();
        }

        public void SetMass(float sval, float eval, bool useEval = true, float cval = 0.0f, bool useCval = false)
        {
            throw new NotImplementedException();
        }

        public BezierParam GetMass()
        {
            throw new NotImplementedException();
        }

        public void SetGravity(bool sw, float sval = -9.8f, float eval = -9.8f)
        {
            throw new NotImplementedException();
        }

        public bool UseGravity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetGravity()
        {
            throw new NotImplementedException();
        }

        public Vector3 GravityDirection
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

        public void SetDrag(bool sw, float sval = 0.015f, float eval = 0.015f)
        {
            throw new NotImplementedException();
        }

        public bool UseDrag
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetDrag()
        {
            throw new NotImplementedException();
        }

        public void SetMaxVelocity(bool sw, float sval = 3, float eval = 3)
        {
            throw new NotImplementedException();
        }

        public bool UseMaxVelocity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetMaxVelocity()
        {
            throw new NotImplementedException();
        }

        public void SetExternalForce(float massInfluence, float windInfluence, float windRandomScale, float windSynchronization)
        {
            throw new NotImplementedException();
        }

        public float MassInfluence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BezierParam GetDepthInfluence() => throw new NotImplementedException();
        public float WindInfluence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float WindRandomScale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float WindSynchronization { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetWorldInfluence(float maxspeed, float moveval, float rotval)
        {
            throw new NotImplementedException();
        }

        public BezierParam GetWorldMoveInfluence()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetWorldRotationInfluence()
        {
            throw new NotImplementedException();
        }

        public Transform GetInfluenceTarget()
        {
            throw new NotImplementedException();
        }

        public void SetInfluenceTarget(Transform t)
        {
            throw new NotImplementedException();
        }

        public float MaxMoveSpeed
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

        public float MaxRotationSpeed
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

        public void SetTeleport(bool sw, float distance = 0.2f, float rotation = 45.0f, TeleportMode mode = TeleportMode.Reset)
        {
            throw new NotImplementedException();
        }

        public bool UseResetTeleport
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

        public float TeleportDistance
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

        public float TeleportRotation
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

        public TeleportMode TeleportResetMode
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

        public float ResetStabilizationTime
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

        public void SetDistanceDisable(bool sw, float distance = 20.0f, float fadeDistance = 5.0f, Transform referenceObject = null)
        {
            throw new NotImplementedException();
        }

        public bool UseDistanceDisable
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

        public Transform DisableReferenceObject
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

        public float DisableDistance
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

        public float DisableFadeDistance
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

        public void SetClampDistanceRatio(bool sw, float minval = 0.1f, float maxval = 1.05f, float influence = 0.2f)
        {
            throw new NotImplementedException();
        }

        public bool UseClampDistanceRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float ClampDistanceMinRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float ClampDistanceMaxRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float ClampDistanceVelocityInfluence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetClampPositionLength(bool sw, float sval = 0.03f, float eval = 0.2f, float ratioX = 1, float ratioY = 1, float ratioZ = 1, float influence = 0.2f)
        {
            throw new NotImplementedException();
        }

        public bool UseClampPositionLength
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3 ClampPositionAxisRatio
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetClampPositionLength()
        {
            throw new NotImplementedException();
        }

        public float ClampPositionVelocityInfluence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetClampRotationAngle(bool sw, float sval = 0.0f, float eval = 180.0f, float influence = 0.2f)
        {
            throw new NotImplementedException();
        }

        public bool UseClampRotation => throw new NotImplementedException();
        public BezierParam GetClampRotationAngle(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        public float ClampRotationVelocityInfluence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float GetClampRotationVelocityLimit(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        public void SetRestoreDistance(float influence = 1.0f, float structStiffness = 1.0f)
        {
            throw new NotImplementedException();
        }

        public float RestoreDistanceVelocityInfluence
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetStructDistanceStiffness()
        {
            throw new NotImplementedException();
        }

        public bool UseBendDistance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int BendDistanceMaxCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetBendDistanceStiffness()
        {
            throw new NotImplementedException();
        }

        public bool UseNearDistance
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int NearDistanceMaxCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float NearDistanceMaxDepth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetNearDistanceLength()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetNearDistanceStiffness()
        {
            throw new NotImplementedException();
        }

        public void SetRestoreRotation(bool sw, float sval = 0.02f, float eval = 0.001f, float influence = 0.3f)
        {
            throw new NotImplementedException();
        }

        public bool UseRestoreRotation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetRestoreRotationPower(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        public float GetRestoreRotationVelocityInfluence(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        public void SetSpring(bool sw, float power = 0.0f, float r = 0.0f, float sclx = 1, float scly = 1, float sclz = 1, float intensity = 1)
        {
            throw new NotImplementedException();
        }

        public void SetSpringDirectionAtten(float sval, float eval, float cval)
        {
            throw new NotImplementedException();
        }

        public void SetSpringDistanceAtten(float sval, float eval, float cval)
        {
            throw new NotImplementedException();
        }

        public bool UseSpring { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float GetSpringPower()
        {
            throw new NotImplementedException();
        }

        public float SpringPowr { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public float SpringRadius
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3 SpringRadiusScale
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float SpringIntensity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float GetSpringDirectionAtten(float ratio)
        {
            throw new NotImplementedException();
        }

        public float GetSpringDistanceAtten(float ratio)
        {
            throw new NotImplementedException();
        }

        public void SetAdjustRotation(AdjustMode amode = AdjustMode.Fixed, float power = 0.0f)
        {
            throw new NotImplementedException();
        }

        public AdjustMode AdjustRotationMode
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Vector3 AdjustRotationVector
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetTriangleBend(bool sw, float sval = 1.0f, float eval = 1.0f)
        {
            throw new NotImplementedException();
        }

        public bool UseTriangleBend
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetTriangleBendStiffness(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        internal bool GetUseTwistCorrection(Algorithm algo)
        {
            throw new NotImplementedException();
        }

        internal float TwistRecoveryPower => throw new NotImplementedException();
        public void SetVolume(bool sw, float maxLength = 0.05f, float stiffness = 0.5f, float shear = 0.5f)
        {
            throw new NotImplementedException();
        }

        public bool UseVolume
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float GetMaxVolumeLength()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetVolumeStretchStiffness()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetVolumeShearStiffness()
        {
            throw new NotImplementedException();
        }

        public void SetCollision(bool sw, float dynamicFriction = 0.1f, float staticFriction = 0.03f)
        {
            throw new NotImplementedException();
        }

        public bool UseCollision => throw new NotImplementedException();
        public float DynamicFriction => throw new NotImplementedException();
        public float StaticFriction => throw new NotImplementedException();
        public bool UsePenetration
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

        public PenetrationMode GetPenetrationMode()
        {
            throw new NotImplementedException();
        }

        public PenetrationAxis GetPenetrationAxis()
        {
            throw new NotImplementedException();
        }

        public float PenetrationMaxDepth
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BezierParam GetPenetrationConnectDistance()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetPenetrationRadius()
        {
            throw new NotImplementedException();
        }

        public BezierParam GetPenetrationDistance()
        {
            throw new NotImplementedException();
        }

        public bool UseLineAvarageRotation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool UseFixedNonRotation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ConvertToLatestAlgorithmParameter()
        {
            throw new NotImplementedException();
        }
    }
}