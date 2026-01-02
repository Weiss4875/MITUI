using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class ClothGizmoDrawer
    {
        internal static void AlwaysDrawClothGizmo(PhysicsTeam team, ClothParams param)
        {
            throw new NotImplementedException();
        }

        public static bool DrawClothGizmo(PhysicsTeam team, ClothData clothData, ClothParams param, ClothSetup setup, IEditorMesh editorMesh, IEditorCloth editorCloth)
        {
            throw new NotImplementedException();
        }

        static void DrawVertexRuntime(PhysicsTeam team, ClothData clothData, ClothParams param, ClothSetup setup, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawVertexClothData(ClothData clothData, ClothParams param, int vcnt, List<Vector3> posList, List<Vector3> norList, List<Vector3> tanList, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static Color GetVertexColor(int vindex, float depth, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static bool IsMove(int vindex, List<int> selList)
        {
            throw new NotImplementedException();
        }

        public static void DrawCollider(PhysicsTeam team)
        {
            throw new NotImplementedException();
        }

        static void DrawPenetrationRuntime(PhysicsTeam team, ClothParams param, ClothData clothData, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawPenetrationClothData(PhysicsTeam team, ClothParams param, ClothData clothData, List<Vector3> posList, List<Vector3> norList, List<Vector3> tanList, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawLineRuntime(PhysicsTeam team, ClothData clothData, ClothSetup setup, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawLineRuntimeSub(PhysicsTeam team, Color color, RestoreDistanceConstraint.RestoreDistanceData[] distanceDataList, bool useBase)
        {
            throw new NotImplementedException();
        }

        static void DrawLineClothData(ClothData clothData, List<Vector3> posList, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawLineClothDataSub(ClothData clothData, List<Vector3> posList, Color color, RestoreDistanceConstraint.RestoreDistanceData[] distanceDataList)
        {
            throw new NotImplementedException();
        }

        static void DrawRotationLineRuntime(PhysicsTeam team, ClothData clothData, ClothSetup setup, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawRotationLineClothData(ClothData clothData, List<Vector3> posList, List<int> selList)
        {
            throw new NotImplementedException();
        }

        static void DrawTriangleBendRuntime(PhysicsTeam team, ClothData clothData, ClothSetup setup)
        {
            throw new NotImplementedException();
        }

        static void DrawTriangleBendClothData(ClothData clothData, List<Vector3> posList)
        {
            throw new NotImplementedException();
        }
    }
}