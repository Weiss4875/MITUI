using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class DeformerGizmoDrawer
    {
        public static void DrawDeformerGizmo(IEditorMesh editorMesh, IEditorCloth editorCloth, float size = 0.005f)
        {
            throw new NotImplementedException();
        }

        static void DrawVertex(int vcnt, List<Vector3> posList, List<Vector3> norList, List<Vector3> tanList, List<int> useList, List<int> selList, float size)
        {
            throw new NotImplementedException();
        }

        static void DrawTriangle(IEditorMesh editorMesh, List<Vector3> posList, List<Vector3> norList, List<Vector3> tanList, List<int> useList)
        {
            throw new NotImplementedException();
        }

        static void DrawTriangle1(int tindex, List<int> triangles, List<Vector3> posList, List<int> useList, Vector3 center, float radius, bool drawTriangle, bool drawNormal, bool drawNumber)
        {
            throw new NotImplementedException();
        }

        static void DrawLine(IEditorMesh editorMesh, List<Vector3> posList, List<Vector3> norList, List<Vector3> tanList, List<int> useList)
        {
            throw new NotImplementedException();
        }
    }
}