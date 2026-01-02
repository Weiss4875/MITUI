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
        static Define.Error CreateBoneCloth(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateBoneCloth_MeshData(MagicaBoneCloth scr, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateBoneCloth_ClothData(MagicaBoneCloth scr, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateBoneSpring(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateBoneSpring_MeshData(MagicaBoneSpring scr, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateBoneSpring_ClothData(MagicaBoneSpring scr, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateMeshCloth(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateMeshSpring(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateMeshSpring_ClothData(MagicaMeshSpring scr, SpringData sdata, BaseMeshDeformer deformer)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateRenderDeformer(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static Define.Error CreateVirtualDeformer(CoreComponent core, SerializedObject serializedObject, string savePrefabPath)
        {
            throw new NotImplementedException();
        }

        static bool VerifyChildData(VirtualMeshDeformer scr)
        {
            throw new NotImplementedException();
        }

        static void CreateVertexWeightList(int vcnt, List<Vector3> vertices, List<Vector3> normals, List<Vector4> tangents, List<BoneWeight> boneWeights, List<Matrix4x4> bindPoses, out List<uint> vlist, out List<MeshData.VertexWeight> wlist)
        {
            throw new NotImplementedException();
        }
    }
}