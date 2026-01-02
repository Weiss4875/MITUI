using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class EditorPresetUtility
    {
        const string configName = "preset folder";
        public static void DrawPresetButton(MonoBehaviour owner, ClothParams clothParam)
        {
            throw new NotImplementedException();
        }

        private class PresetInfo
        {
            public string presetPath;
            public string presetName;
            public TextAsset text;
        }
    }
}