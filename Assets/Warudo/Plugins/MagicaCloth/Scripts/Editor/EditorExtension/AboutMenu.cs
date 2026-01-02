using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class AboutMenu : EditorWindow
    {
        public const string MagicaClothVersion = "1.12.11";
        public static AboutMenu AboutWindow { get; set; }

        static void InitWindow()
        {
            throw new NotImplementedException();
        }
    }
}