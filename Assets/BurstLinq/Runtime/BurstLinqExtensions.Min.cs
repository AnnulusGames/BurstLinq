using System;
using System.Collections.Generic;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static byte Min(this byte[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (byte* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static byte Min(this List<byte> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (byte* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static byte Min(this Memory<byte> source)
        {
            return Min((ReadOnlySpan<byte>)source.Span);
        }

        public static byte Min(this ReadOnlyMemory<byte> source)
        {
            return Min(source.Span);
        }

        public static byte Min(this Span<byte> source)
        {
            return Min((ReadOnlySpan<byte>)source);
        }

        public static byte Min(this ReadOnlySpan<byte> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (byte* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static sbyte Min(this sbyte[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (sbyte* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static sbyte Min(this List<sbyte> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (sbyte* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static sbyte Min(this Memory<sbyte> source)
        {
            return Min((ReadOnlySpan<sbyte>)source.Span);
        }

        public static sbyte Min(this ReadOnlyMemory<sbyte> source)
        {
            return Min(source.Span);
        }

        public static sbyte Min(this Span<sbyte> source)
        {
            return Min((ReadOnlySpan<sbyte>)source);
        }

        public static sbyte Min(this ReadOnlySpan<sbyte> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (sbyte* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static short Min(this short[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (short* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static short Min(this List<short> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (short* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static short Min(this Memory<short> source)
        {
            return Min((ReadOnlySpan<short>)source.Span);
        }

        public static short Min(this ReadOnlyMemory<short> source)
        {
            return Min(source.Span);
        }

        public static short Min(this Span<short> source)
        {
            return Min((ReadOnlySpan<short>)source);
        }

        public static short Min(this ReadOnlySpan<short> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (short* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static ushort Min(this ushort[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (ushort* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static ushort Min(this List<ushort> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ushort* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static ushort Min(this Memory<ushort> source)
        {
            return Min((ReadOnlySpan<ushort>)source.Span);
        }

        public static ushort Min(this ReadOnlyMemory<ushort> source)
        {
            return Min(source.Span);
        }

        public static ushort Min(this Span<ushort> source)
        {
            return Min((ReadOnlySpan<ushort>)source);
        }

        public static ushort Min(this ReadOnlySpan<ushort> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (ushort* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static int Min(this int[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (int* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static int Min(this List<int> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (int* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static int Min(this Memory<int> source)
        {
            return Min((ReadOnlySpan<int>)source.Span);
        }

        public static int Min(this ReadOnlyMemory<int> source)
        {
            return Min(source.Span);
        }

        public static int Min(this Span<int> source)
        {
            return Min((ReadOnlySpan<int>)source);
        }

        public static int Min(this ReadOnlySpan<int> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (int* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static uint Min(this uint[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (uint* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static uint Min(this List<uint> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (uint* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static uint Min(this Memory<uint> source)
        {
            return Min((ReadOnlySpan<uint>)source.Span);
        }

        public static uint Min(this ReadOnlyMemory<uint> source)
        {
            return Min(source.Span);
        }

        public static uint Min(this Span<uint> source)
        {
            return Min((ReadOnlySpan<uint>)source);
        }

        public static uint Min(this ReadOnlySpan<uint> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (uint* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static long Min(this long[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (long* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static long Min(this List<long> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (long* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static long Min(this Memory<long> source)
        {
            return Min((ReadOnlySpan<long>)source.Span);
        }

        public static long Min(this ReadOnlyMemory<long> source)
        {
            return Min(source.Span);
        }

        public static long Min(this Span<long> source)
        {
            return Min((ReadOnlySpan<long>)source);
        }

        public static long Min(this ReadOnlySpan<long> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (long* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static ulong Min(this ulong[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (ulong* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static ulong Min(this List<ulong> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (ulong* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static ulong Min(this Memory<ulong> source)
        {
            return Min((ReadOnlySpan<ulong>)source.Span);
        }

        public static ulong Min(this ReadOnlyMemory<ulong> source)
        {
            return Min(source.Span);
        }

        public static ulong Min(this Span<ulong> source)
        {
            return Min((ReadOnlySpan<ulong>)source);
        }

        public static ulong Min(this ReadOnlySpan<ulong> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (ulong* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static float Min(this float[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (float* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static float Min(this List<float> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (float* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static float Min(this Memory<float> source)
        {
            return Min((ReadOnlySpan<float>)source.Span);
        }

        public static float Min(this ReadOnlyMemory<float> source)
        {
            return Min(source.Span);
        }

        public static float Min(this Span<float> source)
        {
            return Min((ReadOnlySpan<float>)source);
        }

        public static float Min(this ReadOnlySpan<float> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (float* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
        public static double Min(this double[] source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Length);

            fixed (double* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }

        public static double Min(this List<double> source)
        {
            Error.ThrowIfNull(source);
            Error.ThrowIfEmpty(source.Count);

            var span = SpanHelper.AsSpan(source);
            fixed (double* ptr = span)
            {
                MinCore(ptr, source.Count, out var result);
                return result;
            }
        }

        public static double Min(this Memory<double> source)
        {
            return Min((ReadOnlySpan<double>)source.Span);
        }

        public static double Min(this ReadOnlyMemory<double> source)
        {
            return Min(source.Span);
        }

        public static double Min(this Span<double> source)
        {
            return Min((ReadOnlySpan<double>)source);
        }

        public static double Min(this ReadOnlySpan<double> source)
        {
            Error.ThrowIfEmpty(source.IsEmpty);
            fixed (double* ptr = source)
            {
                MinCore(ptr, source.Length, out var result);
                return result;
            }
        }
    }
}