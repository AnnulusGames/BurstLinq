using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static bool SequenceEqual(this byte[] first, byte[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (byte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this byte[] first, List<byte> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (byte* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this byte[] first, Memory<byte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<byte>)second.Span);
        }

        public static bool SequenceEqual(this byte[] first, ReadOnlyMemory<byte> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this byte[] first, Span<byte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<byte>)second);
        }

        public static bool SequenceEqual(this byte[] first, ReadOnlySpan<byte> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (byte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<byte> first, byte[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<byte> first, List<byte> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (byte* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<byte> first, Memory<byte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<byte>)second.Span);
        }

        public static bool SequenceEqual(this List<byte> first, ReadOnlyMemory<byte> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<byte> first, Span<byte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<byte>)second);
        }

        public static bool SequenceEqual(this List<byte> first, ReadOnlySpan<byte> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (byte* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<byte> first, Memory<byte> second)
        {
            return SequenceEqual((ReadOnlySpan<byte>)first.Span, (ReadOnlySpan<byte>)second.Span);
        }

        public static bool SequenceEqual(this Memory<byte> first, ReadOnlyMemory<byte> second)
        {
            return SequenceEqual((ReadOnlySpan<byte>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<byte> first, ReadOnlyMemory<byte> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<byte> first, Span<byte> second)
        {
            return SequenceEqual((ReadOnlySpan<byte>)first, (ReadOnlySpan<byte>)second);
        }

        public static bool SequenceEqual(this Span<byte> first, ReadOnlySpan<byte> second)
        {
            return SequenceEqual((ReadOnlySpan<byte>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<byte> first, ReadOnlySpan<byte> second)
        {
            if (first.Length != second.Length) return false;

            fixed (byte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this sbyte[] first, sbyte[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (sbyte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this sbyte[] first, List<sbyte> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (sbyte* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this sbyte[] first, Memory<sbyte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<sbyte>)second.Span);
        }

        public static bool SequenceEqual(this sbyte[] first, ReadOnlyMemory<sbyte> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this sbyte[] first, Span<sbyte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<sbyte>)second);
        }

        public static bool SequenceEqual(this sbyte[] first, ReadOnlySpan<sbyte> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (sbyte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<sbyte> first, sbyte[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<sbyte> first, List<sbyte> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (sbyte* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<sbyte> first, Memory<sbyte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<sbyte>)second.Span);
        }

        public static bool SequenceEqual(this List<sbyte> first, ReadOnlyMemory<sbyte> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<sbyte> first, Span<sbyte> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<sbyte>)second);
        }

        public static bool SequenceEqual(this List<sbyte> first, ReadOnlySpan<sbyte> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (sbyte* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<sbyte> first, Memory<sbyte> second)
        {
            return SequenceEqual((ReadOnlySpan<sbyte>)first.Span, (ReadOnlySpan<sbyte>)second.Span);
        }

        public static bool SequenceEqual(this Memory<sbyte> first, ReadOnlyMemory<sbyte> second)
        {
            return SequenceEqual((ReadOnlySpan<sbyte>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<sbyte> first, ReadOnlyMemory<sbyte> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<sbyte> first, Span<sbyte> second)
        {
            return SequenceEqual((ReadOnlySpan<sbyte>)first, (ReadOnlySpan<sbyte>)second);
        }

        public static bool SequenceEqual(this Span<sbyte> first, ReadOnlySpan<sbyte> second)
        {
            return SequenceEqual((ReadOnlySpan<sbyte>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<sbyte> first, ReadOnlySpan<sbyte> second)
        {
            if (first.Length != second.Length) return false;

            fixed (sbyte* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this short[] first, short[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (short* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this short[] first, List<short> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (short* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this short[] first, Memory<short> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<short>)second.Span);
        }

        public static bool SequenceEqual(this short[] first, ReadOnlyMemory<short> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this short[] first, Span<short> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<short>)second);
        }

        public static bool SequenceEqual(this short[] first, ReadOnlySpan<short> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (short* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<short> first, short[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<short> first, List<short> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (short* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<short> first, Memory<short> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<short>)second.Span);
        }

        public static bool SequenceEqual(this List<short> first, ReadOnlyMemory<short> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<short> first, Span<short> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<short>)second);
        }

        public static bool SequenceEqual(this List<short> first, ReadOnlySpan<short> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (short* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<short> first, Memory<short> second)
        {
            return SequenceEqual((ReadOnlySpan<short>)first.Span, (ReadOnlySpan<short>)second.Span);
        }

        public static bool SequenceEqual(this Memory<short> first, ReadOnlyMemory<short> second)
        {
            return SequenceEqual((ReadOnlySpan<short>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<short> first, ReadOnlyMemory<short> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<short> first, Span<short> second)
        {
            return SequenceEqual((ReadOnlySpan<short>)first, (ReadOnlySpan<short>)second);
        }

        public static bool SequenceEqual(this Span<short> first, ReadOnlySpan<short> second)
        {
            return SequenceEqual((ReadOnlySpan<short>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<short> first, ReadOnlySpan<short> second)
        {
            if (first.Length != second.Length) return false;

            fixed (short* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this ushort[] first, ushort[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (ushort* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this ushort[] first, List<ushort> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (ushort* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this ushort[] first, Memory<ushort> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ushort>)second.Span);
        }

        public static bool SequenceEqual(this ushort[] first, ReadOnlyMemory<ushort> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this ushort[] first, Span<ushort> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ushort>)second);
        }

        public static bool SequenceEqual(this ushort[] first, ReadOnlySpan<ushort> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (ushort* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<ushort> first, ushort[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<ushort> first, List<ushort> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (ushort* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<ushort> first, Memory<ushort> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ushort>)second.Span);
        }

        public static bool SequenceEqual(this List<ushort> first, ReadOnlyMemory<ushort> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<ushort> first, Span<ushort> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ushort>)second);
        }

        public static bool SequenceEqual(this List<ushort> first, ReadOnlySpan<ushort> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (ushort* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<ushort> first, Memory<ushort> second)
        {
            return SequenceEqual((ReadOnlySpan<ushort>)first.Span, (ReadOnlySpan<ushort>)second.Span);
        }

        public static bool SequenceEqual(this Memory<ushort> first, ReadOnlyMemory<ushort> second)
        {
            return SequenceEqual((ReadOnlySpan<ushort>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<ushort> first, ReadOnlyMemory<ushort> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<ushort> first, Span<ushort> second)
        {
            return SequenceEqual((ReadOnlySpan<ushort>)first, (ReadOnlySpan<ushort>)second);
        }

        public static bool SequenceEqual(this Span<ushort> first, ReadOnlySpan<ushort> second)
        {
            return SequenceEqual((ReadOnlySpan<ushort>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<ushort> first, ReadOnlySpan<ushort> second)
        {
            if (first.Length != second.Length) return false;

            fixed (ushort* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this int[] first, int[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;
            fixed (int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int[] first, List<int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int[] first, Memory<int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int>)second.Span);
        }

        public static bool SequenceEqual(this int[] first, ReadOnlyMemory<int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this int[] first, Span<int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int>)second);
        }

        public static bool SequenceEqual(this int[] first, ReadOnlySpan<int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<int> first, int[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<int> first, List<int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<int> first, Memory<int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int>)second.Span);
        }

        public static bool SequenceEqual(this List<int> first, ReadOnlyMemory<int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<int> first, Span<int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int>)second);
        }

        public static bool SequenceEqual(this List<int> first, ReadOnlySpan<int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (int* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<int> first, Memory<int> second)
        {
            return SequenceEqual((ReadOnlySpan<int>)first.Span, (ReadOnlySpan<int>)second.Span);
        }

        public static bool SequenceEqual(this Memory<int> first, ReadOnlyMemory<int> second)
        {
            return SequenceEqual((ReadOnlySpan<int>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<int> first, ReadOnlyMemory<int> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<int> first, Span<int> second)
        {
            return SequenceEqual((ReadOnlySpan<int>)first, (ReadOnlySpan<int>)second);
        }

        public static bool SequenceEqual(this Span<int> first, ReadOnlySpan<int> second)
        {
            return SequenceEqual((ReadOnlySpan<int>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<int> first, ReadOnlySpan<int> second)
        {
            if (first.Length != second.Length) return false;

            fixed (int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this uint[] first, uint[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (uint* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint[] first, List<uint> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint[] first, Memory<uint> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint>)second.Span);
        }

        public static bool SequenceEqual(this uint[] first, ReadOnlyMemory<uint> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this uint[] first, Span<uint> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint>)second);
        }

        public static bool SequenceEqual(this uint[] first, ReadOnlySpan<uint> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (uint* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<uint> first, uint[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<uint> first, List<uint> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<uint> first, Memory<uint> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint>)second.Span);
        }

        public static bool SequenceEqual(this List<uint> first, ReadOnlyMemory<uint> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<uint> first, Span<uint> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint>)second);
        }

        public static bool SequenceEqual(this List<uint> first, ReadOnlySpan<uint> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (uint* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<uint> first, Memory<uint> second)
        {
            return SequenceEqual((ReadOnlySpan<uint>)first.Span, (ReadOnlySpan<uint>)second.Span);
        }

        public static bool SequenceEqual(this Memory<uint> first, ReadOnlyMemory<uint> second)
        {
            return SequenceEqual((ReadOnlySpan<uint>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<uint> first, ReadOnlyMemory<uint> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<uint> first, Span<uint> second)
        {
            return SequenceEqual((ReadOnlySpan<uint>)first, (ReadOnlySpan<uint>)second);
        }

        public static bool SequenceEqual(this Span<uint> first, ReadOnlySpan<uint> second)
        {
            return SequenceEqual((ReadOnlySpan<uint>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<uint> first, ReadOnlySpan<uint> second)
        {
            if (first.Length != second.Length) return false;

            fixed (uint* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this long[] first, long[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (long* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this long[] first, List<long> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (long* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this long[] first, Memory<long> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<long>)second.Span);
        }

        public static bool SequenceEqual(this long[] first, ReadOnlyMemory<long> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this long[] first, Span<long> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<long>)second);
        }

        public static bool SequenceEqual(this long[] first, ReadOnlySpan<long> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (long* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<long> first, long[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<long> first, List<long> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (long* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<long> first, Memory<long> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<long>)second.Span);
        }

        public static bool SequenceEqual(this List<long> first, ReadOnlyMemory<long> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<long> first, Span<long> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<long>)second);
        }

        public static bool SequenceEqual(this List<long> first, ReadOnlySpan<long> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (long* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<long> first, Memory<long> second)
        {
            return SequenceEqual((ReadOnlySpan<long>)first.Span, (ReadOnlySpan<long>)second.Span);
        }

        public static bool SequenceEqual(this Memory<long> first, ReadOnlyMemory<long> second)
        {
            return SequenceEqual((ReadOnlySpan<long>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<long> first, ReadOnlyMemory<long> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<long> first, Span<long> second)
        {
            return SequenceEqual((ReadOnlySpan<long>)first, (ReadOnlySpan<long>)second);
        }

        public static bool SequenceEqual(this Span<long> first, ReadOnlySpan<long> second)
        {
            return SequenceEqual((ReadOnlySpan<long>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<long> first, ReadOnlySpan<long> second)
        {
            if (first.Length != second.Length) return false;

            fixed (long* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this ulong[] first, ulong[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (ulong* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this ulong[] first, List<ulong> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (ulong* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this ulong[] first, Memory<ulong> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ulong>)second.Span);
        }

        public static bool SequenceEqual(this ulong[] first, ReadOnlyMemory<ulong> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this ulong[] first, Span<ulong> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ulong>)second);
        }

        public static bool SequenceEqual(this ulong[] first, ReadOnlySpan<ulong> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (ulong* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<ulong> first, ulong[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<ulong> first, List<ulong> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (ulong* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<ulong> first, Memory<ulong> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ulong>)second.Span);
        }

        public static bool SequenceEqual(this List<ulong> first, ReadOnlyMemory<ulong> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<ulong> first, Span<ulong> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<ulong>)second);
        }

        public static bool SequenceEqual(this List<ulong> first, ReadOnlySpan<ulong> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (ulong* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<ulong> first, Memory<ulong> second)
        {
            return SequenceEqual((ReadOnlySpan<ulong>)first.Span, (ReadOnlySpan<ulong>)second.Span);
        }

        public static bool SequenceEqual(this Memory<ulong> first, ReadOnlyMemory<ulong> second)
        {
            return SequenceEqual((ReadOnlySpan<ulong>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<ulong> first, ReadOnlyMemory<ulong> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<ulong> first, Span<ulong> second)
        {
            return SequenceEqual((ReadOnlySpan<ulong>)first, (ReadOnlySpan<ulong>)second);
        }

        public static bool SequenceEqual(this Span<ulong> first, ReadOnlySpan<ulong> second)
        {
            return SequenceEqual((ReadOnlySpan<ulong>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<ulong> first, ReadOnlySpan<ulong> second)
        {
            if (first.Length != second.Length) return false;

            fixed (ulong* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this float[] first, float[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (float* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float[] first, List<float> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float[] first, Memory<float> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float>)second.Span);
        }

        public static bool SequenceEqual(this float[] first, ReadOnlyMemory<float> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this float[] first, Span<float> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float>)second);
        }

        public static bool SequenceEqual(this float[] first, ReadOnlySpan<float> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (float* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<float> first, float[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<float> first, List<float> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<float> first, Memory<float> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float>)second.Span);
        }

        public static bool SequenceEqual(this List<float> first, ReadOnlyMemory<float> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<float> first, Span<float> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float>)second);
        }

        public static bool SequenceEqual(this List<float> first, ReadOnlySpan<float> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (float* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<float> first, Memory<float> second)
        {
            return SequenceEqual((ReadOnlySpan<float>)first.Span, (ReadOnlySpan<float>)second.Span);
        }

        public static bool SequenceEqual(this Memory<float> first, ReadOnlyMemory<float> second)
        {
            return SequenceEqual((ReadOnlySpan<float>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<float> first, ReadOnlyMemory<float> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<float> first, Span<float> second)
        {
            return SequenceEqual((ReadOnlySpan<float>)first, (ReadOnlySpan<float>)second);
        }

        public static bool SequenceEqual(this Span<float> first, ReadOnlySpan<float> second)
        {
            return SequenceEqual((ReadOnlySpan<float>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<float> first, ReadOnlySpan<float> second)
        {
            if (first.Length != second.Length) return false;

            fixed (float* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this double[] first, double[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (double* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double[] first, List<double> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double[] first, Memory<double> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double>)second.Span);
        }

        public static bool SequenceEqual(this double[] first, ReadOnlyMemory<double> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this double[] first, Span<double> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double>)second);
        }

        public static bool SequenceEqual(this double[] first, ReadOnlySpan<double> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (double* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<double> first, double[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<double> first, List<double> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<double> first, Memory<double> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double>)second.Span);
        }

        public static bool SequenceEqual(this List<double> first, ReadOnlyMemory<double> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<double> first, Span<double> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double>)second);
        }

        public static bool SequenceEqual(this List<double> first, ReadOnlySpan<double> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (double* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<double> first, Memory<double> second)
        {
            return SequenceEqual((ReadOnlySpan<double>)first.Span, (ReadOnlySpan<double>)second.Span);
        }

        public static bool SequenceEqual(this Memory<double> first, ReadOnlyMemory<double> second)
        {
            return SequenceEqual((ReadOnlySpan<double>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<double> first, ReadOnlyMemory<double> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<double> first, Span<double> second)
        {
            return SequenceEqual((ReadOnlySpan<double>)first, (ReadOnlySpan<double>)second);
        }

        public static bool SequenceEqual(this Span<double> first, ReadOnlySpan<double> second)
        {
            return SequenceEqual((ReadOnlySpan<double>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<double> first, ReadOnlySpan<double> second)
        {
            if (first.Length != second.Length) return false;

            fixed (double* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this Vector2[] first, Vector2[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (Vector2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector2[] first, List<Vector2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector2* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector2[] first, Memory<Vector2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2>)second.Span);
        }

        public static bool SequenceEqual(this Vector2[] first, ReadOnlyMemory<Vector2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this Vector2[] first, Span<Vector2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2>)second);
        }

        public static bool SequenceEqual(this Vector2[] first, ReadOnlySpan<Vector2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (Vector2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<Vector2> first, Vector2[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<Vector2> first, List<Vector2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector2* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<Vector2> first, Memory<Vector2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2>)second.Span);
        }

        public static bool SequenceEqual(this List<Vector2> first, ReadOnlyMemory<Vector2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<Vector2> first, Span<Vector2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2>)second);
        }

        public static bool SequenceEqual(this List<Vector2> first, ReadOnlySpan<Vector2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (Vector2* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<Vector2> first, Memory<Vector2> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2>)first.Span, (ReadOnlySpan<Vector2>)second.Span);
        }

        public static bool SequenceEqual(this Memory<Vector2> first, ReadOnlyMemory<Vector2> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<Vector2> first, ReadOnlyMemory<Vector2> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<Vector2> first, Span<Vector2> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2>)first, (ReadOnlySpan<Vector2>)second);
        }

        public static bool SequenceEqual(this Span<Vector2> first, ReadOnlySpan<Vector2> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<Vector2> first, ReadOnlySpan<Vector2> second)
        {
            if (first.Length != second.Length) return false;

            fixed (Vector2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this Vector2Int[] first, Vector2Int[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (Vector2Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector2Int[] first, List<Vector2Int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector2Int* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector2Int[] first, Memory<Vector2Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2Int>)second.Span);
        }

        public static bool SequenceEqual(this Vector2Int[] first, ReadOnlyMemory<Vector2Int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this Vector2Int[] first, Span<Vector2Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2Int>)second);
        }

        public static bool SequenceEqual(this Vector2Int[] first, ReadOnlySpan<Vector2Int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (Vector2Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<Vector2Int> first, Vector2Int[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<Vector2Int> first, List<Vector2Int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector2Int* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<Vector2Int> first, Memory<Vector2Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2Int>)second.Span);
        }

        public static bool SequenceEqual(this List<Vector2Int> first, ReadOnlyMemory<Vector2Int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<Vector2Int> first, Span<Vector2Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector2Int>)second);
        }

        public static bool SequenceEqual(this List<Vector2Int> first, ReadOnlySpan<Vector2Int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (Vector2Int* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<Vector2Int> first, Memory<Vector2Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2Int>)first.Span, (ReadOnlySpan<Vector2Int>)second.Span);
        }

        public static bool SequenceEqual(this Memory<Vector2Int> first, ReadOnlyMemory<Vector2Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2Int>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<Vector2Int> first, ReadOnlyMemory<Vector2Int> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<Vector2Int> first, Span<Vector2Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2Int>)first, (ReadOnlySpan<Vector2Int>)second);
        }

        public static bool SequenceEqual(this Span<Vector2Int> first, ReadOnlySpan<Vector2Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector2Int>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<Vector2Int> first, ReadOnlySpan<Vector2Int> second)
        {
            if (first.Length != second.Length) return false;

            fixed (Vector2Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this Vector3[] first, Vector3[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (Vector3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector3[] first, List<Vector3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector3* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector3[] first, Memory<Vector3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3>)second.Span);
        }

        public static bool SequenceEqual(this Vector3[] first, ReadOnlyMemory<Vector3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this Vector3[] first, Span<Vector3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3>)second);
        }

        public static bool SequenceEqual(this Vector3[] first, ReadOnlySpan<Vector3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (Vector3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<Vector3> first, Vector3[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<Vector3> first, List<Vector3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector3* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<Vector3> first, Memory<Vector3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3>)second.Span);
        }

        public static bool SequenceEqual(this List<Vector3> first, ReadOnlyMemory<Vector3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<Vector3> first, Span<Vector3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3>)second);
        }

        public static bool SequenceEqual(this List<Vector3> first, ReadOnlySpan<Vector3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (Vector3* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<Vector3> first, Memory<Vector3> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3>)first.Span, (ReadOnlySpan<Vector3>)second.Span);
        }

        public static bool SequenceEqual(this Memory<Vector3> first, ReadOnlyMemory<Vector3> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<Vector3> first, ReadOnlyMemory<Vector3> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<Vector3> first, Span<Vector3> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3>)first, (ReadOnlySpan<Vector3>)second);
        }

        public static bool SequenceEqual(this Span<Vector3> first, ReadOnlySpan<Vector3> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<Vector3> first, ReadOnlySpan<Vector3> second)
        {
            if (first.Length != second.Length) return false;

            fixed (Vector3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this Vector3Int[] first, Vector3Int[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (Vector3Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector3Int[] first, List<Vector3Int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector3Int* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector3Int[] first, Memory<Vector3Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3Int>)second.Span);
        }

        public static bool SequenceEqual(this Vector3Int[] first, ReadOnlyMemory<Vector3Int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this Vector3Int[] first, Span<Vector3Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3Int>)second);
        }

        public static bool SequenceEqual(this Vector3Int[] first, ReadOnlySpan<Vector3Int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (Vector3Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<Vector3Int> first, Vector3Int[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<Vector3Int> first, List<Vector3Int> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector3Int* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<Vector3Int> first, Memory<Vector3Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3Int>)second.Span);
        }

        public static bool SequenceEqual(this List<Vector3Int> first, ReadOnlyMemory<Vector3Int> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<Vector3Int> first, Span<Vector3Int> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector3Int>)second);
        }

        public static bool SequenceEqual(this List<Vector3Int> first, ReadOnlySpan<Vector3Int> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (Vector3Int* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<Vector3Int> first, Memory<Vector3Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3Int>)first.Span, (ReadOnlySpan<Vector3Int>)second.Span);
        }

        public static bool SequenceEqual(this Memory<Vector3Int> first, ReadOnlyMemory<Vector3Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3Int>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<Vector3Int> first, ReadOnlyMemory<Vector3Int> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<Vector3Int> first, Span<Vector3Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3Int>)first, (ReadOnlySpan<Vector3Int>)second);
        }

        public static bool SequenceEqual(this Span<Vector3Int> first, ReadOnlySpan<Vector3Int> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector3Int>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<Vector3Int> first, ReadOnlySpan<Vector3Int> second)
        {
            if (first.Length != second.Length) return false;

            fixed (Vector3Int* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this Vector4[] first, Vector4[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (Vector4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector4[] first, List<Vector4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector4* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this Vector4[] first, Memory<Vector4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector4>)second.Span);
        }

        public static bool SequenceEqual(this Vector4[] first, ReadOnlyMemory<Vector4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this Vector4[] first, Span<Vector4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector4>)second);
        }

        public static bool SequenceEqual(this Vector4[] first, ReadOnlySpan<Vector4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (Vector4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<Vector4> first, Vector4[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<Vector4> first, List<Vector4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (Vector4* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<Vector4> first, Memory<Vector4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector4>)second.Span);
        }

        public static bool SequenceEqual(this List<Vector4> first, ReadOnlyMemory<Vector4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<Vector4> first, Span<Vector4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<Vector4>)second);
        }

        public static bool SequenceEqual(this List<Vector4> first, ReadOnlySpan<Vector4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (Vector4* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<Vector4> first, Memory<Vector4> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector4>)first.Span, (ReadOnlySpan<Vector4>)second.Span);
        }

        public static bool SequenceEqual(this Memory<Vector4> first, ReadOnlyMemory<Vector4> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector4>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<Vector4> first, ReadOnlyMemory<Vector4> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<Vector4> first, Span<Vector4> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector4>)first, (ReadOnlySpan<Vector4>)second);
        }

        public static bool SequenceEqual(this Span<Vector4> first, ReadOnlySpan<Vector4> second)
        {
            return SequenceEqual((ReadOnlySpan<Vector4>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<Vector4> first, ReadOnlySpan<Vector4> second)
        {
            if (first.Length != second.Length) return false;

            fixed (Vector4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this int2[] first, int2[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (int2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int2[] first, List<int2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int2* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int2[] first, Memory<int2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int2>)second.Span);
        }

        public static bool SequenceEqual(this int2[] first, ReadOnlyMemory<int2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this int2[] first, Span<int2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int2>)second);
        }

        public static bool SequenceEqual(this int2[] first, ReadOnlySpan<int2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (int2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<int2> first, int2[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<int2> first, List<int2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int2* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<int2> first, Memory<int2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int2>)second.Span);
        }

        public static bool SequenceEqual(this List<int2> first, ReadOnlyMemory<int2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<int2> first, Span<int2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int2>)second);
        }

        public static bool SequenceEqual(this List<int2> first, ReadOnlySpan<int2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (int2* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<int2> first, Memory<int2> second)
        {
            return SequenceEqual((ReadOnlySpan<int2>)first.Span, (ReadOnlySpan<int2>)second.Span);
        }

        public static bool SequenceEqual(this Memory<int2> first, ReadOnlyMemory<int2> second)
        {
            return SequenceEqual((ReadOnlySpan<int2>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<int2> first, ReadOnlyMemory<int2> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<int2> first, Span<int2> second)
        {
            return SequenceEqual((ReadOnlySpan<int2>)first, (ReadOnlySpan<int2>)second);
        }

        public static bool SequenceEqual(this Span<int2> first, ReadOnlySpan<int2> second)
        {
            return SequenceEqual((ReadOnlySpan<int2>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<int2> first, ReadOnlySpan<int2> second)
        {
            if (first.Length != second.Length) return false;

            fixed (int2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this int3[] first, int3[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (int3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int3[] first, List<int3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int3* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int3[] first, Memory<int3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int3>)second.Span);
        }

        public static bool SequenceEqual(this int3[] first, ReadOnlyMemory<int3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this int3[] first, Span<int3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int3>)second);
        }

        public static bool SequenceEqual(this int3[] first, ReadOnlySpan<int3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (int3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<int3> first, int3[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<int3> first, List<int3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int3* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<int3> first, Memory<int3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int3>)second.Span);
        }

        public static bool SequenceEqual(this List<int3> first, ReadOnlyMemory<int3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<int3> first, Span<int3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int3>)second);
        }

        public static bool SequenceEqual(this List<int3> first, ReadOnlySpan<int3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (int3* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<int3> first, Memory<int3> second)
        {
            return SequenceEqual((ReadOnlySpan<int3>)first.Span, (ReadOnlySpan<int3>)second.Span);
        }

        public static bool SequenceEqual(this Memory<int3> first, ReadOnlyMemory<int3> second)
        {
            return SequenceEqual((ReadOnlySpan<int3>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<int3> first, ReadOnlyMemory<int3> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<int3> first, Span<int3> second)
        {
            return SequenceEqual((ReadOnlySpan<int3>)first, (ReadOnlySpan<int3>)second);
        }

        public static bool SequenceEqual(this Span<int3> first, ReadOnlySpan<int3> second)
        {
            return SequenceEqual((ReadOnlySpan<int3>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<int3> first, ReadOnlySpan<int3> second)
        {
            if (first.Length != second.Length) return false;

            fixed (int3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this int4[] first, int4[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (int4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int4[] first, List<int4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int4* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this int4[] first, Memory<int4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int4>)second.Span);
        }

        public static bool SequenceEqual(this int4[] first, ReadOnlyMemory<int4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this int4[] first, Span<int4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int4>)second);
        }

        public static bool SequenceEqual(this int4[] first, ReadOnlySpan<int4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (int4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<int4> first, int4[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<int4> first, List<int4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (int4* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<int4> first, Memory<int4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int4>)second.Span);
        }

        public static bool SequenceEqual(this List<int4> first, ReadOnlyMemory<int4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<int4> first, Span<int4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<int4>)second);
        }

        public static bool SequenceEqual(this List<int4> first, ReadOnlySpan<int4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (int4* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<int4> first, Memory<int4> second)
        {
            return SequenceEqual((ReadOnlySpan<int4>)first.Span, (ReadOnlySpan<int4>)second.Span);
        }

        public static bool SequenceEqual(this Memory<int4> first, ReadOnlyMemory<int4> second)
        {
            return SequenceEqual((ReadOnlySpan<int4>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<int4> first, ReadOnlyMemory<int4> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<int4> first, Span<int4> second)
        {
            return SequenceEqual((ReadOnlySpan<int4>)first, (ReadOnlySpan<int4>)second);
        }

        public static bool SequenceEqual(this Span<int4> first, ReadOnlySpan<int4> second)
        {
            return SequenceEqual((ReadOnlySpan<int4>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<int4> first, ReadOnlySpan<int4> second)
        {
            if (first.Length != second.Length) return false;

            fixed (int4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this uint2[] first, uint2[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (uint2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint2[] first, List<uint2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint2* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint2[] first, Memory<uint2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint2>)second.Span);
        }

        public static bool SequenceEqual(this uint2[] first, ReadOnlyMemory<uint2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this uint2[] first, Span<uint2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint2>)second);
        }

        public static bool SequenceEqual(this uint2[] first, ReadOnlySpan<uint2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (uint2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<uint2> first, uint2[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<uint2> first, List<uint2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint2* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<uint2> first, Memory<uint2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint2>)second.Span);
        }

        public static bool SequenceEqual(this List<uint2> first, ReadOnlyMemory<uint2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<uint2> first, Span<uint2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint2>)second);
        }

        public static bool SequenceEqual(this List<uint2> first, ReadOnlySpan<uint2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (uint2* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<uint2> first, Memory<uint2> second)
        {
            return SequenceEqual((ReadOnlySpan<uint2>)first.Span, (ReadOnlySpan<uint2>)second.Span);
        }

        public static bool SequenceEqual(this Memory<uint2> first, ReadOnlyMemory<uint2> second)
        {
            return SequenceEqual((ReadOnlySpan<uint2>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<uint2> first, ReadOnlyMemory<uint2> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<uint2> first, Span<uint2> second)
        {
            return SequenceEqual((ReadOnlySpan<uint2>)first, (ReadOnlySpan<uint2>)second);
        }

        public static bool SequenceEqual(this Span<uint2> first, ReadOnlySpan<uint2> second)
        {
            return SequenceEqual((ReadOnlySpan<uint2>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<uint2> first, ReadOnlySpan<uint2> second)
        {
            if (first.Length != second.Length) return false;

            fixed (uint2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this uint3[] first, uint3[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (uint3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint3[] first, List<uint3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint3* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint3[] first, Memory<uint3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint3>)second.Span);
        }

        public static bool SequenceEqual(this uint3[] first, ReadOnlyMemory<uint3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this uint3[] first, Span<uint3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint3>)second);
        }

        public static bool SequenceEqual(this uint3[] first, ReadOnlySpan<uint3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (uint3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<uint3> first, uint3[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<uint3> first, List<uint3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint3* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<uint3> first, Memory<uint3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint3>)second.Span);
        }

        public static bool SequenceEqual(this List<uint3> first, ReadOnlyMemory<uint3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<uint3> first, Span<uint3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint3>)second);
        }

        public static bool SequenceEqual(this List<uint3> first, ReadOnlySpan<uint3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (uint3* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<uint3> first, Memory<uint3> second)
        {
            return SequenceEqual((ReadOnlySpan<uint3>)first.Span, (ReadOnlySpan<uint3>)second.Span);
        }

        public static bool SequenceEqual(this Memory<uint3> first, ReadOnlyMemory<uint3> second)
        {
            return SequenceEqual((ReadOnlySpan<uint3>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<uint3> first, ReadOnlyMemory<uint3> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<uint3> first, Span<uint3> second)
        {
            return SequenceEqual((ReadOnlySpan<uint3>)first, (ReadOnlySpan<uint3>)second);
        }

        public static bool SequenceEqual(this Span<uint3> first, ReadOnlySpan<uint3> second)
        {
            return SequenceEqual((ReadOnlySpan<uint3>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<uint3> first, ReadOnlySpan<uint3> second)
        {
            if (first.Length != second.Length) return false;

            fixed (uint3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this uint4[] first, uint4[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (uint4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint4[] first, List<uint4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint4* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this uint4[] first, Memory<uint4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint4>)second.Span);
        }

        public static bool SequenceEqual(this uint4[] first, ReadOnlyMemory<uint4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this uint4[] first, Span<uint4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint4>)second);
        }

        public static bool SequenceEqual(this uint4[] first, ReadOnlySpan<uint4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (uint4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<uint4> first, uint4[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<uint4> first, List<uint4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (uint4* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<uint4> first, Memory<uint4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint4>)second.Span);
        }

        public static bool SequenceEqual(this List<uint4> first, ReadOnlyMemory<uint4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<uint4> first, Span<uint4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<uint4>)second);
        }

        public static bool SequenceEqual(this List<uint4> first, ReadOnlySpan<uint4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (uint4* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<uint4> first, Memory<uint4> second)
        {
            return SequenceEqual((ReadOnlySpan<uint4>)first.Span, (ReadOnlySpan<uint4>)second.Span);
        }

        public static bool SequenceEqual(this Memory<uint4> first, ReadOnlyMemory<uint4> second)
        {
            return SequenceEqual((ReadOnlySpan<uint4>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<uint4> first, ReadOnlyMemory<uint4> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<uint4> first, Span<uint4> second)
        {
            return SequenceEqual((ReadOnlySpan<uint4>)first, (ReadOnlySpan<uint4>)second);
        }

        public static bool SequenceEqual(this Span<uint4> first, ReadOnlySpan<uint4> second)
        {
            return SequenceEqual((ReadOnlySpan<uint4>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<uint4> first, ReadOnlySpan<uint4> second)
        {
            if (first.Length != second.Length) return false;

            fixed (uint4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this float2[] first, float2[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (float2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float2[] first, List<float2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float2* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float2[] first, Memory<float2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float2>)second.Span);
        }

        public static bool SequenceEqual(this float2[] first, ReadOnlyMemory<float2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this float2[] first, Span<float2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float2>)second);
        }

        public static bool SequenceEqual(this float2[] first, ReadOnlySpan<float2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (float2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<float2> first, float2[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<float2> first, List<float2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float2* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<float2> first, Memory<float2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float2>)second.Span);
        }

        public static bool SequenceEqual(this List<float2> first, ReadOnlyMemory<float2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<float2> first, Span<float2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float2>)second);
        }

        public static bool SequenceEqual(this List<float2> first, ReadOnlySpan<float2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (float2* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<float2> first, Memory<float2> second)
        {
            return SequenceEqual((ReadOnlySpan<float2>)first.Span, (ReadOnlySpan<float2>)second.Span);
        }

        public static bool SequenceEqual(this Memory<float2> first, ReadOnlyMemory<float2> second)
        {
            return SequenceEqual((ReadOnlySpan<float2>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<float2> first, ReadOnlyMemory<float2> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<float2> first, Span<float2> second)
        {
            return SequenceEqual((ReadOnlySpan<float2>)first, (ReadOnlySpan<float2>)second);
        }

        public static bool SequenceEqual(this Span<float2> first, ReadOnlySpan<float2> second)
        {
            return SequenceEqual((ReadOnlySpan<float2>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<float2> first, ReadOnlySpan<float2> second)
        {
            if (first.Length != second.Length) return false;

            fixed (float2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this float3[] first, float3[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (float3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float3[] first, List<float3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float3* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float3[] first, Memory<float3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float3>)second.Span);
        }

        public static bool SequenceEqual(this float3[] first, ReadOnlyMemory<float3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this float3[] first, Span<float3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float3>)second);
        }

        public static bool SequenceEqual(this float3[] first, ReadOnlySpan<float3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (float3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<float3> first, float3[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<float3> first, List<float3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float3* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<float3> first, Memory<float3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float3>)second.Span);
        }

        public static bool SequenceEqual(this List<float3> first, ReadOnlyMemory<float3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<float3> first, Span<float3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float3>)second);
        }

        public static bool SequenceEqual(this List<float3> first, ReadOnlySpan<float3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (float3* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<float3> first, Memory<float3> second)
        {
            return SequenceEqual((ReadOnlySpan<float3>)first.Span, (ReadOnlySpan<float3>)second.Span);
        }

        public static bool SequenceEqual(this Memory<float3> first, ReadOnlyMemory<float3> second)
        {
            return SequenceEqual((ReadOnlySpan<float3>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<float3> first, ReadOnlyMemory<float3> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<float3> first, Span<float3> second)
        {
            return SequenceEqual((ReadOnlySpan<float3>)first, (ReadOnlySpan<float3>)second);
        }

        public static bool SequenceEqual(this Span<float3> first, ReadOnlySpan<float3> second)
        {
            return SequenceEqual((ReadOnlySpan<float3>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<float3> first, ReadOnlySpan<float3> second)
        {
            if (first.Length != second.Length) return false;

            fixed (float3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this float4[] first, float4[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (float4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float4[] first, List<float4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float4* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this float4[] first, Memory<float4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float4>)second.Span);
        }

        public static bool SequenceEqual(this float4[] first, ReadOnlyMemory<float4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this float4[] first, Span<float4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float4>)second);
        }

        public static bool SequenceEqual(this float4[] first, ReadOnlySpan<float4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (float4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<float4> first, float4[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<float4> first, List<float4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (float4* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<float4> first, Memory<float4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float4>)second.Span);
        }

        public static bool SequenceEqual(this List<float4> first, ReadOnlyMemory<float4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<float4> first, Span<float4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<float4>)second);
        }

        public static bool SequenceEqual(this List<float4> first, ReadOnlySpan<float4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (float4* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<float4> first, Memory<float4> second)
        {
            return SequenceEqual((ReadOnlySpan<float4>)first.Span, (ReadOnlySpan<float4>)second.Span);
        }

        public static bool SequenceEqual(this Memory<float4> first, ReadOnlyMemory<float4> second)
        {
            return SequenceEqual((ReadOnlySpan<float4>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<float4> first, ReadOnlyMemory<float4> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<float4> first, Span<float4> second)
        {
            return SequenceEqual((ReadOnlySpan<float4>)first, (ReadOnlySpan<float4>)second);
        }

        public static bool SequenceEqual(this Span<float4> first, ReadOnlySpan<float4> second)
        {
            return SequenceEqual((ReadOnlySpan<float4>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<float4> first, ReadOnlySpan<float4> second)
        {
            if (first.Length != second.Length) return false;

            fixed (float4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this double2[] first, double2[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (double2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double2[] first, List<double2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double2* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double2[] first, Memory<double2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double2>)second.Span);
        }

        public static bool SequenceEqual(this double2[] first, ReadOnlyMemory<double2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this double2[] first, Span<double2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double2>)second);
        }

        public static bool SequenceEqual(this double2[] first, ReadOnlySpan<double2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (double2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<double2> first, double2[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<double2> first, List<double2> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double2* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<double2> first, Memory<double2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double2>)second.Span);
        }

        public static bool SequenceEqual(this List<double2> first, ReadOnlyMemory<double2> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<double2> first, Span<double2> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double2>)second);
        }

        public static bool SequenceEqual(this List<double2> first, ReadOnlySpan<double2> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (double2* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<double2> first, Memory<double2> second)
        {
            return SequenceEqual((ReadOnlySpan<double2>)first.Span, (ReadOnlySpan<double2>)second.Span);
        }

        public static bool SequenceEqual(this Memory<double2> first, ReadOnlyMemory<double2> second)
        {
            return SequenceEqual((ReadOnlySpan<double2>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<double2> first, ReadOnlyMemory<double2> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<double2> first, Span<double2> second)
        {
            return SequenceEqual((ReadOnlySpan<double2>)first, (ReadOnlySpan<double2>)second);
        }

        public static bool SequenceEqual(this Span<double2> first, ReadOnlySpan<double2> second)
        {
            return SequenceEqual((ReadOnlySpan<double2>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<double2> first, ReadOnlySpan<double2> second)
        {
            if (first.Length != second.Length) return false;

            fixed (double2* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this double3[] first, double3[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (double3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double3[] first, List<double3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double3* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double3[] first, Memory<double3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double3>)second.Span);
        }

        public static bool SequenceEqual(this double3[] first, ReadOnlyMemory<double3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this double3[] first, Span<double3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double3>)second);
        }

        public static bool SequenceEqual(this double3[] first, ReadOnlySpan<double3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (double3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<double3> first, double3[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<double3> first, List<double3> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double3* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<double3> first, Memory<double3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double3>)second.Span);
        }

        public static bool SequenceEqual(this List<double3> first, ReadOnlyMemory<double3> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<double3> first, Span<double3> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double3>)second);
        }

        public static bool SequenceEqual(this List<double3> first, ReadOnlySpan<double3> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (double3* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<double3> first, Memory<double3> second)
        {
            return SequenceEqual((ReadOnlySpan<double3>)first.Span, (ReadOnlySpan<double3>)second.Span);
        }

        public static bool SequenceEqual(this Memory<double3> first, ReadOnlyMemory<double3> second)
        {
            return SequenceEqual((ReadOnlySpan<double3>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<double3> first, ReadOnlyMemory<double3> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<double3> first, Span<double3> second)
        {
            return SequenceEqual((ReadOnlySpan<double3>)first, (ReadOnlySpan<double3>)second);
        }

        public static bool SequenceEqual(this Span<double3> first, ReadOnlySpan<double3> second)
        {
            return SequenceEqual((ReadOnlySpan<double3>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<double3> first, ReadOnlySpan<double3> second)
        {
            if (first.Length != second.Length) return false;

            fixed (double3* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
        public static bool SequenceEqual(this double4[] first, double4[] second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Length != second.Length) return false;

            fixed (double4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double4[] first, List<double4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first.Length != second.Count) return false;

            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double4* firstPtr = first, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this double4[] first, Memory<double4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double4>)second.Span);
        }

        public static bool SequenceEqual(this double4[] first, ReadOnlyMemory<double4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this double4[] first, Span<double4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double4>)second);
        }

        public static bool SequenceEqual(this double4[] first, ReadOnlySpan<double4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Length != second.Length) return false;

            fixed (double4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }

        public static bool SequenceEqual(this List<double4> first, double4[] second)
        {
            return SequenceEqual(second, first);
        }

        public static bool SequenceEqual(this List<double4> first, List<double4> second)
        {
            Error.ThrowIfNull(first);
            Error.ThrowIfNull(second);

            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            var secondSpan = SpanHelper.AsSpan(second);
            fixed (double4* firstPtr = firstSpan, secondPtr = secondSpan)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this List<double4> first, Memory<double4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double4>)second.Span);
        }

        public static bool SequenceEqual(this List<double4> first, ReadOnlyMemory<double4> second)
        {
            return SequenceEqual(first, second.Span);
        }

        public static bool SequenceEqual(this List<double4> first, Span<double4> second)
        {
            return SequenceEqual(first, (ReadOnlySpan<double4>)second);
        }

        public static bool SequenceEqual(this List<double4> first, ReadOnlySpan<double4> second)
        {
            Error.ThrowIfNull(first);

            if (first.Count != second.Length) return false;

            var firstSpan = SpanHelper.AsSpan(first);
            fixed (double4* firstPtr = firstSpan, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Count);
            }
        }

        public static bool SequenceEqual(this Memory<double4> first, Memory<double4> second)
        {
            return SequenceEqual((ReadOnlySpan<double4>)first.Span, (ReadOnlySpan<double4>)second.Span);
        }

        public static bool SequenceEqual(this Memory<double4> first, ReadOnlyMemory<double4> second)
        {
            return SequenceEqual((ReadOnlySpan<double4>)first.Span, second.Span);
        }

        public static bool SequenceEqual(this ReadOnlyMemory<double4> first, ReadOnlyMemory<double4> second)
        {
            return SequenceEqual(first.Span, second.Span);
        }

        public static bool SequenceEqual(this Span<double4> first, Span<double4> second)
        {
            return SequenceEqual((ReadOnlySpan<double4>)first, (ReadOnlySpan<double4>)second);
        }

        public static bool SequenceEqual(this Span<double4> first, ReadOnlySpan<double4> second)
        {
            return SequenceEqual((ReadOnlySpan<double4>)first, second);
        }

        public static bool SequenceEqual(this ReadOnlySpan<double4> first, ReadOnlySpan<double4> second)
        {
            if (first.Length != second.Length) return false;

            fixed (double4* firstPtr = first, secondPtr = second)
            {
                return SequenceEqualCore(firstPtr, secondPtr, first.Length);
            }
        }
    }
}