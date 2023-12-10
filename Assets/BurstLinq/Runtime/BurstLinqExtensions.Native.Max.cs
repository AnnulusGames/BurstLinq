using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static byte Max(this NativeList<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Max(this NativeSlice<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Max(this NativeArray<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(byte* ptr, [AssumeRange(1, int.MaxValue)] int length, out byte result)
        {
            result = byte.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static sbyte Max(this NativeList<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Max(this NativeSlice<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Max(this NativeArray<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(sbyte* ptr, [AssumeRange(1, int.MaxValue)] int length, out sbyte result)
        {
            result = sbyte.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static short Max(this NativeList<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Max(this NativeSlice<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Max(this NativeArray<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(short* ptr, [AssumeRange(1, int.MaxValue)] int length, out short result)
        {
            result = short.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static ushort Max(this NativeList<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Max(this NativeSlice<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Max(this NativeArray<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(ushort* ptr, [AssumeRange(1, int.MaxValue)] int length, out ushort result)
        {
            result = ushort.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static int Max(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Max(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Max(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out int result)
        {
            var index = 0;
            var result4 = new int4(int.MinValue, int.MinValue, int.MinValue, int.MinValue);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                result4 = math.max(result4, *(int4*)(ptr + index));
            }

            result = math.cmax(result4);
            for (; index < length; index++)
            {
                result = math.max(result, ptr[index]);
            }
        }

        public static uint Max(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Max(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Max(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint result)
        {
            var index = 0;
            var result4 = new uint4(uint.MinValue, uint.MinValue, uint.MinValue, uint.MinValue);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                result4 = math.max(result4, *(uint4*)(ptr + index));
            }

            result = math.cmax(result4);
            for (; index < length; index++)
            {
                result = math.max(result, ptr[index]);
            }
        }

        public static long Max(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Max(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Max(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out long result)
        {
            result = long.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static ulong Max(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Max(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Max(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out ulong result)
        {
            result = ulong.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (result > ptr[i]) result = ptr[i];
            }
        }

        public static float Max(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Max(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Max(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
            var index = 0;
            var result4 = new float4(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                result4 = math.max(result4, *(float4*)(ptr + index));
            }

            result = math.cmax(result4);
            for (; index < length; index++)
            {
                result = math.max(result, ptr[index]);
            }
        }

        public static double Max(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Max(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Max(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            var index = 0;
            var result4 = new double4(double.MinValue, double.MinValue, double.MinValue, double.MinValue);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                result4 = math.max(result4, *(double4*)(ptr + index));
            }

            result = math.cmax(result4);
            for (; index < length; index++)
            {
                result = math.max(result, ptr[index]);
            }
        }

    }
}