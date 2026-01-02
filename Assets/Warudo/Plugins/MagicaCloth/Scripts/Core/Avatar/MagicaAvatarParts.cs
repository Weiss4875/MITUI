using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class MagicaAvatarParts : BaseComponent, IDataVerify
    {
        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        public MagicaAvatar ParentAvatar
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

        public bool HasParent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int PartsId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Transform> CheckOverlappingTransform()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Transform> GetBoneDict()
        {
            throw new NotImplementedException();
        }

        public List<CoreComponent> GetMagicaComponentList()
        {
            throw new NotImplementedException();
        }

        public int GetVersion()
        {
            throw new NotImplementedException();
        }

        public void CreateVerifyData()
        {
            throw new NotImplementedException();
        }

        public Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        public string GetInformation()
        {
            throw new NotImplementedException();
        }
    }
}