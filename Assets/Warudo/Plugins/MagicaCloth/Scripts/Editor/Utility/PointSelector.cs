using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public class PointSelector
    {
        public static bool EditEnable { get; private set; }

        static void Init()
        {
            throw new NotImplementedException();
        }

        private class PointType
        {
            public string label;
            public Color col;
            public int value;
        }

        List<PointType> pointTypeList = new List<PointType>();
        Dictionary<int, PointType> value2typeDict = new Dictionary<int, PointType>();
        public class PointData
        {
            public Vector3 pos;
            public int index;
            public int value;
            public float distance;
        }

        List<PointData> pointList = new List<PointData>();
        float pointSize = 0.01f;
        bool selectNearest = false;
        int selectPointType = 0;
        public void EnableEdit()
        {
            throw new NotImplementedException();
        }

        public void DisableEdit(UnityEngine.Object obj)
        {
            throw new NotImplementedException();
        }

        void StartEdit(UnityEngine.Object obj)
        {
            throw new NotImplementedException();
        }

        void EndEdit(UnityEngine.Object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsEdit(UnityEngine.Object obj)
        {
            throw new NotImplementedException();
        }

        void Clear()
        {
            throw new NotImplementedException();
        }

        public void AddPointType(string label, Color col, int value)
        {
            throw new NotImplementedException();
        }

        public void AddPoint(Vector3 pos, int index, int value)
        {
            throw new NotImplementedException();
        }

        public List<PointData> GetPointList()
        {
            throw new NotImplementedException();
        }

        Color GetPointColor(int value)
        {
            throw new NotImplementedException();
        }

        void OnSceneView(SceneView sceneView)
        {
            throw new NotImplementedException();
        }

        void ZSort(Vector3 campos, Vector3 camdir)
        {
            throw new NotImplementedException();
        }

        bool hitTest(Vector3 spos, Vector3 epos, float hitRadius)
        {
            throw new NotImplementedException();
        }

        float SqDistPointSegment(Vector3 a, Vector3 b, Vector3 c)
        {
            throw new NotImplementedException();
        }

        public void DrawInspectorGUI(UnityEngine.Object obj, System.Action<PointSelector> startAction, System.Action<PointSelector> endAction)
        {
            throw new NotImplementedException();
        }
    }
}