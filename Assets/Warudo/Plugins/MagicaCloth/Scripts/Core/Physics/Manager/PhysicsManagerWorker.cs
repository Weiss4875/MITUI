using Unity.Jobs;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class PhysicsManagerWorker
    {
        public MagicaPhysicsManager Manager { get; set; }

        protected virtual void Start()
        {
            throw new NotImplementedException();
        }

        public void Init(MagicaPhysicsManager manager)
        {
            throw new NotImplementedException();
        }

        public abstract void Create();
        public abstract void RemoveGroup(int group);
        public abstract void Release();
        public abstract void Warmup();
        public abstract JobHandle PreUpdate(JobHandle jobHandle);
        public abstract JobHandle PostUpdate(JobHandle jobHandle);
    }
}