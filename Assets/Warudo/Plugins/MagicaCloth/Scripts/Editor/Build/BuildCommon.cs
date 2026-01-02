using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static partial class BuildManager
    {
        static T CreateShareData<T>(string dataName, string savePrefabPath)
            where T : ShareDataObject
        {
            throw new NotImplementedException();
        }

        static bool SaveShareDataSubAsset(ShareDataObject sdata, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static bool IsExternalShareDataObject(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        static bool IsNotCreated(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        static bool IsOldFormat(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        static bool IsOldAlgorithm(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        static void GetBuildComponents(GameObject gobj, BuildOptions options, List<CoreComponent> coreComponents)
        {
            throw new NotImplementedException();
        }

        static void SortCoreComponents(List<CoreComponent> coreComponents)
        {
            throw new NotImplementedException();
        }

        static string GetAssetSavePath(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        static bool CheckMissingScripts(GameObject go)
        {
            throw new NotImplementedException();
        }
    }
}