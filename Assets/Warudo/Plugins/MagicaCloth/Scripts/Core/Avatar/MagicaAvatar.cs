using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public partial class MagicaAvatar : CoreComponent
    {
        MagicaAvatarRuntime runtime = new MagicaAvatarRuntime();
        public AvatarPartsAttachEvent OnAttachParts = new AvatarPartsAttachEvent();
        public AvatarPartsDetachEvent OnDetachParts = new AvatarPartsDetachEvent();
        public override ComponentType GetComponentType()
        {
            throw new NotImplementedException();
        }

        public override int GetDataHash()
        {
            throw new NotImplementedException();
        }

        public bool DataReset
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

        public MagicaAvatarRuntime Runtime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        void Reset()
        {
            throw new NotImplementedException();
        }

        void OnValidate()
        {
            throw new NotImplementedException();
        }

        protected override void OnInit()
        {
            throw new NotImplementedException();
        }

        protected override void OnDispose()
        {
            throw new NotImplementedException();
        }

        protected override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        protected override void OnActive()
        {
            throw new NotImplementedException();
        }

        protected override void OnInactive()
        {
            throw new NotImplementedException();
        }

        public override int GetVersion()
        {
            throw new NotImplementedException();
        }

        public override int GetErrorVersion()
        {
            throw new NotImplementedException();
        }

        public override void CreateVerifyData()
        {
            throw new NotImplementedException();
        }

        public override Define.Error VerifyData()
        {
            throw new NotImplementedException();
        }

        public override string GetInformation()
        {
            throw new NotImplementedException();
        }

        public override List<ShareDataObject> GetAllShareDataObject()
        {
            throw new NotImplementedException();
        }

        public override ShareDataObject DuplicateShareDataObject(ShareDataObject source)
        {
            throw new NotImplementedException();
        }
    }
}