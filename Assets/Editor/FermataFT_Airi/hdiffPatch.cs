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
using Debug = UnityEngine.Debug;
using System.Diagnostics;

public class HdiffPatchWindow : PatchWindowBase
{
    private GameObject avatarRoot;
    private string defaultAvatarRootName = "Avatar";
    private string targetObjectName = "EMPTY!!";
    private string meshPath;
    private string hdiffPath;
    //private string prefabPath;
    private string processOutput = "";
    private string[] hdiffFolders;
    private int selectedHdiffIndex = 0;
    private string readmeContent = "";

    private string PATH_HDIIFF => Path.Combine(basePatchPath, "_hdiff");
    private string PATH_README => Path.Combine(Application.dataPath, basePatchPath, "_hdiff", "Readme.txt");
    private string PATH_LIPMESHNAME => Path.Combine(basePatchPath, "LipMeshObjectName.txt");

    private string customLabelText = "STEP1: Hdiff Patcher, Run It Only Once the 'First Time'"; // 사용자가 입력할 라벨

    [MenuItem("FT Patch/STEP1: Hdiff Patcher")]
    public static void ShowWindow()
    {
        HdiffPatchWindow window = GetWindow<HdiffPatchWindow>("STEP1: Hdiff Patcher");
        window.SetWindowSize();
    }

    private void OnEnable()
    {
        LoadSetFile();
        LoadHdiffFolders();
        SetDefaultAvatarRoot();
        LoadReadmeFile();
    }

    private void OnGUI()
    {
        GUILayout.Space(10);
        DrawThumbnail(); 
        GUIStyle largeLabelStyle = new GUIStyle(EditorStyles.label);
        largeLabelStyle.fontSize = 18; // 폰트 크기 증가
        largeLabelStyle.fontStyle = FontStyle.Bold;
        largeLabelStyle.alignment = TextAnchor.MiddleCenter;

        GUILayout.Space(5);
        EditorGUILayout.LabelField(customLabelText, largeLabelStyle); // 큰 라벨 표시
        GUILayout.Space(10);
        if (!string.IsNullOrEmpty(readmeContent))
        {
            EditorGUILayout.LabelField(readmeContent, EditorStyles.wordWrappedLabel);
        }

        GUILayout.Space(10);
        avatarRoot = (GameObject)EditorGUILayout.ObjectField("Avatar Root", avatarRoot, typeof(GameObject), true);

        if (hdiffFolders.Length > 0)
        {
            selectedHdiffIndex = EditorGUILayout.Popup("Select Patch", selectedHdiffIndex, hdiffFolders);
            string selectedFolderPath = Path.Combine(Application.dataPath, PATH_HDIIFF, hdiffFolders[selectedHdiffIndex]);
            hdiffPath = GetFilePath(selectedFolderPath, ".hdiff");
            //prefabPath = GetFilePath(selectedFolderPath, ".prefab");
        }
        else
        {
            GUILayout.Label("No patch folders found.", EditorStyles.helpBox);
        }

        GUILayout.Space(10);

        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.fontSize = 16; // 버튼 글자 크기
        buttonStyle.fontStyle = FontStyle.Bold; // 굵은 글씨
        buttonStyle.alignment = TextAnchor.MiddleCenter;

        if (GUILayout.Button("Start Facial Tracking Patch, !! Run Only Once !!", buttonStyle, GUILayout.Height(40)))
        {
            StartFacialTrackingPatch();
        }

        GUILayout.Space(10);
        // 출력 메시지 스타일 적용
        GUIStyle outputStyle = new GUIStyle(EditorStyles.label);
        outputStyle.fontSize = 14;
        outputStyle.wordWrap = true;
        outputStyle.alignment = TextAnchor.MiddleLeft;

        // 성공/실패 메시지 색상 적용
        if (processOutput.Contains("Process completed successfully"))
        {
            outputStyle.normal.textColor = Color.green;  // 성공 메시지는 초록색
        }
        else if (processOutput.Contains("Process FAILED") || processOutput.Contains("error"))
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

    private void LoadSetFile()
    {
        string filePath = Path.Combine(Application.dataPath, PATH_LIPMESHNAME);
        if (File.Exists(filePath))
        {
            string line = File.ReadAllText(filePath).Split(',')[0].Trim();
            targetObjectName = line;
        }
    }

    private void LoadHdiffFolders()
    {
        string hdiffRoot = Path.Combine(Application.dataPath, PATH_HDIIFF);
        hdiffFolders = Directory.Exists(hdiffRoot) ? Directory.GetDirectories(hdiffRoot).Select(Path.GetFileName).OrderByDescending(name => name).ToArray() : new string[0];
    }

    private void SetDefaultAvatarRoot()
    {
        GameObject defaultRoot = GameObject.Find(defaultAvatarRootName);
        if (defaultRoot != null)
        {
            avatarRoot = defaultRoot;
        }
    }

    private void LoadReadmeFile()
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

    private string GetFilePath(string folderPath, string extension)
    {
        if (Directory.Exists(folderPath))
        {
            string[] files = Directory.GetFiles(folderPath, "*" + extension);
            return files.Length > 0 ? files[0] : "";
        }
        return "";
    }

    private void StartFacialTrackingPatch()
    {
        if (avatarRoot == null)
        {
            processOutput = "Avatar Root is not assigned.";
            return;
        }

        Transform targetTransform = avatarRoot.transform.Find(targetObjectName);
        if (targetTransform == null)
        {
            processOutput = $"Target object '{targetObjectName}' not found under the avatar root.";
            return;
        }

        SkinnedMeshRenderer skinnedMeshRenderer = targetTransform.GetComponent<SkinnedMeshRenderer>();
        if (skinnedMeshRenderer == null || skinnedMeshRenderer.sharedMesh == null)
        {
            processOutput = "SkinnedMeshRenderer or Mesh not found on the target object.";
            return;
        }

        string assetPath = AssetDatabase.GetAssetPath(skinnedMeshRenderer.sharedMesh);
        if (!string.IsNullOrEmpty(assetPath))
        {
            meshPath = assetPath;
            processOutput = $"Mesh Path: {meshPath}";
        }
        else
        {
            processOutput = "Mesh asset path could not be found.";
            return;
        }

        if (string.IsNullOrEmpty(hdiffPath))
        {
            processOutput = "No valid .hdiff file selected.";
            return;
        }

        string patchToolPath = Path.Combine(Application.dataPath, Path.Combine(basePatchPath, "hpatchz.exe"));
        //BackupFile(meshPath);
        RunBatFile(patchToolPath, meshPath, hdiffPath);
        AssetDatabase.Refresh();
    }

    private void RunBatFile(string filePath, string oldPath, string hdiffPath)
    {
        Process process = new Process();
        string arguments = string.Format("-f \"{0}\" \"{1}\" \"{0}\"", oldPath, hdiffPath);
        process.StartInfo.FileName = filePath;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.UseShellExecute = false;

        long oldSize = GetFileSize(oldPath);
        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        long newSize = GetFileSize(oldPath);

        if (newSize != oldSize)
        {
            processOutput += "\nProcess completed successfully at: " + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            // avatarRoot 값을 유지하면서 STEP2 창 열기
            EditorApplication.delayCall += () => {
                PrefabLoaderWindow.ShowWindow(avatarRoot);
                EditorWindow.GetWindow<PrefabLoaderWindow>().Focus(); // 창 포커스
            };
        }
        else
        {
            processOutput += "\nProcess FAILED at: " + DateTime.Now.ToString("yyyyMMdd_HHmmss") + "\nPlease check your Avatar version\n";
        }

        EditorApplication.delayCall += () => { EditorWindow.GetWindow(typeof(EditorWindow)).Repaint(); };
    }

    private long GetFileSize(string path)
    {
        return File.Exists(path) ? new FileInfo(path).Length : -1;
    }

    private void BackupFile(string path)
    {
        if (File.Exists(path))
        {
            string directory = Path.GetDirectoryName(path);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            string backupFileName = $"{fileNameWithoutExtension}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";
            string backupPath = Path.Combine(directory, backupFileName);
            File.Copy(path, backupPath);
        }
    }
}
