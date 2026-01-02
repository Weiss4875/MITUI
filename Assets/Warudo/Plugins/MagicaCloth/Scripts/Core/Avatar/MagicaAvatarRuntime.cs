using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaAvatarRuntime : MagicaAvatarAccess
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Active()
        {
            throw new NotImplementedException();
        }

        public override void Inactive()
        {
            throw new NotImplementedException();
        }

        public int AvatarPartsCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public MagicaAvatarParts GetAvatarParts(int index)
        {
            throw new NotImplementedException();
        }

        public int GetColliderCount()
        {
            throw new NotImplementedException();
        }

        public List<Transform> CheckOverlappingTransform()
        {
            throw new NotImplementedException();
        }

        public int AddAvatarParts(MagicaAvatarParts parts)
        {
            throw new NotImplementedException();
        }

        public void RemoveAvatarParts(MagicaAvatarParts parts)
        {
            throw new NotImplementedException();
        }

        public void RemoveAvatarParts(int partsId)
        {
            throw new NotImplementedException();
        }
    }
}