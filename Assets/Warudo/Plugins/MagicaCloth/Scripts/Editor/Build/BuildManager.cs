using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static partial class BuildManager
    {
        public static Define.Error UpgradeComponent(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        public static Define.Error CreateComponent(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        public static BuildResult BuildFromComponents(List<CoreComponent> coreComponents, BuildOptions options)
        {
            throw new NotImplementedException();
        }

        public static BuildResult BuildFromSceneObject(GameObject gobj, BuildOptions options)
        {
            throw new NotImplementedException();
        }

        public static BuildResult BuildFromAssetPath(string path, BuildOptions options)
        {
            throw new NotImplementedException();
        }

        public static BuildResult BuildFromScenePath(string path, BuildOptions options)
        {
            throw new NotImplementedException();
        }
    }
}