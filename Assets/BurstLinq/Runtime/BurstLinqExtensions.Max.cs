using System;
using System.Collections.Generic;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static byte Max(this byte[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (byte* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static byte Max(this List<byte> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (byte* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static byte Max(this Memory<byte> source)
        {
            return Max((ReadOnlySpan<byte>)source.Span);
        }

        public static byte Max(this ReadOnlyMemory<byte> source)
        {
            return Max(source.Span);
        }

        public static byte Max(this Span<byte> source)
        {
            return Max((ReadOnlySpan<byte>)source);
        }

        public static byte Max(this ReadOnlySpan<byte> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (byte* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static sbyte Max(this sbyte[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (sbyte* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static sbyte Max(this List<sbyte> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (sbyte* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static sbyte Max(this Memory<sbyte> source)
        {
            return Max((ReadOnlySpan<sbyte>)source.Span);
        }

        public static sbyte Max(this ReadOnlyMemory<sbyte> source)
        {
            return Max(source.Span);
        }

        public static sbyte Max(this Span<sbyte> source)
        {
            return Max((ReadOnlySpan<sbyte>)source);
        }

        public static sbyte Max(this ReadOnlySpan<sbyte> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (sbyte* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static short Max(this short[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (short* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static short Max(this List<short> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (short* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static short Max(this Memory<short> source)
        {
            return Max((ReadOnlySpan<short>)source.Span);
        }

        public static short Max(this ReadOnlyMemory<short> source)
        {
            return Max(source.Span);
        }

        public static short Max(this Span<short> source)
        {
            return Max((ReadOnlySpan<short>)source);
        }

        public static short Max(this ReadOnlySpan<short> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (short* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static ushort Max(this ushort[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (ushort* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static ushort Max(this List<ushort> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ushort* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static ushort Max(this Memory<ushort> source)
        {
            return Max((ReadOnlySpan<ushort>)source.Span);
        }

        public static ushort Max(this ReadOnlyMemory<ushort> source)
        {
            return Max(source.Span);
        }

        public static ushort Max(this Span<ushort> source)
        {
            return Max((ReadOnlySpan<ushort>)source);
        }

        public static ushort Max(this ReadOnlySpan<ushort> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (ushort* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static int Max(this int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int Max(this List<int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int Max(this Memory<int> source)
        {
            return Max((ReadOnlySpan<int>)source.Span);
        }

        public static int Max(this ReadOnlyMemory<int> source)
        {
            return Max(source.Span);
        }

        public static int Max(this Span<int> source)
        {
            return Max((ReadOnlySpan<int>)source);
        }

        public static int Max(this ReadOnlySpan<int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint Max(this uint[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (uint* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint Max(this List<uint> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint Max(this Memory<uint> source)
        {
            return Max((ReadOnlySpan<uint>)source.Span);
        }

        public static uint Max(this ReadOnlyMemory<uint> source)
        {
            return Max(source.Span);
        }

        public static uint Max(this Span<uint> source)
        {
            return Max((ReadOnlySpan<uint>)source);
        }

        public static uint Max(this ReadOnlySpan<uint> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static long Max(this long[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (long* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static long Max(this List<long> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (long* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static long Max(this Memory<long> source)
        {
            return Max((ReadOnlySpan<long>)source.Span);
        }

        public static long Max(this ReadOnlyMemory<long> source)
        {
            return Max(source.Span);
        }

        public static long Max(this Span<long> source)
        {
            return Max((ReadOnlySpan<long>)source);
        }

        public static long Max(this ReadOnlySpan<long> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (long* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static ulong Max(this ulong[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (ulong* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static ulong Max(this List<ulong> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ulong* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static ulong Max(this Memory<ulong> source)
        {
            return Max((ReadOnlySpan<ulong>)source.Span);
        }

        public static ulong Max(this ReadOnlyMemory<ulong> source)
        {
            return Max(source.Span);
        }

        public static ulong Max(this Span<ulong> source)
        {
            return Max((ReadOnlySpan<ulong>)source);
        }

        public static ulong Max(this ReadOnlySpan<ulong> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (ulong* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float Max(this float[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float Max(this List<float> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float Max(this Memory<float> source)
        {
            return Max((ReadOnlySpan<float>)source.Span);
        }

        public static float Max(this ReadOnlyMemory<float> source)
        {
            return Max(source.Span);
        }

        public static float Max(this Span<float> source)
        {
            return Max((ReadOnlySpan<float>)source);
        }

        public static float Max(this ReadOnlySpan<float> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Max(this double[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Max(this List<double> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double* ptr = span)
            {
                MaxCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Max(this Memory<double> source)
        {
            return Max((ReadOnlySpan<double>)source.Span);
        }

        public static double Max(this ReadOnlyMemory<double> source)
        {
            return Max(source.Span);
        }

        public static double Max(this Span<double> source)
        {
            return Max((ReadOnlySpan<double>)source);
        }

        public static double Max(this ReadOnlySpan<double> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double* ptr = source)
            {
                MaxCore(ptr, source.Length, out var result);
                return result;
            }
        }
    }
}