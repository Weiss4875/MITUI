using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public partial class MagicaAvatar : CoreComponent
    {
        public int AttachAvatarParts(GameObject avatarPartsPrefab, System.Action<GameObject> instanceAction = null)
        {
            throw new NotImplementedException();
        }

        public void DetachAvatarParts(int partsId)
        {
            throw new NotImplementedException();
        }

        public void DetachAvatarParts(GameObject avatarPartsObject)
        {
            throw new NotImplementedException();
        }

        public void DetachAvatarParts(MagicaAvatarParts parts)
        {
            throw new NotImplementedException();
        }
    }
}