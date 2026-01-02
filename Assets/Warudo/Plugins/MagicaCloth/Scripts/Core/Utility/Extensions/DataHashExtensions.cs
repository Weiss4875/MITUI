using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class DataHashExtensions
    {
        public const int NullHash = 397610387;
        public const int NumberHash = 932781045;
        public static int GetDataHash(this System.Object data)
        {
            throw new NotImplementedException();
        }

        public static int GetDataHash(this IDataHash data)
        {
            throw new NotImplementedException();
        }

        public static int GetDataHash<T>(this T[] data)
        {
            throw new NotImplementedException();
        }

        public static int GetDataHash<T>(this List<T> data)
        {
            throw new NotImplementedException();
        }

        public static int GetDataCountHash<T>(this T[] data)
        {
            throw new NotImplementedException();
        }

        public static int GetDataCountHash<T>(this List<T> data)
        {
            throw new NotImplementedException();
        }

        public static ulong GetVectorDataHash(Vector3 v)
        {
            throw new NotImplementedException();
        }
    }
}