using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static int Sum(this int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int Sum(this List<int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int Sum(this Memory<int> source)
        {
            return Sum((ReadOnlySpan<int>)source.Span);
        }

        public static int Sum(this ReadOnlyMemory<int> source)
        {
            return Sum(source.Span);
        }

        public static int Sum(this Span<int> source)
        {
            return Sum((ReadOnlySpan<int>)source);
        }

        public static int Sum(this ReadOnlySpan<int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint Sum(this uint[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (uint* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint Sum(this List<uint> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint Sum(this Memory<uint> source)
        {
            return Sum((ReadOnlySpan<uint>)source.Span);
        }

        public static uint Sum(this ReadOnlyMemory<uint> source)
        {
            return Sum(source.Span);
        }

        public static uint Sum(this Span<uint> source)
        {
            return Sum((ReadOnlySpan<uint>)source);
        }

        public static uint Sum(this ReadOnlySpan<uint> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static long Sum(this long[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (long* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static long Sum(this List<long> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (long* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static long Sum(this Memory<long> source)
        {
            return Sum((ReadOnlySpan<long>)source.Span);
        }

        public static long Sum(this ReadOnlyMemory<long> source)
        {
            return Sum(source.Span);
        }

        public static long Sum(this Span<long> source)
        {
            return Sum((ReadOnlySpan<long>)source);
        }

        public static long Sum(this ReadOnlySpan<long> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (long* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static ulong Sum(this ulong[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (ulong* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static ulong Sum(this List<ulong> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ulong* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static ulong Sum(this Memory<ulong> source)
        {
            return Sum((ReadOnlySpan<ulong>)source.Span);
        }

        public static ulong Sum(this ReadOnlyMemory<ulong> source)
        {
            return Sum(source.Span);
        }

        public static ulong Sum(this Span<ulong> source)
        {
            return Sum((ReadOnlySpan<ulong>)source);
        }

        public static ulong Sum(this ReadOnlySpan<ulong> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (ulong* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float Sum(this float[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (float* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float Sum(this List<float> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float Sum(this Memory<float> source)
        {
            return Sum((ReadOnlySpan<float>)source.Span);
        }

        public static float Sum(this ReadOnlyMemory<float> source)
        {
            return Sum(source.Span);
        }

        public static float Sum(this Span<float> source)
        {
            return Sum((ReadOnlySpan<float>)source);
        }

        public static float Sum(this ReadOnlySpan<float> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Sum(this double[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (double* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Sum(this List<double> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Sum(this Memory<double> source)
        {
            return Sum((ReadOnlySpan<double>)source.Span);
        }

        public static double Sum(this ReadOnlyMemory<double> source)
        {
            return Sum(source.Span);
        }

        public static double Sum(this Span<double> source)
        {
            return Sum((ReadOnlySpan<double>)source);
        }

        public static double Sum(this ReadOnlySpan<double> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector2 Sum(this Vector2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (Vector2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector2 Sum(this List<Vector2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector2 Sum(this Memory<Vector2> source)
        {
            return Sum((ReadOnlySpan<Vector2>)source.Span);
        }

        public static Vector2 Sum(this ReadOnlyMemory<Vector2> source)
        {
            return Sum(source.Span);
        }

        public static Vector2 Sum(this Span<Vector2> source)
        {
            return Sum((ReadOnlySpan<Vector2>)source);
        }

        public static Vector2 Sum(this ReadOnlySpan<Vector2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (Vector2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector2Int Sum(this Vector2Int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (Vector2Int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector2Int Sum(this List<Vector2Int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2Int* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector2Int Sum(this Memory<Vector2Int> source)
        {
            return Sum((ReadOnlySpan<Vector2Int>)source.Span);
        }

        public static Vector2Int Sum(this ReadOnlyMemory<Vector2Int> source)
        {
            return Sum(source.Span);
        }

        public static Vector2Int Sum(this Span<Vector2Int> source)
        {
            return Sum((ReadOnlySpan<Vector2Int>)source);
        }

        public static Vector2Int Sum(this ReadOnlySpan<Vector2Int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (Vector2Int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector3 Sum(this Vector3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (Vector3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector3 Sum(this List<Vector3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector3 Sum(this Memory<Vector3> source)
        {
            return Sum((ReadOnlySpan<Vector3>)source.Span);
        }

        public static Vector3 Sum(this ReadOnlyMemory<Vector3> source)
        {
            return Sum(source.Span);
        }

        public static Vector3 Sum(this Span<Vector3> source)
        {
            return Sum((ReadOnlySpan<Vector3>)source);
        }

        public static Vector3 Sum(this ReadOnlySpan<Vector3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (Vector3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector3Int Sum(this Vector3Int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (Vector3Int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector3Int Sum(this List<Vector3Int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3Int* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector3Int Sum(this Memory<Vector3Int> source)
        {
            return Sum((ReadOnlySpan<Vector3Int>)source.Span);
        }

        public static Vector3Int Sum(this ReadOnlyMemory<Vector3Int> source)
        {
            return Sum(source.Span);
        }

        public static Vector3Int Sum(this Span<Vector3Int> source)
        {
            return Sum((ReadOnlySpan<Vector3Int>)source);
        }

        public static Vector3Int Sum(this ReadOnlySpan<Vector3Int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (Vector3Int* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static Vector4 Sum(this Vector4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (Vector4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static Vector4 Sum(this List<Vector4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (Vector4* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static Vector4 Sum(this Memory<Vector4> source)
        {
            return Sum((ReadOnlySpan<Vector4>)source.Span);
        }

        public static Vector4 Sum(this ReadOnlyMemory<Vector4> source)
        {
            return Sum(source.Span);
        }

        public static Vector4 Sum(this Span<Vector4> source)
        {
            return Sum((ReadOnlySpan<Vector4>)source);
        }

        public static Vector4 Sum(this ReadOnlySpan<Vector4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (Vector4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static int2 Sum(this int2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (int2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int2 Sum(this List<int2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int2* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int2 Sum(this Memory<int2> source)
        {
            return Sum((ReadOnlySpan<int2>)source.Span);
        }

        public static int2 Sum(this ReadOnlyMemory<int2> source)
        {
            return Sum(source.Span);
        }

        public static int2 Sum(this Span<int2> source)
        {
            return Sum((ReadOnlySpan<int2>)source);
        }

        public static int2 Sum(this ReadOnlySpan<int2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static int3 Sum(this int3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (int3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int3 Sum(this List<int3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int3* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int3 Sum(this Memory<int3> source)
        {
            return Sum((ReadOnlySpan<int3>)source.Span);
        }

        public static int3 Sum(this ReadOnlyMemory<int3> source)
        {
            return Sum(source.Span);
        }

        public static int3 Sum(this Span<int3> source)
        {
            return Sum((ReadOnlySpan<int3>)source);
        }

        public static int3 Sum(this ReadOnlySpan<int3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static int4 Sum(this int4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (int4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int4 Sum(this List<int4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int4* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int4 Sum(this Memory<int4> source)
        {
            return Sum((ReadOnlySpan<int4>)source.Span);
        }

        public static int4 Sum(this ReadOnlyMemory<int4> source)
        {
            return Sum(source.Span);
        }

        public static int4 Sum(this Span<int4> source)
        {
            return Sum((ReadOnlySpan<int4>)source);
        }

        public static int4 Sum(this ReadOnlySpan<int4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint2 Sum(this uint2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (uint2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint2 Sum(this List<uint2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint2* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint2 Sum(this Memory<uint2> source)
        {
            return Sum((ReadOnlySpan<uint2>)source.Span);
        }

        public static uint2 Sum(this ReadOnlyMemory<uint2> source)
        {
            return Sum(source.Span);
        }

        public static uint2 Sum(this Span<uint2> source)
        {
            return Sum((ReadOnlySpan<uint2>)source);
        }

        public static uint2 Sum(this ReadOnlySpan<uint2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint3 Sum(this uint3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (uint3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint3 Sum(this List<uint3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint3* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint3 Sum(this Memory<uint3> source)
        {
            return Sum((ReadOnlySpan<uint3>)source.Span);
        }

        public static uint3 Sum(this ReadOnlyMemory<uint3> source)
        {
            return Sum(source.Span);
        }

        public static uint3 Sum(this Span<uint3> source)
        {
            return Sum((ReadOnlySpan<uint3>)source);
        }

        public static uint3 Sum(this ReadOnlySpan<uint3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint4 Sum(this uint4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (uint4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint4 Sum(this List<uint4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint4* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint4 Sum(this Memory<uint4> source)
        {
            return Sum((ReadOnlySpan<uint4>)source.Span);
        }

        public static uint4 Sum(this ReadOnlyMemory<uint4> source)
        {
            return Sum(source.Span);
        }

        public static uint4 Sum(this Span<uint4> source)
        {
            return Sum((ReadOnlySpan<uint4>)source);
        }

        public static uint4 Sum(this ReadOnlySpan<uint4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float2 Sum(this float2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (float2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float2 Sum(this List<float2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float2* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float2 Sum(this Memory<float2> source)
        {
            return Sum((ReadOnlySpan<float2>)source.Span);
        }

        public static float2 Sum(this ReadOnlyMemory<float2> source)
        {
            return Sum(source.Span);
        }

        public static float2 Sum(this Span<float2> source)
        {
            return Sum((ReadOnlySpan<float2>)source);
        }

        public static float2 Sum(this ReadOnlySpan<float2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float3 Sum(this float3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (float3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float3 Sum(this List<float3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float3* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float3 Sum(this Memory<float3> source)
        {
            return Sum((ReadOnlySpan<float3>)source.Span);
        }

        public static float3 Sum(this ReadOnlyMemory<float3> source)
        {
            return Sum(source.Span);
        }

        public static float3 Sum(this Span<float3> source)
        {
            return Sum((ReadOnlySpan<float3>)source);
        }

        public static float3 Sum(this ReadOnlySpan<float3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float4 Sum(this float4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (float4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float4 Sum(this List<float4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float4* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float4 Sum(this Memory<float4> source)
        {
            return Sum((ReadOnlySpan<float4>)source.Span);
        }

        public static float4 Sum(this ReadOnlyMemory<float4> source)
        {
            return Sum(source.Span);
        }

        public static float4 Sum(this Span<float4> source)
        {
            return Sum((ReadOnlySpan<float4>)source);
        }

        public static float4 Sum(this ReadOnlySpan<float4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double2 Sum(this double2[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (double2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double2 Sum(this List<double2> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double2* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double2 Sum(this Memory<double2> source)
        {
            return Sum((ReadOnlySpan<double2>)source.Span);
        }

        public static double2 Sum(this ReadOnlyMemory<double2> source)
        {
            return Sum(source.Span);
        }

        public static double2 Sum(this Span<double2> source)
        {
            return Sum((ReadOnlySpan<double2>)source);
        }

        public static double2 Sum(this ReadOnlySpan<double2> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double2* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double3 Sum(this double3[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (double3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double3 Sum(this List<double3> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double3* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double3 Sum(this Memory<double3> source)
        {
            return Sum((ReadOnlySpan<double3>)source.Span);
        }

        public static double3 Sum(this ReadOnlyMemory<double3> source)
        {
            return Sum(source.Span);
        }

        public static double3 Sum(this Span<double3> source)
        {
            return Sum((ReadOnlySpan<double3>)source);
        }

        public static double3 Sum(this ReadOnlySpan<double3> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double3* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double4 Sum(this double4[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);
            fixed (double4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double4 Sum(this List<double4> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double4* ptr = span)
            {
                SumCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double4 Sum(this Memory<double4> source)
        {
            return Sum((ReadOnlySpan<double4>)source.Span);
        }

        public static double4 Sum(this ReadOnlyMemory<double4> source)
        {
            return Sum(source.Span);
        }

        public static double4 Sum(this Span<double4> source)
        {
            return Sum((ReadOnlySpan<double4>)source);
        }

        public static double4 Sum(this ReadOnlySpan<double4> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double4* ptr = source)
            {
                SumCore(ptr, source.Length, out var result);
                return result;
            }
        }
    }
}