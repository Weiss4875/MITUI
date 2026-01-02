using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class DebugData : ReductionMeshAccess
    {
        public void DispMeshInfo(string header = "")
        {
            throw new NotImplementedException();
        }

        public static void DebugDrawShared(FinalData final, bool drawTriangle = true, bool drawLine = true, bool drawTetra = true, bool drawVertexNormal = true, bool drawVertexTangent = true, bool drawNumber = false, int maxPolygonCount = int.MaxValue, int layer = -1, int tetraIndex = -1, float tetraSize = 1.0f, List<int> drawNumberList = null, float axisSize = 0.01f)
        {
            throw new NotImplementedException();
        }

        public static void DebugDrawChild(FinalData final, bool drawPosition = false, bool drawNormal = false, bool drawTriangle = false, bool drawNumber = false, int maxVertexCount = int.MaxValue, float positionSize = 0.001f, float axisSize = 0.01f)
        {
            throw new NotImplementedException();
        }
    }
}