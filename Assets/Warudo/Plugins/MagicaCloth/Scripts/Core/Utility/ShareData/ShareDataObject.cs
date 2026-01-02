using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract class ShareDataObject : ScriptableObject, IDataVerify, IDataHash
    {
        protected int dataHash;
        protected int dataVersion;
        public abstract int GetDataHash();
        public int SaveDataHash
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

        public int SaveDataVersion
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

        public abstract int GetVersion();
        public abstract Define.Error VerifyData();
        public virtual void CreateVerifyData()
        {
            throw new NotImplementedException();
        }

        public virtual string GetInformation()
        {
            throw new NotImplementedException();
        }

        public static T CreateShareData<T>(string dataName)
            where T : ShareDataObject
        {
            throw new NotImplementedException();
        }

        public static bool RemoveNullAndDuplication<T>(List<T> data)
        {
            throw new NotImplementedException();
        }

        public static T Clone<T>(T source)
            where T : ShareDataObject
        {
            throw new NotImplementedException();
        }
    }
}