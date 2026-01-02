using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class WindComponent : BaseComponent
    {
        protected float main = 5.0f;
        protected float turbulence = 1.0f;
        protected float frequency = 1.0f;
        protected Vector3 areaSize = new Vector3(5.0f, 5.0f, 5.0f);
        protected float areaRadius = 5.0f;
        protected float directionAngleX = 0;
        protected float directionAngleY = 0;
        protected PhysicsManagerWindData.DirectionType directionType;
        protected BezierParam attenuation = new BezierParam(1f, 1f, false, 0.0f, false);
        protected int windId = -1;
        protected RuntimeStatus status = new RuntimeStatus();
        internal RuntimeStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected virtual void Reset()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnValidate()
        {
            throw new NotImplementedException();
        }

        void OnDidApplyAnimationProperties()
        {
            throw new NotImplementedException();
        }

        protected virtual void Start()
        {
            throw new NotImplementedException();
        }

        internal virtual void OnEnable()
        {
            throw new NotImplementedException();
        }

        internal virtual void OnDisable()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDestroy()
        {
            throw new NotImplementedException();
        }

        protected virtual void Update()
        {
            throw new NotImplementedException();
        }

        void Init()
        {
            throw new NotImplementedException();
        }

        protected void OnUpdateStatus()
        {
            throw new NotImplementedException();
        }

        internal virtual bool VerifyData()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnInit()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnDispose()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnUpdate()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnActive()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnInactive()
        {
            throw new NotImplementedException();
        }

        protected void EnableWind()
        {
            throw new NotImplementedException();
        }

        protected void DisableWind()
        {
            throw new NotImplementedException();
        }

        internal Vector3 GetLocalDirection()
        {
            throw new NotImplementedException();
        }

        public abstract PhysicsManagerWindData.WindType GetWindType();
        public abstract PhysicsManagerWindData.ShapeType GetShapeType();
        public abstract PhysicsManagerWindData.DirectionType GetDirectionType();
        public abstract bool IsAddition();
        public abstract Vector3 GetAreaSize();
        public abstract float GetAreaVolume();
        public abstract float GetAreaLength();
        protected abstract void ResetParams();
    }
}