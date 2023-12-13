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
        public static bool SequenceEqual(this NativeList<byte> first, NativeList<byte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<byte> first, NativeSlice<byte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((byte*)first.GetUnsafePtr(), (byte*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<byte> first, NativeArray<byte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((byte*)first.GetUnsafePtr(), (byte*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(byte* firstPtr, byte* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<sbyte> first, NativeList<sbyte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<sbyte> first, NativeSlice<sbyte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((sbyte*)first.GetUnsafePtr(), (sbyte*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<sbyte> first, NativeArray<sbyte> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((sbyte*)first.GetUnsafePtr(), (sbyte*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(sbyte* firstPtr, sbyte* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<short> first, NativeList<short> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<short> first, NativeSlice<short> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((short*)first.GetUnsafePtr(), (short*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<short> first, NativeArray<short> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((short*)first.GetUnsafePtr(), (short*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(short* firstPtr, short* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<ushort> first, NativeList<ushort> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<ushort> first, NativeSlice<ushort> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((ushort*)first.GetUnsafePtr(), (ushort*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<ushort> first, NativeArray<ushort> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((ushort*)first.GetUnsafePtr(), (ushort*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(ushort* firstPtr, ushort* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<int> first, NativeList<int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<int> first, NativeSlice<int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int*)first.GetUnsafePtr(), (int*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<int> first, NativeArray<int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int*)first.GetUnsafePtr(), (int*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal static bool SequenceEqualCore(int* firstPtr, int* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            var index = 0;
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = *(int4*)(firstPtr + index) == *(int4*)(secondPtr + index);
                if (!math.all(c)) return false;
            }

            for (; index < length; index++)
            {
                if (!firstPtr[index].Equals(secondPtr[index])) return false;
            }

            return true;
        }

        public static bool SequenceEqual(this NativeList<uint> first, NativeList<uint> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<uint> first, NativeSlice<uint> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint*)first.GetUnsafePtr(), (uint*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<uint> first, NativeArray<uint> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint*)first.GetUnsafePtr(), (uint*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal static bool SequenceEqualCore(uint* firstPtr, uint* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            var index = 0;
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = *(uint4*)(firstPtr + index) == *(uint4*)(secondPtr + index);
                if (!math.all(c)) return false;
            }

            for (; index < length; index++)
            {
                if (!firstPtr[index].Equals(secondPtr[index])) return false;
            }

            return true;
        }

        public static bool SequenceEqual(this NativeList<long> first, NativeList<long> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<long> first, NativeSlice<long> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((long*)first.GetUnsafePtr(), (long*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<long> first, NativeArray<long> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((long*)first.GetUnsafePtr(), (long*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(long* firstPtr, long* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<ulong> first, NativeList<ulong> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<ulong> first, NativeSlice<ulong> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((ulong*)first.GetUnsafePtr(), (ulong*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<ulong> first, NativeArray<ulong> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((ulong*)first.GetUnsafePtr(), (ulong*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(ulong* firstPtr, ulong* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<float> first, NativeList<float> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<float> first, NativeSlice<float> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float*)first.GetUnsafePtr(), (float*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<float> first, NativeArray<float> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float*)first.GetUnsafePtr(), (float*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal static bool SequenceEqualCore(float* firstPtr, float* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            var index = 0;
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = *(float4*)(firstPtr + index) == *(float4*)(secondPtr + index);
                if (!math.all(c)) return false;
            }

            for (; index < length; index++)
            {
                if (!firstPtr[index].Equals(secondPtr[index])) return false;
            }

            return true;
        }

        public static bool SequenceEqual(this NativeList<double> first, NativeList<double> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<double> first, NativeSlice<double> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double*)first.GetUnsafePtr(), (double*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<double> first, NativeArray<double> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double*)first.GetUnsafePtr(), (double*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal static bool SequenceEqualCore(double* firstPtr, double* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            var index = 0;
            var l = length / 4;
            for (; index < l; index += 4)
            {
                var c = *(double4*)(firstPtr + index) == *(double4*)(secondPtr + index);
                if (!math.all(c)) return false;
            }

            for (; index < length; index++)
            {
                if (!firstPtr[index].Equals(secondPtr[index])) return false;
            }

            return true;
        }

        public static bool SequenceEqual(this NativeList<Vector2> first, NativeList<Vector2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<Vector2> first, NativeSlice<Vector2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector2*)first.GetUnsafePtr(), (Vector2*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<Vector2> first, NativeArray<Vector2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector2*)first.GetUnsafePtr(), (Vector2*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(Vector2* firstPtr, Vector2* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<Vector2Int> first, NativeList<Vector2Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<Vector2Int> first, NativeSlice<Vector2Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector2Int*)first.GetUnsafePtr(), (Vector2Int*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<Vector2Int> first, NativeArray<Vector2Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector2Int*)first.GetUnsafePtr(), (Vector2Int*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(Vector2Int* firstPtr, Vector2Int* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<Vector3> first, NativeList<Vector3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<Vector3> first, NativeSlice<Vector3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector3*)first.GetUnsafePtr(), (Vector3*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<Vector3> first, NativeArray<Vector3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector3*)first.GetUnsafePtr(), (Vector3*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(Vector3* firstPtr, Vector3* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<Vector3Int> first, NativeList<Vector3Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<Vector3Int> first, NativeSlice<Vector3Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector3Int*)first.GetUnsafePtr(), (Vector3Int*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<Vector3Int> first, NativeArray<Vector3Int> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector3Int*)first.GetUnsafePtr(), (Vector3Int*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(Vector3Int* firstPtr, Vector3Int* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<Vector4> first, NativeList<Vector4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<Vector4> first, NativeSlice<Vector4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector4*)first.GetUnsafePtr(), (Vector4*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<Vector4> first, NativeArray<Vector4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((Vector4*)first.GetUnsafePtr(), (Vector4*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(Vector4* firstPtr, Vector4* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<int2> first, NativeList<int2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<int2> first, NativeSlice<int2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int2*)first.GetUnsafePtr(), (int2*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<int2> first, NativeArray<int2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int2*)first.GetUnsafePtr(), (int2*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(int2* firstPtr, int2* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<int3> first, NativeList<int3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<int3> first, NativeSlice<int3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int3*)first.GetUnsafePtr(), (int3*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<int3> first, NativeArray<int3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int3*)first.GetUnsafePtr(), (int3*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(int3* firstPtr, int3* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<int4> first, NativeList<int4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<int4> first, NativeSlice<int4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int4*)first.GetUnsafePtr(), (int4*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<int4> first, NativeArray<int4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((int4*)first.GetUnsafePtr(), (int4*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(int4* firstPtr, int4* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<uint2> first, NativeList<uint2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<uint2> first, NativeSlice<uint2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint2*)first.GetUnsafePtr(), (uint2*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<uint2> first, NativeArray<uint2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint2*)first.GetUnsafePtr(), (uint2*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(uint2* firstPtr, uint2* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<uint3> first, NativeList<uint3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<uint3> first, NativeSlice<uint3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint3*)first.GetUnsafePtr(), (uint3*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<uint3> first, NativeArray<uint3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint3*)first.GetUnsafePtr(), (uint3*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(uint3* firstPtr, uint3* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<uint4> first, NativeList<uint4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<uint4> first, NativeSlice<uint4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint4*)first.GetUnsafePtr(), (uint4*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<uint4> first, NativeArray<uint4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((uint4*)first.GetUnsafePtr(), (uint4*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(uint4* firstPtr, uint4* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<float2> first, NativeList<float2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<float2> first, NativeSlice<float2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float2*)first.GetUnsafePtr(), (float2*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<float2> first, NativeArray<float2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float2*)first.GetUnsafePtr(), (float2*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(float2* firstPtr, float2* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<float3> first, NativeList<float3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<float3> first, NativeSlice<float3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float3*)first.GetUnsafePtr(), (float3*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<float3> first, NativeArray<float3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float3*)first.GetUnsafePtr(), (float3*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(float3* firstPtr, float3* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<float4> first, NativeList<float4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<float4> first, NativeSlice<float4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float4*)first.GetUnsafePtr(), (float4*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<float4> first, NativeArray<float4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((float4*)first.GetUnsafePtr(), (float4*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(float4* firstPtr, float4* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<double2> first, NativeList<double2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<double2> first, NativeSlice<double2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double2*)first.GetUnsafePtr(), (double2*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<double2> first, NativeArray<double2> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double2*)first.GetUnsafePtr(), (double2*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(double2* firstPtr, double2* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<double3> first, NativeList<double3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<double3> first, NativeSlice<double3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double3*)first.GetUnsafePtr(), (double3*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<double3> first, NativeArray<double3> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double3*)first.GetUnsafePtr(), (double3*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(double3* firstPtr, double3* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

        public static bool SequenceEqual(this NativeList<double4> first, NativeList<double4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore(first.GetUnsafePtr(), second.GetUnsafePtr(), first.Length);
        }

        public unsafe static bool SequenceEqual(this NativeSlice<double4> first, NativeSlice<double4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double4*)first.GetUnsafePtr(), (double4*)second.GetUnsafePtr(), first.Length);
        }

        public static bool SequenceEqual(this NativeArray<double4> first, NativeArray<double4> second)
        {
            if (first.Length != second.Length) return false;
            return SequenceEqualCore((double4*)first.GetUnsafePtr(), (double4*)second.GetUnsafePtr(), first.Length);
        }

        [BurstCompile]
        internal unsafe static bool SequenceEqualCore(double4* firstPtr, double4* secondPtr, [AssumeRange(0, int.MaxValue)] int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (!firstPtr[i].Equals(secondPtr[i])) return false;
            }
            return true;
        }

    }
}