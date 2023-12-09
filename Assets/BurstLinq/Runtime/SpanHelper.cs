using System;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace BurstLinq
{
    // Class for extracting the contents of List with UnsafeUtility.As
    internal sealed class ListView<T>
    {
        public T[] _items;
    }

    [BurstCompile]
    internal static class SpanHelper
    {
        [BurstCompile]
        public static unsafe void CopyFrom<T>(in NativeArray<T> array, in ReadOnlySpan<T> source)
            where T : unmanaged
        {
            CheckLength(source.Length, array.Length);
            void* dstPtr = array.GetUnsafePtr();

            fixed (void* srcPtr = source)
            {
                UnsafeUtility.MemCpy(dstPtr, srcPtr, array.Length * UnsafeUtility.SizeOf<T>());
            }
        }

        public static Span<T> AsSpan<T>(List<T> list) where T : unmanaged
        {
            ref var view = ref UnsafeUtility.As<List<T>, ListView<T>>(ref list);
            return view._items.AsSpan(0, list.Count);
        }

        [Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
        static void CheckLength(int srcLength, int dstLength)
        {
            if (srcLength != dstLength) throw new ArgumentException("source and destination length must be the same");
        }
    }
}