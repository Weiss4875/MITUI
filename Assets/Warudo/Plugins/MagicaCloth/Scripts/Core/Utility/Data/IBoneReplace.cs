using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public interface IBoneReplace
    {
        HashSet<Transform> GetUsedBones();
        void ReplaceBone<T>(Dictionary<T, Transform> boneReplaceDict)
            where T : class;
    }
}