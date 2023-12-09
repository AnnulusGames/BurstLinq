using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static bool Contains(this byte[] source, byte value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (byte* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<byte> source, byte value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (byte* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<byte> source, byte value)
        {
            return Contains((ReadOnlySpan<byte>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<byte> source, byte value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<byte> source, byte value)
        {
            return Contains((ReadOnlySpan<byte>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<byte> source, byte value)
        {
            if (source.IsEmpty) return false;

            fixed (byte* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this sbyte[] source, sbyte value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (sbyte* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<sbyte> source, sbyte value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (sbyte* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<sbyte> source, sbyte value)
        {
            return Contains((ReadOnlySpan<sbyte>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<sbyte> source, sbyte value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<sbyte> source, sbyte value)
        {
            return Contains((ReadOnlySpan<sbyte>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<sbyte> source, sbyte value)
        {
            if (source.IsEmpty) return false;

            fixed (sbyte* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this short[] source, short value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (short* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<short> source, short value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (short* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<short> source, short value)
        {
            return Contains((ReadOnlySpan<short>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<short> source, short value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<short> source, short value)
        {
            return Contains((ReadOnlySpan<short>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<short> source, short value)
        {
            if (source.IsEmpty) return false;

            fixed (short* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this ushort[] source, ushort value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (ushort* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<ushort> source, ushort value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (ushort* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<ushort> source, ushort value)
        {
            return Contains((ReadOnlySpan<ushort>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<ushort> source, ushort value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<ushort> source, ushort value)
        {
            return Contains((ReadOnlySpan<ushort>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<ushort> source, ushort value)
        {
            if (source.IsEmpty) return false;

            fixed (ushort* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this int[] source, int value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<int> source, int value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (int* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<int> source, int value)
        {
            return Contains((ReadOnlySpan<int>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<int> source, int value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<int> source, int value)
        {
            return Contains((ReadOnlySpan<int>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<int> source, int value)
        {
            if (source.IsEmpty) return false;

            fixed (int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this uint[] source, uint value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (uint* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<uint> source, uint value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (uint* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<uint> source, uint value)
        {
            return Contains((ReadOnlySpan<uint>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<uint> source, uint value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<uint> source, uint value)
        {
            return Contains((ReadOnlySpan<uint>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<uint> source, uint value)
        {
            if (source.IsEmpty) return false;

            fixed (uint* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this long[] source, long value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (long* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<long> source, long value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (long* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<long> source, long value)
        {
            return Contains((ReadOnlySpan<long>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<long> source, long value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<long> source, long value)
        {
            return Contains((ReadOnlySpan<long>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<long> source, long value)
        {
            if (source.IsEmpty) return false;

            fixed (long* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this ulong[] source, ulong value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (ulong* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<ulong> source, ulong value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (ulong* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<ulong> source, ulong value)
        {
            return Contains((ReadOnlySpan<ulong>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<ulong> source, ulong value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<ulong> source, ulong value)
        {
            return Contains((ReadOnlySpan<ulong>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<ulong> source, ulong value)
        {
            if (source.IsEmpty) return false;

            fixed (ulong* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this float[] source, float value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (float* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<float> source, float value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (float* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<float> source, float value)
        {
            return Contains((ReadOnlySpan<float>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<float> source, float value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<float> source, float value)
        {
            return Contains((ReadOnlySpan<float>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<float> source, float value)
        {
            if (source.IsEmpty) return false;

            fixed (float* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this double[] source, double value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (double* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<double> source, double value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (double* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<double> source, double value)
        {
            return Contains((ReadOnlySpan<double>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<double> source, double value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<double> source, double value)
        {
            return Contains((ReadOnlySpan<double>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<double> source, double value)
        {
            if (source.IsEmpty) return false;

            fixed (double* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this Vector2[] source, Vector2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (Vector2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<Vector2> source, Vector2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<Vector2> source, Vector2 value)
        {
            return Contains((ReadOnlySpan<Vector2>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<Vector2> source, Vector2 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<Vector2> source, Vector2 value)
        {
            return Contains((ReadOnlySpan<Vector2>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<Vector2> source, Vector2 value)
        {
            if (source.IsEmpty) return false;

            fixed (Vector2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this Vector2Int[] source, Vector2Int value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (Vector2Int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<Vector2Int> source, Vector2Int value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (Vector2Int* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<Vector2Int> source, Vector2Int value)
        {
            return Contains((ReadOnlySpan<Vector2Int>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<Vector2Int> source, Vector2Int value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<Vector2Int> source, Vector2Int value)
        {
            return Contains((ReadOnlySpan<Vector2Int>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<Vector2Int> source, Vector2Int value)
        {
            if (source.IsEmpty) return false;

            fixed (Vector2Int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this Vector3[] source, Vector3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (Vector3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<Vector3> source, Vector3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<Vector3> source, Vector3 value)
        {
            return Contains((ReadOnlySpan<Vector3>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<Vector3> source, Vector3 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<Vector3> source, Vector3 value)
        {
            return Contains((ReadOnlySpan<Vector3>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<Vector3> source, Vector3 value)
        {
            if (source.IsEmpty) return false;

            fixed (Vector3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this Vector3Int[] source, Vector3Int value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (Vector3Int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<Vector3Int> source, Vector3Int value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (Vector3Int* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<Vector3Int> source, Vector3Int value)
        {
            return Contains((ReadOnlySpan<Vector3Int>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<Vector3Int> source, Vector3Int value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<Vector3Int> source, Vector3Int value)
        {
            return Contains((ReadOnlySpan<Vector3Int>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<Vector3Int> source, Vector3Int value)
        {
            if (source.IsEmpty) return false;

            fixed (Vector3Int* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this Vector4[] source, Vector4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (Vector4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<Vector4> source, Vector4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (Vector4* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<Vector4> source, Vector4 value)
        {
            return Contains((ReadOnlySpan<Vector4>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<Vector4> source, Vector4 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<Vector4> source, Vector4 value)
        {
            return Contains((ReadOnlySpan<Vector4>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<Vector4> source, Vector4 value)
        {
            if (source.IsEmpty) return false;

            fixed (Vector4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this int2[] source, int2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (int2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<int2> source, int2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (int2* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<int2> source, int2 value)
        {
            return Contains((ReadOnlySpan<int2>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<int2> source, int2 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<int2> source, int2 value)
        {
            return Contains((ReadOnlySpan<int2>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<int2> source, int2 value)
        {
            if (source.IsEmpty) return false;

            fixed (int2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this int3[] source, int3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (int3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<int3> source, int3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (int3* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<int3> source, int3 value)
        {
            return Contains((ReadOnlySpan<int3>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<int3> source, int3 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<int3> source, int3 value)
        {
            return Contains((ReadOnlySpan<int3>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<int3> source, int3 value)
        {
            if (source.IsEmpty) return false;

            fixed (int3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this int4[] source, int4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (int4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<int4> source, int4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (int4* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<int4> source, int4 value)
        {
            return Contains((ReadOnlySpan<int4>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<int4> source, int4 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<int4> source, int4 value)
        {
            return Contains((ReadOnlySpan<int4>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<int4> source, int4 value)
        {
            if (source.IsEmpty) return false;

            fixed (int4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this uint2[] source, uint2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (uint2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<uint2> source, uint2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (uint2* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<uint2> source, uint2 value)
        {
            return Contains((ReadOnlySpan<uint2>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<uint2> source, uint2 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<uint2> source, uint2 value)
        {
            return Contains((ReadOnlySpan<uint2>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<uint2> source, uint2 value)
        {
            if (source.IsEmpty) return false;

            fixed (uint2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this uint3[] source, uint3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (uint3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<uint3> source, uint3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (uint3* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<uint3> source, uint3 value)
        {
            return Contains((ReadOnlySpan<uint3>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<uint3> source, uint3 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<uint3> source, uint3 value)
        {
            return Contains((ReadOnlySpan<uint3>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<uint3> source, uint3 value)
        {
            if (source.IsEmpty) return false;

            fixed (uint3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this uint4[] source, uint4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (uint4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<uint4> source, uint4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (uint4* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<uint4> source, uint4 value)
        {
            return Contains((ReadOnlySpan<uint4>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<uint4> source, uint4 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<uint4> source, uint4 value)
        {
            return Contains((ReadOnlySpan<uint4>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<uint4> source, uint4 value)
        {
            if (source.IsEmpty) return false;

            fixed (uint4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this float2[] source, float2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (float2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<float2> source, float2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (float2* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<float2> source, float2 value)
        {
            return Contains((ReadOnlySpan<float2>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<float2> source, float2 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<float2> source, float2 value)
        {
            return Contains((ReadOnlySpan<float2>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<float2> source, float2 value)
        {
            if (source.IsEmpty) return false;

            fixed (float2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this float3[] source, float3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (float3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<float3> source, float3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (float3* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<float3> source, float3 value)
        {
            return Contains((ReadOnlySpan<float3>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<float3> source, float3 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<float3> source, float3 value)
        {
            return Contains((ReadOnlySpan<float3>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<float3> source, float3 value)
        {
            if (source.IsEmpty) return false;

            fixed (float3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this float4[] source, float4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (float4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<float4> source, float4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (float4* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<float4> source, float4 value)
        {
            return Contains((ReadOnlySpan<float4>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<float4> source, float4 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<float4> source, float4 value)
        {
            return Contains((ReadOnlySpan<float4>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<float4> source, float4 value)
        {
            if (source.IsEmpty) return false;

            fixed (float4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this double2[] source, double2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (double2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<double2> source, double2 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (double2* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<double2> source, double2 value)
        {
            return Contains((ReadOnlySpan<double2>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<double2> source, double2 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<double2> source, double2 value)
        {
            return Contains((ReadOnlySpan<double2>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<double2> source, double2 value)
        {
            if (source.IsEmpty) return false;

            fixed (double2* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this double3[] source, double3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (double3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<double3> source, double3 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (double3* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<double3> source, double3 value)
        {
            return Contains((ReadOnlySpan<double3>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<double3> source, double3 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<double3> source, double3 value)
        {
            return Contains((ReadOnlySpan<double3>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<double3> source, double3 value)
        {
            if (source.IsEmpty) return false;

            fixed (double3* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
        public static bool Contains(this double4[] source, double4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Length == 0) return false;

            fixed (double4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }

        public static bool Contains(this List<double4> source, double4 value)
        {
            Error.ThrowIfNull(source);
            if (source.Count == 0) return false;

            var span = SpanHelper.AsSpan(source);
            fixed (double4* ptr = span)
            {
                return ContainsCore(ptr, source.Count, value);
            }
        }

        public static bool Contains(this Memory<double4> source, double4 value)
        {
            return Contains((ReadOnlySpan<double4>)source.Span, value);
        }

        public static bool Contains(this ReadOnlyMemory<double4> source, double4 value)
        {
            return Contains(source.Span, value);
        }

        public static bool Contains(this Span<double4> source, double4 value)
        {
            return Contains((ReadOnlySpan<double4>)source, value);
        }

        public static bool Contains(this ReadOnlySpan<double4> source, double4 value)
        {
            if (source.IsEmpty) return false;

            fixed (double4* ptr = source)
            {
                return ContainsCore(ptr, source.Length, value);
            }
        }
    }
}