using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class GizmoUtility
    {
        public static readonly Color ColorDynamic = new Color(1.0f, 1.0f, 1.0f);
        public static readonly Color ColorKinematic = new Color(1.0f, 1.0f, 0.0f);
        public static readonly Color ColorInvalid = new Color(0.5f, 0.5f, 0.5f);
        public static readonly Color ColorCollider = new Color(0.0f, 1.0f, 0.0f);
        public static readonly Color ColorNonSelectedCollider = new Color(0.5f, 0.3f, 0.0f);
        public static readonly Color ColorTriangle = new Color(1.0f, 0.0f, 1.0f);
        public static readonly Color ColorStructLine = new Color(0.0f, 1.0f, 1.0f);
        public static readonly Color ColorBendLine = new Color(0.0f, 0.5f, 1.0f);
        public static readonly Color ColorNearLine = new Color(0.55f, 0.5f, 0.7f);
        public static readonly Color ColorRotationLine = new Color(1.0f, 0.65f, 0.0f);
        public static readonly Color ColorAdjustLine = new Color(1.0f, 1.0f, 0.0f);
        public static readonly Color ColorAirLine = new Color(0.55f, 0.5f, 0.7f);
        public static readonly Color ColorBasePosition = new Color(1.0f, 0.0f, 0.0f);
        public static readonly Color ColorDirectionMoveLimit = new Color(0.0f, 1.0f, 1.0f);
        public static readonly Color ColorPenetration = new Color(1.0f, 0.3f, 0.0f);
        public static readonly Color ColorCollisionNormal = new Color(0.6f, 0.2f, 1.0f);
        public static readonly Color ColorVelocity = new Color(1.0f, 0.6f, 0.2f);
        public static readonly Color ColorSkinningBone = new Color(1.0f, 0.5f, 0.0f);
        public static readonly Color ColorDeformerPoint = new Color(1.0f, 1.0f, 1.0f);
        public static readonly Color ColorDeformerPointRange = new Color(0.5f, 0.2f, 0.0f);
        public static readonly Color ColorWind = new Color(0.55f, 0.592f, 0.796f);
        public static void DrawWireCapsule(Vector3 pos, Quaternion rot, Vector3 scl, Vector3 ldir, Vector3 lup, float length, float startRadius, float endRadius, bool resetMatrix = true)
        {
            throw new NotImplementedException();
        }

        public static void DrawWireSphere(Vector3 pos, Quaternion rot, Vector3 scl, float radius, bool drawSphere, bool drawAxis, bool resetMatrix = true)
        {
            throw new NotImplementedException();
        }

        public static void DrawWireCube(Vector3 pos, Quaternion rot, Vector3 size, bool resetMatrix = true)
        {
            throw new NotImplementedException();
        }

        public static void DrawWireCone(Vector3 pos, Quaternion rot, float length, float radius, int div = 8)
        {
            throw new NotImplementedException();
        }

        public static void DrawWireArrow(Vector3 pos, Quaternion rot, Vector3 size, bool cross = false)
        {
            throw new NotImplementedException();
        }

        public static void DrawAxis(Vector3 pos, Quaternion rot, float size, bool resetMatrix = true)
        {
            throw new NotImplementedException();
        }

        public static void DrawBone(Vector3 pos, Vector3 tpos, float size)
        {
            throw new NotImplementedException();
        }
    }
}