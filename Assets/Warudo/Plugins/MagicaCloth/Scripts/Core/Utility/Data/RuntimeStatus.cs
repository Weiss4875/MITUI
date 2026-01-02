using System.Collections.Generic;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class RuntimeStatus
    {
        bool initStart;
        bool init;
        bool initError;
        bool enable;
        bool userEnable = true;
        bool runtimeError;
        bool dispose;
        bool isActive;
        bool isDirty;
        internal HashSet<RuntimeStatus> parentStatusSet { get; private set; }

        internal HashSet<RuntimeStatus> childStatusSet { get; private set; }

        internal System.Action UpdateStatusAction;
        internal System.Action DisconnectedAction;
        internal System.Func<System.Object> OwnerFunc;
        public bool IsActive
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsInitStart
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsInitComplete
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsInitSuccess
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsInitError
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDispose
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDirty => throw new NotImplementedException();
        public void SetInitStart()
        {
            throw new NotImplementedException();
        }

        public void SetInitComplete()
        {
            throw new NotImplementedException();
        }

        public void SetInitError()
        {
            throw new NotImplementedException();
        }

        public bool SetEnable(bool sw)
        {
            throw new NotImplementedException();
        }

        public bool SetUserEnable(bool sw)
        {
            throw new NotImplementedException();
        }

        public bool SetRuntimeError(bool sw)
        {
            throw new NotImplementedException();
        }

        public void SetDispose()
        {
            throw new NotImplementedException();
        }

        public void SetDirty()
        {
            throw new NotImplementedException();
        }

        public void ClearDirty()
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus()
        {
            throw new NotImplementedException();
        }

        public void AddParentStatus(RuntimeStatus status)
        {
            throw new NotImplementedException();
        }

        public void RemoveParentStatus(RuntimeStatus status)
        {
            throw new NotImplementedException();
        }

        public void AddChildStatus(RuntimeStatus status)
        {
            throw new NotImplementedException();
        }

        public void RemoveChildStatus(RuntimeStatus status)
        {
            throw new NotImplementedException();
        }

        public void LinkParentStatus(RuntimeStatus parent)
        {
            throw new NotImplementedException();
        }

        public void UnlinkParentStatus(RuntimeStatus parent)
        {
            throw new NotImplementedException();
        }

        bool IsParentStatusActive()
        {
            throw new NotImplementedException();
        }
    }
}