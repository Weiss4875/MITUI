using System.Runtime.CompilerServices;
using Unity.Mathematics;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class MathUtility
    {
        public static float Clamp1(float a)
        {
            throw new NotImplementedException();
        }

        public static float Clamp01(float a)
        {
            throw new NotImplementedException();
        }

        public static float3 Project(float3 v, float3 n)
        {
            throw new NotImplementedException();
        }

        public static float Angle(float3 v1, float3 v2)
        {
            throw new NotImplementedException();
        }

        public static float3 ClampVector(float3 v, float minlength, float maxlength)
        {
            throw new NotImplementedException();
        }

        public static float3 ClampVector(float3 v, float maxlength)
        {
            throw new NotImplementedException();
        }

        public static float3 ClampDistance(float3 from, float3 to, float maxlength)
        {
            throw new NotImplementedException();
        }

        public static bool ClampAngle(float3 dir, float3 basedir, float maxAngle, out float3 outdir)
        {
            throw new NotImplementedException();
        }

        public static quaternion FromToRotation(float3 from, float3 to, float t = 1.0f)
        {
            throw new NotImplementedException();
        }

        public static quaternion FromToRotation(quaternion from, quaternion to)
        {
            throw new NotImplementedException();
        }

        public static float Angle(quaternion a, quaternion b)
        {
            throw new NotImplementedException();
        }

        public static quaternion ClampAngle(quaternion from, quaternion to, float maxAngle)
        {
            throw new NotImplementedException();
        }

        public static float3 AxisToEuler(float3 axis)
        {
            throw new NotImplementedException();
        }

        public static quaternion AxisQuaternion(float3 dir)
        {
            throw new NotImplementedException();
        }

        public static float ClosestPtPointSegmentRatio(float3 c, float3 a, float3 b)
        {
            throw new NotImplementedException();
        }

        public static float ClosestPtPointSegmentRatioNoClamp(float3 c, float3 a, float3 b)
        {
            throw new NotImplementedException();
        }

        public static float3 ClosestPtPointSegment(float3 c, float3 a, float3 b)
        {
            throw new NotImplementedException();
        }

        public static float3 ClosestPtPointSegmentNoClamp(float3 c, float3 a, float3 b)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectPointPlane(float3 planePos, float3 planeDir, float3 pos, out float3 outpos)
        {
            throw new NotImplementedException();
        }

        public static float IntersectPointPlaneDist(float3 planePos, float3 planeDir, float3 pos, out float3 outPos)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectSegmentPlane(float3 a, float3 b, float3 p, float3 pn, out float3 opos)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectPointSphere(float3 sc, float sr, float3 pos, out float3 outPos)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectPointSphere(float3 p, float3 sc, float sr)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectRaySphere(float3 p, float3 d, float3 sc, float sr, out float3 q, out float t)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineSphare(float3 a, float3 b, float3 sc, float sr, out float3 q)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectRayCone(float3 o, float3 d, float3 c, float3 v, float cost, out float t, out float3 p)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineConeSurface(float3 a, float3 b, float3 d, float dlen, float3 c, float3 v, float cost, float3 c1, float3 c2, out float3 p)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineCylinderSurface(float3 sa, float3 sb, float3 p, float3 q, float r, out float t)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineCylinderSurface(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineCapsule(float3 a, float3 b, float3 c1, float3 c2, float r1, float r2, out float3 p)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectTrianglePointDistance(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectTrianglePointDistanceSide(float3 p, float3 p0, float3 p1, float3 p2, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectTrianglePointDistanceSide2(float3 p, float3 p0, float3 p1, float3 p2, float radius, float restDist, float compressionStiffness, float stretchStiffness, float side, out float3 corr, out float3 corr0, out float3 corr1, out float3 corr2)
        {
            throw new NotImplementedException();
        }

        public static float DistanceTrianglePoint(float3 p, float3 p0, float3 p1, float3 p2)
        {
            throw new NotImplementedException();
        }

        public static float3 TriangleCenter(float3 p0, float3 p1, float3 p2)
        {
            throw new NotImplementedException();
        }

        public static float3 TriangleNormal(float3 p0, float3 p1, float3 p2)
        {
            throw new NotImplementedException();
        }

        public static quaternion TriangleRotation(float3 p0, float3 p1, float3 p2)
        {
            throw new NotImplementedException();
        }

        public static quaternion TriangleCenterRotation(float3 p0, float3 p1, float3 p2, float3 p3)
        {
            throw new NotImplementedException();
        }

        public static float DistanceTriangleCenter(float3 p, float3 p0, float3 p1, float3 p2)
        {
            throw new NotImplementedException();
        }

        public static float DirectionPointTriangle(float3 p, float3 a, float3 b, float3 c)
        {
            throw new NotImplementedException();
        }

        public static bool IntersectLineTriangle(float3 p, float3 q, float3 a, float3 b, float3 c, out float3 hitpos, out float t, out float3 n)
        {
            throw new NotImplementedException();
        }

        public static float ClosestPtSegmentSegment(float3 p1, float3 q1, float3 p2, float3 q2, out float s, out float t, out float3 c1, out float3 c2)
        {
            throw new NotImplementedException();
        }

        public static float GetBezierValue(BezierParam bparam, float t)
        {
            throw new NotImplementedException();
        }

        public static float GetBezierValue(float sval, float eval, float curve, float t)
        {
            throw new NotImplementedException();
        }
    }
}