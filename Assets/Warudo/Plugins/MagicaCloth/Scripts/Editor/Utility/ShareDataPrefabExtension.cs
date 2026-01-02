using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    internal class ShareDataPrefabExtension
    {
        private enum Mode
        {
            Saving = 1,
            Update = 2,
        }

        static List<GameObject> prefabInstanceList = new List<GameObject>();
        static List<Mode> prefabModeList = new List<Mode>();
        static ShareDataPrefabExtension()
        {
            throw new NotImplementedException();
        }

        static void OnPrefabStageClosing(UnityEditor.SceneManagement.PrefabStage pstage)
        {
            throw new NotImplementedException();
        }

        static void OnPrefabSaving(GameObject instance)
        {
            throw new NotImplementedException();
        }

        static void OnPrefabInstanceUpdate(GameObject instance)
        {
            throw new NotImplementedException();
        }

        static void DelayAnalyze()
        {
            throw new NotImplementedException();
        }

        static void Analyze(GameObject instance, Mode mode)
        {
            throw new NotImplementedException();
        }

        static void SavePrefab(GameObject instance, string prefabPath, string savePrefabPath, bool isVariant, bool forceCopy, Mode mode)
        {
            throw new NotImplementedException();
        }

        public static bool CleanUpSubAssets(GameObject savePrefab, bool log = true)
        {
            throw new NotImplementedException();
        }
    }
}