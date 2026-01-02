using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class UpdateTimeManager
    {
        public enum UpdateCount
        {
            _60 = 60,
            _90_Default = 90,
            _120 = 120,
            _150 = 150,
            _180 = 180,
        }

        public enum UpdateMode
        {
            UnscaledTime = 0,
            OncePerFrame = 1,
            DelayUnscaledTime = 10,
        }

        public enum UpdateLocation
        {
            AfterLateUpdate = 0,
            BeforeLateUpdate = 1,
        }

        public void ResetFixedUpdateCount()
        {
            throw new NotImplementedException();
        }

        public void AddFixedUpdateCount()
        {
            throw new NotImplementedException();
        }

        public int FixedUpdateCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public UpdateMode GetUpdateMode()
        {
            throw new NotImplementedException();
        }

        public void SetUpdateMode(UpdateMode mode)
        {
            throw new NotImplementedException();
        }

        public UpdateLocation GetUpdateLocation()
        {
            throw new NotImplementedException();
        }

        public void SetUpdateLocation(UpdateLocation location)
        {
            throw new NotImplementedException();
        }

        public int UpdatePerSecond
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetUpdatePerSecond(UpdateCount ucount)
        {
            throw new NotImplementedException();
        }

        public float UpdateIntervalTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float UpdatePower
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float TimeScale
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

        public float DeltaTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float PhysicsDeltaTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float AverageDeltaTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsUnscaledUpdate
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDelay
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float FuturePredictionRate
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

        public bool UpdateBoneScale
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

        public int WorkerMaximumCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}