using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsManagerComponent : PhysicsManagerAccess
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public int ComponentCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<CoreComponent> GetComponentList()
        {
            throw new NotImplementedException();
        }

        public void ComponentAction(System.Action<CoreComponent> act)
        {
            throw new NotImplementedException();
        }

        public void UpdateComponentStatus()
        {
            throw new NotImplementedException();
        }

        public void AddComponent(CoreComponent comp)
        {
            throw new NotImplementedException();
        }

        public void RemoveComponent(CoreComponent comp)
        {
            throw new NotImplementedException();
        }

        internal void ReserveDataUpdateParticleComponent(ParticleComponent comp)
        {
            throw new NotImplementedException();
        }

        internal void DataUpdateParticleComponent()
        {
            throw new NotImplementedException();
        }
    }
}