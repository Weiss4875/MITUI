using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerWindData : PhysicsManagerAccess
    {
        public enum WindType
        {
            None = 0,
            Direction,
            Area,
        }

        public enum ShapeType
        {
            Box = 0,
            Sphere = 1,
        }

        public enum DirectionType
        {
            OneDirection = 0,
            Radial = 1,
        }

        public const uint Flag_Enable = 0x00000001;
        public const uint Flag_Addition = 0x00000002;
        public struct WindData
        {
            public uint flag;
            public WindType windType;
            public ShapeType shapeType;
            public int transformIndex;
            public float3 areaSize;
            public float main;
            public float turbulence;
            public float frequency;
            public float3 direction;
            public DirectionType directionType;
            public float areaVolume;
            public float areaLength;
            public CurveParam attenuation;
            public bool IsFlag(uint flag)
            {
                throw new NotImplementedException();
            }

            public void SetFlag(uint flag, bool sw)
            {
                throw new NotImplementedException();
            }

            public void SetEnable(bool sw)
            {
                throw new NotImplementedException();
            }

            public bool IsActive()
            {
                throw new NotImplementedException();
            }
        }

        public FixedNativeList<WindData> windDataList;
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public int CreateWind(WindType windType, ShapeType shapeType, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, DirectionType directinType, float areaVolume, float areaLength, BezierParam attenuation)
        {
            throw new NotImplementedException();
        }

        public void RemoveWind(int windId)
        {
            throw new NotImplementedException();
        }

        public void SetEnable(int windId, bool sw, Transform target)
        {
            throw new NotImplementedException();
        }

        public bool IsActive(int windId)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int windId, uint flag, bool sw)
        {
            throw new NotImplementedException();
        }

        public void SetParameter(int windId, float3 areaSize, bool addition, float main, float turbulence, float frequency, float3 direction, float areaVolume, float areaLength, BezierParam attenuation)
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

        internal static float3 CalcWindForce(float time, float2 noiseBasePos, float3 mainDir, float main, float turbulence, float frequency, float randomScale)
        {
            throw new NotImplementedException();
        }
    }
}