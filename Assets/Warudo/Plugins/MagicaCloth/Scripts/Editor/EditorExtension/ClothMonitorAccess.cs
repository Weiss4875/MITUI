using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class ClothMonitorAccess
    {
        protected ClothMonitorMenu menu;
        protected ClothMonitorUI UI
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Init(ClothMonitorMenu menu)
        {
            throw new NotImplementedException();
        }

        protected abstract void Create();
        public abstract void Enable();
        public abstract void Disable();
        public abstract void Destroy();
    }
}