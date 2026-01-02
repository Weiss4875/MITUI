using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaReductionMesh
{
    public class Utility
    {
        public static uint PackPair(int v0, int v1)
        {
            throw new NotImplementedException();
        }

        public static void UnpackPair(uint pack, out int v0, out int v1)
        {
            throw new NotImplementedException();
        }

        public static ulong PackTriple(int v0, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static void UnpackTriple(ulong pack, out int v0, out int v1, out int v2)
        {
            throw new NotImplementedException();
        }

        public static ulong PackQuater(int v0, int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        public static void UnpackQuater(ulong pack, out int v0, out int v1, out int v2, out int v3)
        {
            throw new NotImplementedException();
        }

        public static uint Pack16(int hi, int low)
        {
            throw new NotImplementedException();
        }

        public static int Unpack16Hi(uint pack)
        {
            throw new NotImplementedException();
        }

        public static int Unpack16Low(uint pack)
        {
            throw new NotImplementedException();
        }

        public static ulong Pack32(int hi, int low)
        {
            throw new NotImplementedException();
        }

        public static int Unpack32Hi(ulong pack)
        {
            throw new NotImplementedException();
        }

        public static int Unpack32Low(ulong pack)
        {
            throw new NotImplementedException();
        }

        public static void CalcFinalDataWorldPositionNormalTangent(FinalData final, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList)
        {
            throw new NotImplementedException();
        }

        public static void CalcFinalDataChildWorldPositionNormalTangent(FinalData final, int meshIndex, List<Vector3> sposList, List<Vector3> snorList, List<Vector4> stanList, out List<Vector3> wposList, out List<Vector3> wnorList, out List<Vector4> wtanList)
        {
            throw new NotImplementedException();
        }

        public static void CalcLocalPositionNormalTangent(Transform root, List<Vector3> wposList, List<Vector3> wnorList, List<Vector4> wtanList)
        {
            throw new NotImplementedException();
        }
    }
}