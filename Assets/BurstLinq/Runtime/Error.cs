using System;
using System.Runtime.CompilerServices;

namespace BurstLinq
{
    internal static class Error
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfNull<T>(T obj)
        {
            if (obj == null) throw new ArgumentNullException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfEmpty(int length)
        {
            if (length <= 0) throw new InvalidOperationException("Sequence contains no elements");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ThrowIfEmpty(bool isEmpty)
        {
            if (isEmpty) throw new InvalidOperationException("Sequence contains no elements");
        }
    }
}