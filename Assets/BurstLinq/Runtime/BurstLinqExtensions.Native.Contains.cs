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
        public static bool Contains(this NativeList<byte> source, byte value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<byte> source, byte value)
        {
            return ContainsCore((byte*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<byte> source, byte value)
        {
            return ContainsCore((byte*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(byte* ptr, [AssumeRange(0, int.MaxValue)] int length, in byte value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<sbyte> source, sbyte value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<sbyte> source, sbyte value)
        {
            return ContainsCore((sbyte*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<sbyte> source, sbyte value)
        {
            return ContainsCore((sbyte*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(sbyte* ptr, [AssumeRange(0, int.MaxValue)] int length, in sbyte value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<short> source, short value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<short> source, short value)
        {
            return ContainsCore((short*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<short> source, short value)
        {
            return ContainsCore((short*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(short* ptr, [AssumeRange(0, int.MaxValue)] int length, in short value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<ushort> source, ushort value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<ushort> source, ushort value)
        {
            return ContainsCore((ushort*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<ushort> source, ushort value)
        {
            return ContainsCore((ushort*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(ushort* ptr, [AssumeRange(0, int.MaxValue)] int length, in ushort value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<int> source, int value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<int> source, int value)
        {
            return ContainsCore((int*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int> source, int value)
        {
            return ContainsCore((int*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal static bool ContainsCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, in int value)
        {
            var index = 0;
            var value4 = new int4(value, value, value, value);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = value4 == *(int4*)(ptr + index);
                if (math.any(c)) return true;
            }

            for (; index < length; index++)
            {
                if (ptr[index].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<uint> source, uint value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<uint> source, uint value)
        {
            return ContainsCore((uint*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint> source, uint value)
        {
            return ContainsCore((uint*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal static bool ContainsCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, in uint value)
        {
            var index = 0;
            var value4 = new uint4(value, value, value, value);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = value4 == *(uint4*)(ptr + index);
                if (math.any(c)) return true;
            }

            for (; index < length; index++)
            {
                if (ptr[index].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<long> source, long value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<long> source, long value)
        {
            return ContainsCore((long*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<long> source, long value)
        {
            return ContainsCore((long*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(long* ptr, [AssumeRange(0, int.MaxValue)] int length, in long value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<ulong> source, ulong value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<ulong> source, ulong value)
        {
            return ContainsCore((ulong*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<ulong> source, ulong value)
        {
            return ContainsCore((ulong*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(ulong* ptr, [AssumeRange(0, int.MaxValue)] int length, in ulong value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<float> source, float value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<float> source, float value)
        {
            return ContainsCore((float*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float> source, float value)
        {
            return ContainsCore((float*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal static bool ContainsCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, in float value)
        {
            var index = 0;
            var value4 = new float4(value, value, value, value);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = value4 == *(float4*)(ptr + index);
                if (math.any(c)) return true;
            }

            for (; index < length; index++)
            {
                if (ptr[index].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<double> source, double value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<double> source, double value)
        {
            return ContainsCore((double*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double> source, double value)
        {
            return ContainsCore((double*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal static bool ContainsCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, in double value)
        {
            var index = 0;
            var value4 = new double4(value, value, value, value);
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = value4 == *(double4*)(ptr + index);
                if (math.any(c)) return true;
            }

            for (; index < length; index++)
            {
                if (ptr[index].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<Vector2> source, Vector2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<Vector2> source, Vector2 value)
        {
            return ContainsCore((Vector2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector2> source, Vector2 value)
        {
            return ContainsCore((Vector2*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(Vector2* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector2 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore((Vector2Int*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore((Vector2Int*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(Vector2Int* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector2Int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<Vector3> source, Vector3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<Vector3> source, Vector3 value)
        {
            return ContainsCore((Vector3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector3> source, Vector3 value)
        {
            return ContainsCore((Vector3*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(Vector3* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector3 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<Vector3Int> source, Vector3Int value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<Vector3Int> source, Vector3Int value)
        {
            return ContainsCore((Vector3Int*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector3Int> source, Vector3Int value)
        {
            return ContainsCore((Vector3Int*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(Vector3Int* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector3Int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<Vector4> source, Vector4 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<Vector4> source, Vector4 value)
        {
            return ContainsCore((Vector4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector4> source, Vector4 value)
        {
            return ContainsCore((Vector4*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(Vector4* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<int2> source, int2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<int2> source, int2 value)
        {
            return ContainsCore((int2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int2> source, int2 value)
        {
            return ContainsCore((int2*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(int2* ptr, [AssumeRange(0, int.MaxValue)] int length, in int2 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<int3> source, int3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<int3> source, int3 value)
        {
            return ContainsCore((int3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int3> source, int3 value)
        {
            return ContainsCore((int3*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(int3* ptr, [AssumeRange(0, int.MaxValue)] int length, in int3 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<int4> source, int4 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<int4> source, int4 value)
        {
            return ContainsCore((int4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int4> source, int4 value)
        {
            return ContainsCore((int4*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(int4* ptr, [AssumeRange(0, int.MaxValue)] int length, in int4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<uint2> source, uint2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<uint2> source, uint2 value)
        {
            return ContainsCore((uint2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint2> source, uint2 value)
        {
            return ContainsCore((uint2*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(uint2* ptr, [AssumeRange(0, int.MaxValue)] int length, in uint2 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<uint3> source, uint3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<uint3> source, uint3 value)
        {
            return ContainsCore((uint3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint3> source, uint3 value)
        {
            return ContainsCore((uint3*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(uint3* ptr, [AssumeRange(0, int.MaxValue)] int length, in uint3 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<uint4> source, uint4 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<uint4> source, uint4 value)
        {
            return ContainsCore((uint4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint4> source, uint4 value)
        {
            return ContainsCore((uint4*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(uint4* ptr, [AssumeRange(0, int.MaxValue)] int length, in uint4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<float2> source, float2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<float2> source, float2 value)
        {
            return ContainsCore((float2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float2> source, float2 value)
        {
            return ContainsCore((float2*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(float2* ptr, [AssumeRange(0, int.MaxValue)] int length, in float2 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<float3> source, float3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<float3> source, float3 value)
        {
            return ContainsCore((float3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float3> source, float3 value)
        {
            return ContainsCore((float3*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(float3* ptr, [AssumeRange(0, int.MaxValue)] int length, in float3 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<float4> source, float4 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<float4> source, float4 value)
        {
            return ContainsCore((float4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float4> source, float4 value)
        {
            return ContainsCore((float4*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(float4* ptr, [AssumeRange(0, int.MaxValue)] int length, in float4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<double2> source, double2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<double2> source, double2 value)
        {
            return ContainsCore((double2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double2> source, double2 value)
        {
            return ContainsCore((double2*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(double2* ptr, [AssumeRange(0, int.MaxValue)] int length, in double2 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<double3> source, double3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<double3> source, double3 value)
        {
            return ContainsCore((double3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double3> source, double3 value)
        {
            return ContainsCore((double3*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(double3* ptr, [AssumeRange(0, int.MaxValue)] int length, in double3 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

        public static bool Contains(this NativeList<double4> source, double4 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public unsafe static bool Contains(this NativeSlice<double4> source, double4 value)
        {
            return ContainsCore((double4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double4> source, double4 value)
        {
            return ContainsCore((double4*)source.GetUnsafePtr(), source.Length, value);
        }

        [BurstCompile]
        internal unsafe static bool ContainsCore(double4* ptr, [AssumeRange(0, int.MaxValue)] int length, in double4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }

    }
}