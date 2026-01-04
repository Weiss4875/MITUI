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
using System.Linq;
using System;

public class PrefabLoaderWindow : PatchWindowBase
{
    private GameObject avatarRoot;
    private string PATH_PREFAB => Path.Combine(basePatchPath, "_prefab");
    private string PATH_README => Path.Combine("Assets", basePatchPath, "_prefab", "Readme.txt");
    private string processOutput = "";
    private string readmeContent = "";
    private string[] prefabFolders;
    private int selectedPrefabIndex = 0;
    private string customLabelText = "STEP2: Prefab Loader"; // 타이틀 텍스트

    [MenuItem("FT Patch/STEP2: Prefab Loader")]
    public static void ShowWindow()
    {
        PrefabLoaderWindow window = GetWindow<PrefabLoaderWindow>("STEP2: Prefab Loader");
        window.SetWindowSize();
    }

    private void OnEnable()
    {
        LoadPrefabFolders();
        LoadReadme();
    }

    private void OnGUI()
    {
        GUILayout.Space(10);
        DrawThumbnail();

        // 큰 타이틀 라벨 스타일
        GUIStyle largeLabelStyle = new GUIStyle(EditorStyles.label);
        largeLabelStyle.fontSize = 18;
        largeLabelStyle.fontStyle = FontStyle.Bold;
        largeLabelStyle.alignment = TextAnchor.MiddleCenter;

        GUILayout.Space(5);
        EditorGUILayout.LabelField(customLabelText, largeLabelStyle); // 중앙 정렬된 타이틀 표시

        GUILayout.Space(10);

        // Readme 내용을 Label로 출력
        if (!string.IsNullOrEmpty(readmeContent))
        {
            EditorGUILayout.LabelField(readmeContent, EditorStyles.wordWrappedLabel);
        }

        GUILayout.Space(10);
        avatarRoot = (GameObject)EditorGUILayout.ObjectField("Avatar Root", avatarRoot, typeof(GameObject), true);

        if (prefabFolders.Length > 0)
        {
            selectedPrefabIndex = EditorGUILayout.Popup("Select Prefab", selectedPrefabIndex, prefabFolders);
        }
        else
        {
            GUILayout.Label("No prefab folders found.", EditorStyles.helpBox);
        }

        GUILayout.Space(10);

        // 버튼 스타일 설정 (큰 글자, 굵게, 높이 조정)
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 16;
        buttonStyle.fontStyle = FontStyle.Bold;
        buttonStyle.alignment = TextAnchor.MiddleCenter;

        if (GUILayout.Button("Load Prefab", buttonStyle, GUILayout.Height(40)))
        {
            processOutput = ""; // 출력 초기화
            LoadPrefab();
        }

        GUILayout.Space(10);

        // 출력 메시지 스타일 설정
        GUIStyle outputStyle = new GUIStyle(EditorStyles.label);
        outputStyle.fontSize = 14;
        outputStyle.wordWrap = true;
        outputStyle.alignment = TextAnchor.MiddleLeft;

        // 성공/실패 메시지 색상 적용
        if (processOutput.Contains("success", StringComparison.OrdinalIgnoreCase))
        {
            outputStyle.normal.textColor = Color.green;  // 성공 메시지는 초록색
        }
        else if (processOutput.Contains("failed", StringComparison.OrdinalIgnoreCase) || 
                 processOutput.Contains("error", StringComparison.OrdinalIgnoreCase))
        {
            outputStyle.normal.textColor = Color.red;  // 오류 메시지는 빨간색
        }
        else
        {
            outputStyle.normal.textColor = Color.gray; // 일반 메시지는 회색
        }

        // 가변적인 출력 메시지 표시 (TextArea 대신 Label 사용)
        EditorGUILayout.LabelField(processOutput, outputStyle);
    }

    private void LoadPrefabFolders()
    {
        string prefabRoot = Path.Combine(Application.dataPath, PATH_PREFAB);
        prefabFolders = Directory.Exists(prefabRoot) ? Directory.GetDirectories(prefabRoot).Select(Path.GetFileName).OrderBy(name => name).ToArray() : new string[0];
    }

    private void LoadReadme()
    {
        if (File.Exists(PATH_README))
        {
            readmeContent = File.ReadAllText(PATH_README);
        }
        else
        {
            readmeContent = "Readme file not found.";
        }
    }

    private void LoadPrefab()
    {
        // 🔹 아바타 루트가 설정되지 않은 경우 오류 메시지 출력 후 종료
        if (avatarRoot == null)
        {
            processOutput = "Error: Avatar Root is not assigned!";
            return;
        }

        string selectedFolderPath = Path.Combine(Application.dataPath, PATH_PREFAB, prefabFolders[selectedPrefabIndex]);
        string prefabFilePath = Directory.GetFiles(selectedFolderPath, "*.prefab").FirstOrDefault();

        if (!string.IsNullOrEmpty(prefabFilePath))
        {
            string assetPath = "Assets" + prefabFilePath.Substring(Application.dataPath.Length);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            if (prefab != null)
            {
                // ✅ 아바타 루트 아래에 프리팹을 추가
                GameObject instantiatedPrefab = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                instantiatedPrefab.transform.SetParent(avatarRoot.transform, false);
                
                processOutput = "Prefab instantiated successfully.";
            }
            else
            {
                processOutput = "Failed to load prefab.";
            }
        }
        else
        {
            processOutput = "No valid prefab found in the selected folder.";
        }
    }

    public static void ShowWindow(GameObject avatarRoot)
    {
        PrefabLoaderWindow window = GetWindow<PrefabLoaderWindow>("STEP2: Prefab Loader");
        window.avatarRoot = avatarRoot; // ✅ avatarRoot 값 전달
        window.SetWindowSize();
        window.Focus();
    }
}
