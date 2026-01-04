/*
 * Copyright (c) 2025 CPMEDIA
 * 
 * Licensed under the Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International (CC BY-NC-ND 4.0).
 * 
 * You may share this code as long as it remains unmodified.
 * You may NOT use this code for commercial purposes.
 * You may NOT modify and redistribute it.
 * 
 * Full license details: https://creativecommons.org/licenses/by-nc-nd/4.0/
*/


using UnityEditor;
using UnityEngine;
using System.IO;

public class PatchWindowBase : EditorWindow
{
    protected string basePatchPath => GetCurrentScriptFolderName();
    protected static readonly Vector2 WindowSize = new Vector2(600, 480);

    protected void SetWindowSize()
    {
        minSize = WindowSize;
        maxSize = WindowSize;
    }

    protected string GetResourcePath(string fileName)
    {
        return $"{basePatchPath}/{fileName}";
    }

    protected void DrawThumbnail()
    {
        Texture2D logo = (Texture2D)Resources.Load(GetResourcePath("Thumb"));

        if (logo != null)
        {
            float imageWidth = 400f;
            float imageHeight = 146f;

            Rect rect = GUILayoutUtility.GetRect(imageWidth, imageHeight, GUILayout.ExpandWidth(false));

            rect.x = (position.width - imageWidth) * 0.5f;
            rect.width = imageWidth;
            rect.height = imageHeight;

            GUI.DrawTexture(rect, logo, ScaleMode.StretchToFill);
        }
        else
        {
            EditorGUILayout.HelpBox($"Image not found! Please place it in 'Assets/Resources/{GetResourcePath("Thumb")}'", MessageType.Warning);
        }
    }

    private string GetCurrentScriptFolderName()
    {
        MonoScript script = MonoScript.FromScriptableObject(this);
        string scriptPath = AssetDatabase.GetAssetPath(script);
        if (!string.IsNullOrEmpty(scriptPath))
        {
            string folderPath = Path.GetDirectoryName(scriptPath);
            return Path.GetFileName(folderPath);
        }
        return "UnknownFolder";
    }
}
