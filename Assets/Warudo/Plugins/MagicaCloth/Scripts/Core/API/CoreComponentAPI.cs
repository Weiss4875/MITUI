using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public abstract partial class CoreComponent : BaseComponent, IShareDataObject, IDataVerify, IEditorMesh, IEditorCloth, IDataHash, IBoneReplace
    {
        public Dictionary<string, Transform> GetUsedComponentBones()
        {
            throw new NotImplementedException();
        }

        public List<string> GetUsedComponentBoneNames()
        {
            throw new NotImplementedException();
        }

        public void ReplaceComponentBone(Dictionary<Transform, Transform> boneReplaceDict)
        {
            throw new NotImplementedException();
        }

        public void ReplaceComponentBone(Dictionary<string, Transform> boneReplaceDict)
        {
            throw new NotImplementedException();
        }
    }
}