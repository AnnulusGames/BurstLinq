using System;
using System.Collections.Generic;
using Unity.Mathematics;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public static class RandomEnumerable
    {
        public static IEnumerable<byte> RepeatByte(byte min, byte max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (byte)random.NextInt(min, max);
            }
        }

        public static IEnumerable<sbyte> RepeatSByte(sbyte min, sbyte max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (sbyte)random.NextInt(min, max);
            }
        }

        public static IEnumerable<short> RepeatShort(short min, short max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (short)random.NextInt(min, max);
            }
        }

        public static IEnumerable<ushort> RepeatUShort(ushort min, ushort max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return (ushort)random.NextInt(min, max);
            }
        }

        public static IEnumerable<uint> RepeatUInt(uint min, uint max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt(min, max);
            }
        }

        public static IEnumerable<long> RepeatLong(long min, long max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt((int)min, (int)max);
            }
        }

        public static IEnumerable<ulong> RepeatULong(ulong min, ulong max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt((uint)min, (uint)max);
            }
        }

        public static IEnumerable<int> RepeatInt(int min, int max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt(min, max);
            }
        }

        public static IEnumerable<float> RepeatFloat(float min, float max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextFloat(min, max);
            }
        }

        public static IEnumerable<float2> RepeatFloat2(float2 min, float2 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextFloat2(min, max);
            }
        }

        public static IEnumerable<float3> RepeatFloat3(float3 min, float3 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextFloat3(min, max);
            }
        }

        public static IEnumerable<float4> RepeatFloat4(float4 min, float4 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextFloat4(min, max);
            }
        }

        public static IEnumerable<double> RepeatDouble(double min, double max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextDouble(min, max);
            }
        }

        public static IEnumerable<double2> RepeatDouble2(double2 min, double2 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextDouble2(min, max);
            }
        }

        public static IEnumerable<double3> RepeatDouble3(double3 min, double3 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextDouble3(min, max);
            }
        }

        public static IEnumerable<double4> RepeatDouble4(double4 min, double4 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextDouble4(min, max);
            }
        }
    }
}