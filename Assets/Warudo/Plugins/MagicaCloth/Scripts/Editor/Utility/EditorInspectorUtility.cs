using UnityEditor;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class EditorInspectorUtility
    {
        public static void DispDataStatus(IDataVerify verify)
        {
            throw new NotImplementedException();
        }

        public static void DispVersionStatus(CoreComponent core)
        {
            throw new NotImplementedException();
        }

        public static void BezierInspector(string title, SerializedProperty bval, float minVal, float maxVal, string valFmt = "F2")
        {
            throw new NotImplementedException();
        }

        static void GetBezierValue(SerializedProperty bval, out float start, out float end, out float curve)
        {
            throw new NotImplementedException();
        }

        static void DrawGraph(float startVal, float endVal, float curveVal, float minVal, float maxVal, string valFmt)
        {
            throw new NotImplementedException();
        }

        public static void Foldout(string foldKey, string title = null, System.Action drawAct = null, System.Action<bool> enableAct = null, bool enable = false, bool warning = false)
        {
            throw new NotImplementedException();
        }

        public static void TitleBar(string title, bool warning)
        {
            throw new NotImplementedException();
        }

        static bool MinMaxCurveInspector(string title, string valueName, SerializedProperty bval, float minval, float maxval)
        {
            throw new NotImplementedException();
        }

        static bool UseMinMaxCurveInspector(string title, SerializedProperty use, string valueName, SerializedProperty bval, float minval, float maxval, string valFmt = "F2", bool warning = false)
        {
            throw new NotImplementedException();
        }

        public static bool OneSliderInspector(string title, string name1, SerializedProperty property1, float min1, float max1)
        {
            throw new NotImplementedException();
        }

        public static bool TwoSliderInspector(string title, string name1, SerializedProperty property1, float min1, float max1, string name2, SerializedProperty property2, float min2, float max2)
        {
            throw new NotImplementedException();
        }

        public static bool UseOneSliderInspector(string title, SerializedProperty use, string name1, SerializedProperty val1, float min1, float max1)
        {
            throw new NotImplementedException();
        }

        public static bool UseTwoSliderInspector(string title, SerializedProperty use, string name1, SerializedProperty val1, float min1, float max1, string name2, SerializedProperty val2, float min2, float max2)
        {
            throw new NotImplementedException();
        }

        public static bool AlgorithmInspector(SerializedProperty cparam, bool changed, System.Action convertAction)
        {
            throw new NotImplementedException();
        }

        public static bool WorldInfluenceInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool DistanceDisableInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool ExternalForceInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool RadiusInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool MassInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool GravityInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool DragInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool MaxVelocityInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool TriangleBendInspector(SerializedProperty cparam, bool changed, ClothData clothData)
        {
            throw new NotImplementedException();
        }

        public static bool DirectionMoveLimitInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool RestoreRotationInspector(SerializedProperty cparam, bool changed, ClothData clothData)
        {
            throw new NotImplementedException();
        }

        public static bool ClampRotationInspector(SerializedProperty cparam, bool changed, ClothData clothData)
        {
            throw new NotImplementedException();
        }

        public static bool CollisionInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool PenetrationInspector(SerializedObject team, SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool BaseSkinningInspector(SerializedObject team, SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool ClampDistanceInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool RestoreDistanceInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool FullSpringInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool SimpleSpringInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool AdjustRotationInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool ClampPositionInspector(SerializedProperty cparam, bool full, bool changed)
        {
            throw new NotImplementedException();
        }

        public static bool VolumeInspector(SerializedProperty cparam)
        {
            throw new NotImplementedException();
        }

        public static bool RotationInterpolationInspector(SerializedProperty cparam, bool changed)
        {
            throw new NotImplementedException();
        }

        public static void WindComponentInspector(WindComponent wind, SerializedObject so)
        {
            throw new NotImplementedException();
        }

        public static void DrawHorizoneLine()
        {
            throw new NotImplementedException();
        }

        public static void DrawObjectList<T>(SerializedProperty dlist, GameObject obj, bool allselect, bool allclear, System.Func<T[]> func, string allSelectName = null, string allClearName = null)
            where T : UnityEngine.Object
        {
            throw new NotImplementedException();
        }

        public static void MonitorButtonInspector()
        {
            throw new NotImplementedException();
        }
    }
}