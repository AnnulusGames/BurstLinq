using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static byte Min(this NativeList<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Min(this NativeSlice<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Min(this NativeArray<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(byte* ptr, [AssumeRange(1, int.MaxValue)] int length, out byte result)
        {
            result = byte.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static sbyte Min(this NativeList<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Min(this NativeSlice<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Min(this NativeArray<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(sbyte* ptr, [AssumeRange(1, int.MaxValue)] int length, out sbyte result)
        {
            result = sbyte.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static short Min(this NativeList<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Min(this NativeSlice<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Min(this NativeArray<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(short* ptr, [AssumeRange(1, int.MaxValue)] int length, out short result)
        {
            result = short.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static ushort Min(this NativeList<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Min(this NativeSlice<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Min(this NativeArray<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(ushort* ptr, [AssumeRange(1, int.MaxValue)] int length, out ushort result)
        {
            result = ushort.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static int Min(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Min(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Min(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out int result)
        {
            result = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static uint Min(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Min(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Min(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint result)
        {
            result = uint.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static long Min(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Min(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Min(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out long result)
        {
            result = long.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static ulong Min(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Min(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Min(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out ulong result)
        {
            result = ulong.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static float Min(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Min(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Min(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
            result = float.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static double Min(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Min(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Min(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MinCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            result = double.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

    }
}