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
using VRC.SDK3.Avatars.Components;
using System.Linq;
using System.Collections.Generic;
using nadena.dev.ndmf;
using nadena.dev.modular_avatar.core;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Animations;
using VRC.SDK3.Avatars.ScriptableObjects; // ExpressionParameters 사용
using VRC.SDK3.Dynamics.PhysBone.Components; // VRCPhysBone
#endif

[DisallowMultipleComponent]
[AddComponentMenu("Fermat Components/FT Setting")]
public class ftSet : AvatarTagComponent
{
    public List<string> layersToDelete = new List<string>();

    public VRCAvatarDescriptor.LipSyncStyle lipSyncStyle = VRCAvatarDescriptor.LipSyncStyle.Default;
    public string visemeMeshObjectName;
    private SkinnedMeshRenderer visemeSkinnedMesh;
    public string[] visemeBlendShapes = new string[15];
    public List<string> selectedExpressionParameters = new List<string>();
    public List<string> physBonePaths = new List<string>();

    public override void ResolveReferences()
    {
        Debug.Log("ftSet: ResolveReferences 호출됨.");
        ApplyModifications();
    }

    private void Awake()
    {
        Debug.Log("ftSet: Awake 호출됨.");

        if (!string.IsNullOrEmpty(visemeMeshObjectName))
        {
            Transform foundTransform = transform.parent?.Find(visemeMeshObjectName);
            if (foundTransform != null)
            {
                visemeSkinnedMesh = foundTransform.GetComponent<SkinnedMeshRenderer>();
                if (visemeSkinnedMesh != null)
                {
                    Debug.Log($"ftSet: '{visemeMeshObjectName}'에서 SkinnedMeshRenderer를 찾음 -> {visemeSkinnedMesh.name}");
                }
                else
                {
                    Debug.LogWarning($"ftSet: '{visemeMeshObjectName}' 오브젝트에 SkinnedMeshRenderer가 없습니다.");
                }
            }
            else
            {
                Debug.LogWarning($"ftSet: '{visemeMeshObjectName}' 이름의 오브젝트를 찾을 수 없습니다.");
            }
        }
    }

    private void ApplyModifications()
    {
        GameObject avatarRoot = transform.root.gameObject;
        if (avatarRoot == null)
        {
            Debug.LogError("ftSet: 아바타 루트를 찾을 수 없습니다.");
            return;
        }

        VRCAvatarDescriptor avatarDescriptor = avatarRoot.GetComponent<VRCAvatarDescriptor>();
        if (avatarDescriptor == null)
        {
            Debug.LogError("ftSet: VRCAvatarDescriptor를 찾을 수 없습니다.");
            return;
        }

#if UNITY_EDITOR
        DeleteFXLayers(avatarDescriptor);
        ModifyExpressionParameters(avatarDescriptor);
        ModifyLipSync(avatarDescriptor);
        EnablePhysBoneAnimations(avatarDescriptor);
#endif


        
        Debug.Log("ftSet: 적용 완료.");
    }

#if UNITY_EDITOR
    private void DeleteFXLayers(VRCAvatarDescriptor avatarDescriptor)
    {
        var baseAnimationLayers = avatarDescriptor.baseAnimationLayers;
        for (int i = 0; i < baseAnimationLayers.Length; i++)
        {
            var layer = baseAnimationLayers[i];
            if (layer.type == VRCAvatarDescriptor.AnimLayerType.FX && layer.animatorController is AnimatorController fxController)
            {
                Debug.Log($"ftSet: 기존 FX 레이어 - {fxController.name}");

                AnimatorController runtimeController = Object.Instantiate(fxController);
                runtimeController.name = fxController.name + " (Runtime Clone)";

                var updatedLayers = runtimeController.layers
                    .Where(layerInfo => !layersToDelete.Contains(layerInfo.name))
                    .ToArray();

                int deletedCount = runtimeController.layers.Length - updatedLayers.Length;
                runtimeController.layers = updatedLayers;

                Debug.Log($"ftSet: 삭제된 레이어 개수 - {deletedCount}");

                baseAnimationLayers[i].animatorController = runtimeController;
                avatarDescriptor.baseAnimationLayers = baseAnimationLayers;
            }
        }
    }

    private void ModifyExpressionParameters(VRCAvatarDescriptor avatarDescriptor)
    {
        Debug.Log("ftSet: Expression Parameters 설정 시작.");

        var originalParams = avatarDescriptor.expressionParameters;
        if (originalParams == null)
        {
            Debug.Log("ftSet: ExpressionParameters가 없습니다.");
            return;
        }

        // 기존 ExpressionParameters를 비파괴적으로 복사
        var runtimeParams = Object.Instantiate(originalParams);
        runtimeParams.name = originalParams.name + " (Runtime Clone)";

        // Synced 해제 대상 파라미터 리스트 확인 후 적용
        foreach (var p in runtimeParams.parameters)
        {
            if (p != null && selectedExpressionParameters.Contains(p.name))
            {
                p.networkSynced = false;
                Debug.Log($"ftSet: '{p.name}'의 Synced 해제됨.");
            }
        }

        // 아바타에 새로운 ExpressionParameters 적용
        avatarDescriptor.expressionParameters = runtimeParams;

        // 변경 사항 저장 (Unity Editor 환경)
        EditorUtility.SetDirty(runtimeParams);
        EditorUtility.SetDirty(avatarDescriptor);
        AssetDatabase.SaveAssets();

        Debug.Log("ftSet: Expression Parameters 복제 및 적용 완료.");
    }

    private void ModifyLipSync(VRCAvatarDescriptor avatarDescriptor)
    {
        Debug.Log("ftSet: 립싱크 설정 적용 시작.");
        avatarDescriptor.lipSync = lipSyncStyle;
        Debug.Log($"ftSet: 립싱크 스타일 설정 - {lipSyncStyle}");

        if (lipSyncStyle == VRCAvatarDescriptor.LipSyncStyle.VisemeBlendShape)
        {
            SkinnedMeshRenderer meshRenderer = GetVisemeMesh(avatarDescriptor);
            if (meshRenderer != null)
            {
                avatarDescriptor.VisemeSkinnedMesh = meshRenderer;
                avatarDescriptor.VisemeBlendShapes = visemeBlendShapes;
                Debug.Log($"ftSet: Viseme 설정 적용됨 -> {meshRenderer.name}");
            }
            else
            {
                Debug.LogWarning($"ftSet: '{visemeMeshObjectName}' 이름의 SkinnedMeshRenderer를 찾을 수 없습니다.");
            }
        }

        Debug.Log("ftSet: 립싱크 설정 적용 완료.");
    }


    private void EnablePhysBoneAnimations(VRCAvatarDescriptor avatarDescriptor)
    {
        foreach (string bonePath in physBonePaths)
        {
            if (string.IsNullOrEmpty(bonePath)) continue; // 빈 경로는 무시, 아니 이걸

            Transform boneTransform = avatarDescriptor.transform.Find(bonePath);
            if (boneTransform == null)
            {
                Debug.LogWarning($"ftSet: 경로 '{bonePath}'에 해당하는 오브젝트를 찾을 수 없습니다. " +
                                "경로가 정확한지 확인하세요.");
                continue;
            }

            VRCPhysBone physBone = boneTransform.GetComponent<VRCPhysBone>();
            if (physBone != null)
            {
                Debug.Log($"ftSet: '{bonePath}' PhysBone의 isAnimated 활성화됨.");
                physBone.isAnimated = true;
            }
            else
            {
                Debug.LogWarning($"ftSet: '{bonePath}' 오브젝트에 VRCPhysBone 컴포넌트가 없습니다. " +
                                "PhysBone이 추가되어 있는지 확인하세요.");
            }
        }
    }

#endif


    public SkinnedMeshRenderer GetVisemeMesh(VRCAvatarDescriptor avatarDescriptor)
    {
        if (avatarDescriptor == null)
        {
            Debug.LogWarning("ftSet: AvatarDescriptor가 설정되지 않았습니다.");
            return null;
        }

        Queue<Transform> queue = new Queue<Transform>();
        queue.Enqueue(avatarDescriptor.transform); // 최상단 노드 시작

        while (queue.Count > 0)
        {
            Transform current = queue.Dequeue();
            
            // 현재 노드에서 파인드
            SkinnedMeshRenderer meshRenderer = current.GetComponent<SkinnedMeshRenderer>();
            if (meshRenderer != null && meshRenderer.name == visemeMeshObjectName)
            {
                Debug.Log($"ftSet: 가장 가까운 SkinnedMeshRenderer 찾음 -> {meshRenderer.name} (노드: {current.name})");
                return meshRenderer;
            }

            // BFC
            foreach (Transform child in current)
            {
                queue.Enqueue(child);
            }
        }

        Debug.LogWarning($"ftSet: '{visemeMeshObjectName}' 이름을 가진 SkinnedMeshRenderer를 찾을 수 없습니다.");
        return null;
    }

}
