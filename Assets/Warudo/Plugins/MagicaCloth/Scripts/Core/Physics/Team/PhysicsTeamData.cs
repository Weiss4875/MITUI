using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PhysicsTeamData : IDataHash
    {
        public int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public void Init(int teamId)
        {
            throw new NotImplementedException();
        }

        public void Dispose(int teamId)
        {
            throw new NotImplementedException();
        }

        public void AddCollider(ColliderComponent collider)
        {
            throw new NotImplementedException();
        }

        public void RemoveCollider(ColliderComponent collider)
        {
            throw new NotImplementedException();
        }

        internal void UpdateStatus()
        {
            throw new NotImplementedException();
        }

        public int ColliderCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<ColliderComponent> ColliderList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<ColliderComponent> PenetrationIgnoreColliderList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool MergeAvatarCollider
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ValidateColliderList()
        {
            throw new NotImplementedException();
        }
    }
}