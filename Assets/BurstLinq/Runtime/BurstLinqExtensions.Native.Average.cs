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
        public static double Average(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            SumCore(ptr, length, out var sum);
            result = (double)sum / length;
        }

        public static double Average(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            SumCore(ptr, length, out var sum);
            result = (double)sum / length;
        }

        public static double Average(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            SumCore(ptr, length, out var sum);
            result = (double)sum / length;
        }

        public static double Average(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            SumCore(ptr, length, out var sum);
            result = (double)sum / length;
        }

        public static float Average(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Average(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Average(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
            SumCore(ptr, length, out var sum);
            result = (float)sum / length;
        }

        public static double Average(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Average(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            SumCore(ptr, length, out var sum);
            result = (double)sum / length;
        }

        public static Vector2 Average(this NativeList<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Average(this NativeSlice<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Average(this NativeArray<Vector2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(Vector2* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector2 result)
        {
            SumCore(ptr, length, out var sum);
            result = (Vector2)sum / length;
        }

        public static Vector2 Average(this NativeList<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Average(this NativeSlice<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector2 Average(this NativeArray<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector2Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(Vector2Int* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector2 result)
        {
            SumCore(ptr, length, out var sum);
            result = (Vector2)sum / length;
        }

        public static Vector3 Average(this NativeList<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Average(this NativeSlice<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Average(this NativeArray<Vector3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(Vector3* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector3 result)
        {
            SumCore(ptr, length, out var sum);
            result = (Vector3)sum / length;
        }

        public static Vector3 Average(this NativeList<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Average(this NativeSlice<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector3 Average(this NativeArray<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector3Int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(Vector3Int* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector3 result)
        {
            SumCore(ptr, length, out var sum);
            result = (Vector3)sum / length;
        }

        public static Vector4 Average(this NativeList<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector4 Average(this NativeSlice<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static Vector4 Average(this NativeArray<Vector4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((Vector4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(Vector4* ptr, [AssumeRange(1, int.MaxValue)] int length, out Vector4 result)
        {
            SumCore(ptr, length, out var sum);
            result = (Vector4)sum / length;
        }

        public static double2 Average(this NativeList<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Average(this NativeSlice<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Average(this NativeArray<int2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(int2* ptr, [AssumeRange(1, int.MaxValue)] int length, out double2 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double2)sum / length;
        }

        public static double3 Average(this NativeList<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Average(this NativeSlice<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Average(this NativeArray<int3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(int3* ptr, [AssumeRange(1, int.MaxValue)] int length, out double3 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double3)sum / length;
        }

        public static double4 Average(this NativeList<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Average(this NativeSlice<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Average(this NativeArray<int4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((int4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(int4* ptr, [AssumeRange(1, int.MaxValue)] int length, out double4 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double4)sum / length;
        }

        public static float2 Average(this NativeList<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float2 Average(this NativeSlice<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float2 Average(this NativeArray<float2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(float2* ptr, [AssumeRange(1, int.MaxValue)] int length, out float2 result)
        {
            SumCore(ptr, length, out var sum);
            result = (float2)sum / length;
        }

        public static float3 Average(this NativeList<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float3 Average(this NativeSlice<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float3 Average(this NativeArray<float3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(float3* ptr, [AssumeRange(1, int.MaxValue)] int length, out float3 result)
        {
            SumCore(ptr, length, out var sum);
            result = (float3)sum / length;
        }

        public static float4 Average(this NativeList<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float4 Average(this NativeSlice<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float4 Average(this NativeArray<float4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((float4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(float4* ptr, [AssumeRange(1, int.MaxValue)] int length, out float4 result)
        {
            SumCore(ptr, length, out var sum);
            result = (float4)sum / length;
        }

        public static double2 Average(this NativeList<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Average(this NativeSlice<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double2 Average(this NativeArray<double2> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double2*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(double2* ptr, [AssumeRange(1, int.MaxValue)] int length, out double2 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double2)sum / length;
        }

        public static double3 Average(this NativeList<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Average(this NativeSlice<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double3 Average(this NativeArray<double3> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double3*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(double3* ptr, [AssumeRange(1, int.MaxValue)] int length, out double3 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double3)sum / length;
        }

        public static double4 Average(this NativeList<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Average(this NativeSlice<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double4 Average(this NativeArray<double4> source)
        {
            Error.ThrowIfEmpty(source.Length);
            AverageCore((double4*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        
        [BurstCompile]
        internal static void AverageCore(double4* ptr, [AssumeRange(1, int.MaxValue)] int length, out double4 result)
        {
            SumCore(ptr, length, out var sum);
            result = (double4)sum / length;
        }

    }
}