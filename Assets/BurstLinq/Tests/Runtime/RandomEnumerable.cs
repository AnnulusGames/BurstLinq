using System;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public static class RandomEnumerable
    {

        public static IEnumerable<Vector2> RepeatVector2(float min, float max, int count)
        {
            var minVector = new Vector2(min, min);
            var maxVector = new Vector2(max, max);
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat2(UnsafeUtility.As<Vector2, float2>(ref minVector), UnsafeUtility.As<Vector2, float2>(ref maxVector));
                yield return UnsafeUtility.As<float2, Vector2>(ref value);
            }
        }

        public static IEnumerable<Vector2> RepeatVector2(Vector2 min, Vector2 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat2(UnsafeUtility.As<Vector2, float2>(ref min), UnsafeUtility.As<Vector2, float2>(ref max));
                yield return UnsafeUtility.As<float2, Vector2>(ref value);
            }
        }

        public static IEnumerable<Vector3> RepeatVector3(float min, float max, int count)
        {
            var minVector = new Vector3(min, min, min);
            var maxVector = new Vector3(max, max, max);
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat3(UnsafeUtility.As<Vector3, float3>(ref minVector), UnsafeUtility.As<Vector3, float3>(ref maxVector));
                yield return UnsafeUtility.As<float3, Vector3>(ref value);
            }
        }

        public static IEnumerable<Vector3> RepeatVector3(Vector3 min, Vector3 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat3(UnsafeUtility.As<Vector3, float3>(ref min), UnsafeUtility.As<Vector3, float3>(ref max));
                yield return UnsafeUtility.As<float3, Vector3>(ref value);
            }
        }

        public static IEnumerable<Vector4> RepeatVector4(float min, float max, int count)
        {
            var minVector = new Vector4(min, min, min, min);
            var maxVector = new Vector4(max, max, max, max);
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat4(UnsafeUtility.As<Vector4, float4>(ref minVector), UnsafeUtility.As<Vector4, float4>(ref maxVector));
                yield return UnsafeUtility.As<float4, Vector4>(ref value);
            }
        }

        public static IEnumerable<Vector4> RepeatVector4(Vector4 min, Vector4 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextFloat4(UnsafeUtility.As<Vector4, float4>(ref min), UnsafeUtility.As<Vector4, float4>(ref max));
                yield return UnsafeUtility.As<float4, Vector4>(ref value);
            }
        }

        public static IEnumerable<Vector3Int> RepeatVector3Int(int min, int max, int count)
        {
            var minVector = new Vector3Int(min, min, min);
            var maxVector = new Vector3Int(max, max, max);
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextUInt3(UnsafeUtility.As<Vector3Int, uint3>(ref minVector), UnsafeUtility.As<Vector3Int, uint3>(ref maxVector));
                yield return UnsafeUtility.As<uint3, Vector3Int>(ref value);
            }
        }

        public static IEnumerable<Vector3Int> RepeatVector3Int(Vector3Int min, Vector3Int max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextUInt3(UnsafeUtility.As<Vector3Int, uint3>(ref min), UnsafeUtility.As<Vector3Int, uint3>(ref max));
                yield return UnsafeUtility.As<uint3, Vector3Int>(ref value);
            }
        }

        public static IEnumerable<Vector2Int> RepeatVector2Int(int min, int max, int count)
        {
            var minVector = new Vector2Int(min, min);
            var maxVector = new Vector2Int(max, max);
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextUInt2(UnsafeUtility.As<Vector2Int, uint2>(ref minVector), UnsafeUtility.As<Vector2Int, uint2>(ref maxVector));
                yield return UnsafeUtility.As<uint2, Vector2Int>(ref value);
            }
        }

        public static IEnumerable<Vector2Int> RepeatVector2Int(Vector2Int min, Vector2Int max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                var value = random.NextUInt2(UnsafeUtility.As<Vector2Int, uint2>(ref min), UnsafeUtility.As<Vector2Int, uint2>(ref max));
                yield return UnsafeUtility.As<uint2, Vector2Int>(ref value);
            }
        }

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

        public static IEnumerable<uint2> RepeatUInt2(uint2 min, uint2 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt2(min, max);
            }
        }

        public static IEnumerable<uint3> RepeatUInt3(uint3 min, uint3 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt3(min, max);
            }
        }

        public static IEnumerable<uint4> RepeatUInt4(uint4 min, uint4 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextUInt4(min, max);
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

        public static IEnumerable<int2> RepeatInt2(int2 min, int2 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt2(min, max);
            }
        }

        public static IEnumerable<int3> RepeatInt3(int3 min, int3 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt3(min, max);
            }
        }

        public static IEnumerable<int4> RepeatInt4(int4 min, int4 max, int count)
        {
            var random = new Unity.Mathematics.Random((uint)Random.Range(0, int.MaxValue));
            for (int i = 0; i < count; i++)
            {
                yield return random.NextInt4(min, max);
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