using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public static class RandomEnumerable
    {
        public static IEnumerable<byte> Repeat(byte min, byte max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (byte)random.NextInt(min, max);
            }
        }

        public static IEnumerable<sbyte> Repeat(sbyte min, sbyte max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (sbyte)random.NextInt(min, max);
            }
        }

        public static IEnumerable<short> Repeat(short min, short max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (short)random.NextInt(min, max);
            }
        }

        public static IEnumerable<ushort> Repeat(ushort min, ushort max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (ushort)random.NextInt(min, max);
            }
        }

        public static IEnumerable<uint> Repeat(uint min, uint max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt(min, max);
            }
        }

        public static IEnumerable<long> Repeat(long min, long max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt((int)min, (int)max);
            }
        }

        public static IEnumerable<ulong> Repeat(ulong min, ulong max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt((uint)min, (uint)max);
            }
        }

        public static IEnumerable<int> Repeat(int min, int max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt(min, max);
            }
        }

        public static IEnumerable<float> Repeat(float min, float max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextFloat(min, max);
            }
        }

        public static IEnumerable<double> Repeat(double min, double max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextDouble(min, max);
            }
        }

        public static void Fill(this Span<int> span, int min, int max)
        {
            for (int i = 0; i < span.Length; i++)
            {
                span[i] = Random.Range(min, max);
            }
        }
        
        public static void Fill(this Span<float> span, float min, float max)
        {
            for (int i = 0; i < span.Length; i++)
            {
                span[i] = Random.Range(min, max);
            }
        }
    }
}