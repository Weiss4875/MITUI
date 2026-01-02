using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class DressUpControl : MonoBehaviour
    {
        public class AvatarPartsGroup
        {
            public string groupName;
            public List<GameObject> partsPrefabList = new List<GameObject>();
            public int id;
            public int handle;
            public int index;
        }

        public List<AvatarPartsGroup> avatarPartsGroupList = new List<AvatarPartsGroup>();
        void Start()
        {
            throw new NotImplementedException();
        }

        void Update()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}