using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static int Sum(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Sum(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Sum(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out int result)
        {
            var sum = default(int);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static uint Sum(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Sum(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Sum(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint result)
        {
            var sum = default(uint);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static long Sum(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Sum(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Sum(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out long result)
        {
            var sum = default(long);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static ulong Sum(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Sum(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Sum(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out ulong result)
        {
            var sum = default(ulong);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static float Sum(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Sum(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Sum(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
            var sum = default(float);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static double Sum(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Sum(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Sum(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            var sum = default(double);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static Vector2 Sum(this NativeList<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Sum(this NativeSlice<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Sum(this NativeArray<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(Vector2* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector2 result)
        {
            SumCore((float4*)ptr, length  / 2, out var sum2);
            Vector2 sum = new Vector2(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static Vector2Int Sum(this NativeList<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2Int Sum(this NativeSlice<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2Int Sum(this NativeArray<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(Vector2Int* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector2Int result)
        {
            SumCore((int4*)ptr, length  / 2, out var sum2);
            Vector2Int sum = new Vector2Int(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static Vector3 Sum(this NativeList<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Sum(this NativeSlice<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Sum(this NativeArray<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(Vector3* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector3 result)
        {
            var sum = default(Vector3);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static Vector3Int Sum(this NativeList<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3Int Sum(this NativeSlice<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3Int Sum(this NativeArray<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(Vector3Int* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector3Int result)
        {
            var sum = default(Vector3Int);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static Vector4 Sum(this NativeList<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector4 Sum(this NativeSlice<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector4 Sum(this NativeArray<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(Vector4* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector4 result)
        {
            var sum = default(Vector4);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static int2 Sum(this NativeList<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int2 Sum(this NativeSlice<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int2 Sum(this NativeArray<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(int2* ptr, [AssumeRange(1, int.MaxValue)] int length, out int2 result)
        {
            SumCore((int4*)ptr, length  / 2, out var sum2);
            int2 sum = new int2(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static int3 Sum(this NativeList<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int3 Sum(this NativeSlice<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int3 Sum(this NativeArray<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(int3* ptr, [AssumeRange(1, int.MaxValue)] int length, out int3 result)
        {
            var sum = default(int3);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static int4 Sum(this NativeList<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int4 Sum(this NativeSlice<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int4 Sum(this NativeArray<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(int4* ptr, [AssumeRange(1, int.MaxValue)] int length, out int4 result)
        {
            var sum = default(int4);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static uint2 Sum(this NativeList<uint2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint2 Sum(this NativeSlice<uint2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint2 Sum(this NativeArray<uint2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(uint2* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint2 result)
        {
            SumCore((uint4*)ptr, length  / 2, out var sum2);
            uint2 sum = new uint2(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static uint3 Sum(this NativeList<uint3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint3 Sum(this NativeSlice<uint3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint3 Sum(this NativeArray<uint3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(uint3* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint3 result)
        {
            var sum = default(uint3);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static uint4 Sum(this NativeList<uint4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint4 Sum(this NativeSlice<uint4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint4 Sum(this NativeArray<uint4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((uint4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(uint4* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint4 result)
        {
            var sum = default(uint4);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static float2 Sum(this NativeList<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float2 Sum(this NativeSlice<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float2 Sum(this NativeArray<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(float2* ptr, [AssumeRange(1, int.MaxValue)] int length, out float2 result)
        {
            SumCore((float4*)ptr, length  / 2, out var sum2);
            float2 sum = new float2(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static float3 Sum(this NativeList<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float3 Sum(this NativeSlice<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float3 Sum(this NativeArray<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(float3* ptr, [AssumeRange(1, int.MaxValue)] int length, out float3 result)
        {
            var sum = default(float3);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static float4 Sum(this NativeList<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float4 Sum(this NativeSlice<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float4 Sum(this NativeArray<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(float4* ptr, [AssumeRange(1, int.MaxValue)] int length, out float4 result)
        {
            var sum = default(float4);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static double2 Sum(this NativeList<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Sum(this NativeSlice<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Sum(this NativeArray<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(double2* ptr, [AssumeRange(1, int.MaxValue)] int length, out double2 result)
        {
            SumCore((double4*)ptr, length  / 2, out var sum2);
            double2 sum = new double2(sum2.x+sum2.z, sum2.y+ sum2.w);
            if (length%2==1) sum += ptr[length-1];
            result = sum;
        }
        public static double3 Sum(this NativeList<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Sum(this NativeSlice<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Sum(this NativeArray<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(double3* ptr, [AssumeRange(1, int.MaxValue)] int length, out double3 result)
        {
            var sum = default(double3);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
        public static double4 Sum(this NativeList<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Sum(this NativeSlice<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Sum(this NativeArray<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            SumCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile(FloatMode = FloatMode.Fast)]
        internal static void SumCore(double4* ptr, [AssumeRange(1, int.MaxValue)] int length, out double4 result)
        {
            var sum = default(double4);
            for (int i = 0; i < length; i++) sum += ptr[i];
            result = sum;
        }
    }
}