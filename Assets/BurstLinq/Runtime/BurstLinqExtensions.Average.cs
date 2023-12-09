using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static double Average(this int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Average(this List<int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Average(this Memory<int> source)
        {
            return Average((ReadOnlySpan<int>)source.Span);
        }

        public static double Average(this ReadOnlyMemory<int> source)
        {
            return Average(source.Span);
        }

        public static double Average(this Span<int> source)
        {
            return Average((ReadOnlySpan<int>)source);
        }

        public static double Average(this ReadOnlySpan<int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Average(this uint[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (uint* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Average(this List<uint> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Average(this Memory<uint> source)
        {
            return Average((ReadOnlySpan<uint>)source.Span);
        }

        public static double Average(this ReadOnlyMemory<uint> source)
        {
            return Average(source.Span);
        }

        public static double Average(this Span<uint> source)
        {
            return Average((ReadOnlySpan<uint>)source);
        }

        public static double Average(this ReadOnlySpan<uint> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (uint* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Average(this long[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (long* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Average(this List<long> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (long* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Average(this Memory<long> source)
        {
            return Average((ReadOnlySpan<long>)source.Span);
        }

        public static double Average(this ReadOnlyMemory<long> source)
        {
            return Average(source.Span);
        }

        public static double Average(this Span<long> source)
        {
            return Average((ReadOnlySpan<long>)source);
        }

        public static double Average(this ReadOnlySpan<long> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (long* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Average(this ulong[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (ulong* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Average(this List<ulong> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ulong* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Average(this Memory<ulong> source)
        {
            return Average((ReadOnlySpan<ulong>)source.Span);
        }

        public static double Average(this ReadOnlyMemory<ulong> source)
        {
            return Average(source.Span);
        }

        public static double Average(this Span<ulong> source)
        {
            return Average((ReadOnlySpan<ulong>)source);
        }

        public static double Average(this ReadOnlySpan<ulong> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (ulong* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float Average(this float[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float Average(this List<float> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float Average(this Memory<float> source)
        {
            return Average((ReadOnlySpan<float>)source.Span);
        }

        public static float Average(this ReadOnlyMemory<float> source)
        {
            return Average(source.Span);
        }

        public static float Average(this Span<float> source)
        {
            return Average((ReadOnlySpan<float>)source);
        }

        public static float Average(this ReadOnlySpan<float> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (float* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Average(this double[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Average(this List<double> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Average(this Memory<double> source)
        {
            return Average((ReadOnlySpan<double>)source.Span);
        }

        public static double Average(this ReadOnlyMemory<double> source)
        {
            return Average(source.Span);
        }

        public static double Average(this Span<double> source)
        {
            return Average((ReadOnlySpan<double>)source);
        }

        public static double Average(this ReadOnlySpan<double> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (double* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector2 Average(this Vector2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (Vector2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector2 Average(this List<Vector2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector2 Average(this Memory<Vector2> source)
        {
            return Average((ReadOnlySpan<Vector2>)source.Span);
        }

        public static Vector2 Average(this ReadOnlyMemory<Vector2> source)
        {
            return Average(source.Span);
        }

        public static Vector2 Average(this Span<Vector2> source)
        {
            return Average((ReadOnlySpan<Vector2>)source);
        }

        public static Vector2 Average(this ReadOnlySpan<Vector2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (Vector2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector2 Average(this Vector2Int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (Vector2Int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector2 Average(this List<Vector2Int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2Int* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector2 Average(this Memory<Vector2Int> source)
        {
            return Average((ReadOnlySpan<Vector2Int>)source.Span);
        }

        public static Vector2 Average(this ReadOnlyMemory<Vector2Int> source)
        {
            return Average(source.Span);
        }

        public static Vector2 Average(this Span<Vector2Int> source)
        {
            return Average((ReadOnlySpan<Vector2Int>)source);
        }

        public static Vector2 Average(this ReadOnlySpan<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (Vector2Int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector3 Average(this Vector3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (Vector3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector3 Average(this List<Vector3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector3 Average(this Memory<Vector3> source)
        {
            return Average((ReadOnlySpan<Vector3>)source.Span);
        }

        public static Vector3 Average(this ReadOnlyMemory<Vector3> source)
        {
            return Average(source.Span);
        }

        public static Vector3 Average(this Span<Vector3> source)
        {
            return Average((ReadOnlySpan<Vector3>)source);
        }

        public static Vector3 Average(this ReadOnlySpan<Vector3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (Vector3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector3 Average(this Vector3Int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (Vector3Int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector3 Average(this List<Vector3Int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3Int* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector3 Average(this Memory<Vector3Int> source)
        {
            return Average((ReadOnlySpan<Vector3Int>)source.Span);
        }

        public static Vector3 Average(this ReadOnlyMemory<Vector3Int> source)
        {
            return Average(source.Span);
        }

        public static Vector3 Average(this Span<Vector3Int> source)
        {
            return Average((ReadOnlySpan<Vector3Int>)source);
        }

        public static Vector3 Average(this ReadOnlySpan<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (Vector3Int* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector4 Average(this Vector4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (Vector4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector4 Average(this List<Vector4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector4* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector4 Average(this Memory<Vector4> source)
        {
            return Average((ReadOnlySpan<Vector4>)source.Span);
        }

        public static Vector4 Average(this ReadOnlyMemory<Vector4> source)
        {
            return Average(source.Span);
        }

        public static Vector4 Average(this Span<Vector4> source)
        {
            return Average((ReadOnlySpan<Vector4>)source);
        }

        public static Vector4 Average(this ReadOnlySpan<Vector4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (Vector4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double2 Average(this int2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double2 Average(this List<int2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int2* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double2 Average(this Memory<int2> source)
        {
            return Average((ReadOnlySpan<int2>)source.Span);
        }

        public static double2 Average(this ReadOnlyMemory<int2> source)
        {
            return Average(source.Span);
        }

        public static double2 Average(this Span<int2> source)
        {
            return Average((ReadOnlySpan<int2>)source);
        }

        public static double2 Average(this ReadOnlySpan<int2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (int2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double3 Average(this int3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double3 Average(this List<int3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int3* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double3 Average(this Memory<int3> source)
        {
            return Average((ReadOnlySpan<int3>)source.Span);
        }

        public static double3 Average(this ReadOnlyMemory<int3> source)
        {
            return Average(source.Span);
        }

        public static double3 Average(this Span<int3> source)
        {
            return Average((ReadOnlySpan<int3>)source);
        }

        public static double3 Average(this ReadOnlySpan<int3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (int3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double4 Average(this int4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double4 Average(this List<int4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int4* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double4 Average(this Memory<int4> source)
        {
            return Average((ReadOnlySpan<int4>)source.Span);
        }

        public static double4 Average(this ReadOnlyMemory<int4> source)
        {
            return Average(source.Span);
        }

        public static double4 Average(this Span<int4> source)
        {
            return Average((ReadOnlySpan<int4>)source);
        }

        public static double4 Average(this ReadOnlySpan<int4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (int4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float2 Average(this float2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float2 Average(this List<float2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float2* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float2 Average(this Memory<float2> source)
        {
            return Average((ReadOnlySpan<float2>)source.Span);
        }

        public static float2 Average(this ReadOnlyMemory<float2> source)
        {
            return Average(source.Span);
        }

        public static float2 Average(this Span<float2> source)
        {
            return Average((ReadOnlySpan<float2>)source);
        }

        public static float2 Average(this ReadOnlySpan<float2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (float2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float3 Average(this float3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float3 Average(this List<float3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float3* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float3 Average(this Memory<float3> source)
        {
            return Average((ReadOnlySpan<float3>)source.Span);
        }

        public static float3 Average(this ReadOnlyMemory<float3> source)
        {
            return Average(source.Span);
        }

        public static float3 Average(this Span<float3> source)
        {
            return Average((ReadOnlySpan<float3>)source);
        }

        public static float3 Average(this ReadOnlySpan<float3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (float3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float4 Average(this float4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float4 Average(this List<float4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float4* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float4 Average(this Memory<float4> source)
        {
            return Average((ReadOnlySpan<float4>)source.Span);
        }

        public static float4 Average(this ReadOnlyMemory<float4> source)
        {
            return Average(source.Span);
        }

        public static float4 Average(this Span<float4> source)
        {
            return Average((ReadOnlySpan<float4>)source);
        }

        public static float4 Average(this ReadOnlySpan<float4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (float4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double2 Average(this double2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double2 Average(this List<double2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double2* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double2 Average(this Memory<double2> source)
        {
            return Average((ReadOnlySpan<double2>)source.Span);
        }

        public static double2 Average(this ReadOnlyMemory<double2> source)
        {
            return Average(source.Span);
        }

        public static double2 Average(this Span<double2> source)
        {
            return Average((ReadOnlySpan<double2>)source);
        }

        public static double2 Average(this ReadOnlySpan<double2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (double2* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double3 Average(this double3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double3 Average(this List<double3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double3* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double3 Average(this Memory<double3> source)
        {
            return Average((ReadOnlySpan<double3>)source.Span);
        }

        public static double3 Average(this ReadOnlyMemory<double3> source)
        {
            return Average(source.Span);
        }

        public static double3 Average(this Span<double3> source)
        {
            return Average((ReadOnlySpan<double3>)source);
        }

        public static double3 Average(this ReadOnlySpan<double3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (double3* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double4 Average(this double4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double4 Average(this List<double4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double4* ptr = span)
            {
                AverageCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double4 Average(this Memory<double4> source)
        {
            return Average((ReadOnlySpan<double4>)source.Span);
        }

        public static double4 Average(this ReadOnlyMemory<double4> source)
        {
            return Average(source.Span);
        }

        public static double4 Average(this Span<double4> source)
        {
            return Average((ReadOnlySpan<double4>)source);
        }

        public static double4 Average(this ReadOnlySpan<double4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);

            fixed (double4* ptr = source)
            {
                AverageCore(ptr, source.Length, out var result);
                return result;
            }
        }
    }
}