using System;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class MagicaAvatarAccess : IDisposable
    {
        protected MagicaAvatar owner;
        protected MagicaAvatarRuntime Runtime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void SetParent(MagicaAvatar avatar)
        {
            throw new NotImplementedException();
        }

        public abstract void Create();
        public abstract void Dispose();
        public abstract void Active();
        public abstract void Inactive();
    }
}