using Unity.Collections;
using System.Runtime.CompilerServices;
using System;
using Object = UnityEngine.Object;

namespace MagicaCloth
{
    public static class NativeArrayExtension
    {
        public static void CopyToFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
            where T : struct where T2 : struct
        {
            throw new NotImplementedException();
        }

        public static void CopyToFast<T>(this NativeArray<T> nativeArray, int startIndex, NativeArray<T> array)
            where T : struct
        {
            throw new NotImplementedException();
        }

        public static void CopyBlock<T>(this NativeArray<T> nativeArray, int sourceIndex, int destinationIndex, int count)
            where T : struct
        {
            throw new NotImplementedException();
        }

        public static void CopyFromFast<T>(this NativeArray<T> nativeArray, NativeArray<T> array)
            where T : struct
        {
            throw new NotImplementedException();
        }

        public static void CopyFromFast<T, T2>(this NativeArray<T> nativeArray, int startIndex, T2[] array)
            where T : struct where T2 : struct
        {
            throw new NotImplementedException();
        }

        public static void SetValue<T>(this NativeArray<T> nativeArray, int startIndex, int count, T value)
            where T : struct
        {
            throw new NotImplementedException();
        }
    }
}