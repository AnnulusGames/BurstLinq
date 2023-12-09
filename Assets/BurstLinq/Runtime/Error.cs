using System;

namespace BurstLinq
{
    internal static class Error
    {
        public static void ThrowIfNull<T>(T obj)
        {
            if (obj == null) throw new ArgumentNullException();
        }

        public static void ThrowIfEmpty(int length)
        {
            if (length <= 0) throw new InvalidOperationException("Sequence contains no elements");
        }

        public static void ThrowIfEmpty(bool isEmpty)
        {
            if (isEmpty) throw new InvalidOperationException("Sequence contains no elements");
        }
    }
}