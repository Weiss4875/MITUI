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



using UnityEngine;
using UnityEditor;
using System.Linq;
using UnityEditor.Animations;
using VRC.SDK3.Avatars.Components;
using VRC.SDK3.Avatars.ScriptableObjects;
using System.Collections.Generic;

[CustomEditor(typeof(ftSet))]
public class ftSetEditor : Editor
{
    SerializedProperty layersToDelete;
    SerializedProperty lipSyncStyle;
    SerializedProperty visemeMeshObjectName;
    SerializedProperty visemeBlendShapes;
    SerializedProperty selectedExpressionParameters;
    SerializedProperty physBonePaths;

    private string[] blendShapeOptions = new string[0];
    private readonly string[] visemeLabels = { "sil", "PP", "FF", "TH", "DD", "kk", "CH", "SS", "nn", "RR", "aa", "E", "ih", "oh", "ou" };
    private bool showLipSyncSettings = false;// 킬까말까
    private bool showFXLayerSelection = false;// 킬까말까
    private string[] fxLayerNames = new string[0];
    private Vector2 scrollPosition;
    private bool showBlendShapeSelection = false;
    private int selectedVisemeIndex = -1;
    private bool showParameterSelection = false;// 킬까말까
    private bool showPhysBonesAnimated = false;// 킬까말까
    private string resourceFolderName;

    private void OnEnable()
    {
        resourceFolderName = GetCurrentScriptFolderName(); // 단 한 번만 저장

        // LipMeshObjectName.txt 파일에서 visemeMeshObjectName 값 읽어오기
        string path = $"Assets/{resourceFolderName}/LipMeshObjectName.txt";
        if (System.IO.File.Exists(path))
        {
            string fileContent = System.IO.File.ReadAllText(path);
            if (!string.IsNullOrEmpty(fileContent))
            {
                visemeMeshObjectName = serializedObject.FindProperty("visemeMeshObjectName");
                visemeMeshObjectName.stringValue = fileContent.Split(',')[0].Trim(); // 반점 전의 내용 사용
            }
        }
        serializedObject.ApplyModifiedPropertiesWithoutUndo();


        Texture2D icon = (Texture2D)Resources.Load($"{resourceFolderName}/Fabi");
        if (icon != null)
        {
            EditorGUIUtility.SetIconForObject(target, icon);
        }
        
        layersToDelete = serializedObject.FindProperty("layersToDelete");
        lipSyncStyle = serializedObject.FindProperty("lipSyncStyle");
        visemeBlendShapes = serializedObject.FindProperty("visemeBlendShapes");
        selectedExpressionParameters = serializedObject.FindProperty("selectedExpressionParameters");
        physBonePaths = serializedObject.FindProperty("physBonePaths");

        LoadFXLayers();
        LoadBlendShapes();
    }

    private string GetCurrentScriptFolderName()
    {
        MonoScript script = MonoScript.FromScriptableObject(this);
        string scriptPath = AssetDatabase.GetAssetPath(script);
        if (!string.IsNullOrEmpty(scriptPath))
        {
            string folderPath = System.IO.Path.GetDirectoryName(scriptPath);
            return System.IO.Path.GetFileName(folderPath);
        }
        return "UnknownFolder";
    }

    private void LoadFXLayers()
    {
        GameObject avatarRoot = ((ftSet)target).transform.root.gameObject;
        if (avatarRoot == null) return;

        VRCAvatarDescriptor avatarDescriptor = avatarRoot.GetComponent<VRCAvatarDescriptor>();
        if (avatarDescriptor == null) return;

        var fxLayer = avatarDescriptor.baseAnimationLayers.FirstOrDefault(l => l.type == VRCAvatarDescriptor.AnimLayerType.FX);
        if (fxLayer.animatorController is AnimatorController fxController)
        {
            fxLayerNames = fxController.layers.Select(layer => layer.name).ToArray();
        }
    }

    private void LoadBlendShapes()
    {
        GameObject avatarRoot = ((ftSet)target).transform.root.gameObject;
        if (avatarRoot == null) return;

        SkinnedMeshRenderer smr = avatarRoot.transform.Find(visemeMeshObjectName.stringValue)?.GetComponent<SkinnedMeshRenderer>();
        if (smr != null && smr.sharedMesh != null)
        {
            blendShapeOptions = new string[smr.sharedMesh.blendShapeCount];
            for (int i = 0; i < smr.sharedMesh.blendShapeCount; i++)
            {
                blendShapeOptions[i] = smr.sharedMesh.GetBlendShapeName(i);
            }
        }
    }

    public override void OnInspectorGUI()
    {
        GUILayout.Space(10);
        Texture2D thumb = (Texture2D)Resources.Load($"{resourceFolderName}/Thumb");
        if (thumb != null)
        {
            float inspectorWidth = EditorGUIUtility.currentViewWidth;
            float imageWidth = 400f;
            float imageHeight = 146f;
            float offsetX = (inspectorWidth - imageWidth) * 0.5f;

            Rect rect = GUILayoutUtility.GetRect(imageWidth, imageHeight);
            rect.x = offsetX;
            rect.width = imageWidth;
            rect.height = imageHeight;
            GUI.DrawTexture(rect, thumb, ScaleMode.StretchToFill);
        }
        else
        {
            EditorGUILayout.HelpBox("Image not found! Please place it in 'Assets/Editor/Resources/'", MessageType.Warning);
        }
        serializedObject.Update();

        // ------------------- Lip Sync Settings ---------------------
        showLipSyncSettings = EditorGUILayout.Foldout(showLipSyncSettings, "Lip Sync Settings", true);
        if (showLipSyncSettings)
        {
            EditorGUILayout.PropertyField(lipSyncStyle);
            EditorGUILayout.LabelField("Viseme Mesh Object", visemeMeshObjectName.stringValue);

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.BeginVertical(GUILayout.Width(250));

            if (lipSyncStyle.enumValueIndex == 3) // VisemeBlendShape
            {
                for (int i = 0; i < 15; i++)
                {
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField($"{visemeLabels[i]}:", GUILayout.Width(60));
                    if (GUILayout.Button(visemeBlendShapes.GetArrayElementAtIndex(i).stringValue, GUILayout.Width(180)))
                    {
                        selectedVisemeIndex = i;
                        LoadBlendShapes(); // 🟢 Blend Shape 목록을 최신화
                        showBlendShapeSelection = true;
                    }
                    EditorGUILayout.EndHorizontal();
                }
            }
            EditorGUILayout.EndVertical();

            if (showBlendShapeSelection && selectedVisemeIndex >= 0)
            {
                EditorGUILayout.BeginVertical("box", GUILayout.Width(250));
                EditorGUILayout.LabelField($"Select Blend Shape for {visemeLabels[selectedVisemeIndex]}", EditorStyles.boldLabel);
                scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(250));
                for (int i = 0; i < blendShapeOptions.Length; i++)
                {
                    if (GUILayout.Button(blendShapeOptions[i], GUILayout.ExpandWidth(true)))
                    {
                        visemeBlendShapes.GetArrayElementAtIndex(selectedVisemeIndex).stringValue = blendShapeOptions[i];
                        showBlendShapeSelection = false;
                    }
                }
                EditorGUILayout.EndScrollView();
                if (GUILayout.Button("Close")) showBlendShapeSelection = false;
                EditorGUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
        }

        // ------------------- FX Layers To Delete -------------------
        showFXLayerSelection = EditorGUILayout.Foldout(showFXLayerSelection, "FX Layers To Delete", true);
        if (showFXLayerSelection)
        {
            for (int i = 0; i < layersToDelete.arraySize; i++)
            {
                EditorGUILayout.BeginHorizontal();

                // 현재 FX Layer 선택 (팝업)
                layersToDelete.GetArrayElementAtIndex(i).stringValue = fxLayerNames.Length > 0 ?
                    fxLayerNames[EditorGUILayout.Popup("Layer Name", Mathf.Max(0, System.Array.IndexOf(fxLayerNames, layersToDelete.GetArrayElementAtIndex(i).stringValue)), fxLayerNames)] : "";

                // "-" 버튼 (삭제)
                if (GUILayout.Button("-", GUILayout.Width(30)))
                {
                    layersToDelete.DeleteArrayElementAtIndex(i);
                    break; // 리스트 변경 후 즉시 반복 종료
                }

                EditorGUILayout.EndHorizontal();
            }

            // "+" 버튼 (추가)
            if (GUILayout.Button("+"))
            {
                layersToDelete.arraySize++;
                layersToDelete.GetArrayElementAtIndex(layersToDelete.arraySize - 1).stringValue = "";
            }
        }

        // ------------------- Parameter Selection (New Section) -------------------
        GameObject avatarRoot = ((ftSet)target).transform.root.gameObject;
        VRCAvatarDescriptor avatarDescriptor = avatarRoot ? avatarRoot.GetComponent<VRCAvatarDescriptor>() : null;

        // 아바타가 있고, ExpressionParameters가 있는지 확인
        if (avatarDescriptor && avatarDescriptor.expressionParameters)
        {
            showParameterSelection = EditorGUILayout.Foldout(showParameterSelection, "Parameters To Desync", true);
            if (showParameterSelection)
            {
                // 아바타에 실제로 등록된 파라미터 이름들을 가져옵니다.
                var paramNames = avatarDescriptor.expressionParameters.parameters
                    .Where(p => p != null)
                    .Select(p => p.name)
                    .ToArray();

                // selectedExpressionParameters 리스트를 표시
                for (int i = 0; i < selectedExpressionParameters.arraySize; i++)
                {
                    var element = selectedExpressionParameters.GetArrayElementAtIndex(i);

                    EditorGUILayout.BeginHorizontal();

                    // 현재 값에 대응되는 index 찾기
                    int currentIndex = System.Array.IndexOf(paramNames, element.stringValue);
                    int newIndex = EditorGUILayout.Popup("Parameter", currentIndex, paramNames);
                    if (newIndex >= 0)
                    {
                        element.stringValue = paramNames[newIndex];
                    }

                    // - 버튼으로 삭제
                    if (GUILayout.Button("-", GUILayout.Width(30)))
                    {
                        selectedExpressionParameters.DeleteArrayElementAtIndex(i);
                        break; // 리스트 변경 후 break 처리
                    }

                    EditorGUILayout.EndHorizontal();
                }

                // + 버튼
                if (GUILayout.Button("+"))
                {
                    int newIdx = selectedExpressionParameters.arraySize;
                    selectedExpressionParameters.arraySize++;
                    // 기본값
                    selectedExpressionParameters.GetArrayElementAtIndex(newIdx).stringValue = "";
                }
            }
        }
        else
        {
            EditorGUILayout.HelpBox("No valid ExpressionParameters on this Avatar.", MessageType.Info);
        }


        // ------------------- PhysBone 활성화 경로 추가 UI -------------------
        showPhysBonesAnimated = EditorGUILayout.Foldout(showPhysBonesAnimated, "PhysBones To Animated", true);
        if (showPhysBonesAnimated)
        {
            EditorGUILayout.LabelField("PhysBone 활성화 경로", EditorStyles.boldLabel);

            // 저장된 경로 목록을 표시하고 수정할 수 있도록 함
            for (int i = 0; i < physBonePaths.arraySize; i++)
            {
                EditorGUILayout.BeginHorizontal();

                SerializedProperty element = physBonePaths.GetArrayElementAtIndex(i);
                element.stringValue = EditorGUILayout.TextField($"경로 {i + 1}:", element.stringValue);

                // "-" 버
                if (GUILayout.Button("-", GUILayout.Width(30)))
                {
                    physBonePaths.DeleteArrayElementAtIndex(i);
                    break;
                }

                EditorGUILayout.EndHorizontal();
            }

            // "+" 버
            if (GUILayout.Button("+"))
            {
                physBonePaths.arraySize++;
                physBonePaths.GetArrayElementAtIndex(physBonePaths.arraySize - 1).stringValue = "";
            }
        }

        EditorGUILayout.Space();


        serializedObject.ApplyModifiedProperties();
    }
}
