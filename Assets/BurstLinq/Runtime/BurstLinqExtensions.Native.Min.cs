using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using static Unity.Burst.Intrinsics.X86.Avx;
using static Unity.Burst.Intrinsics.X86.Avx2;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace BurstLinq
{  
   
    public unsafe static partial class BurstLinqExtensions
    {
         public static byte Min(this NativeList<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Min(this NativeSlice<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Min(this NativeArray<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(byte* ptr, [AssumeRange(1, int.MaxValue)] int length, out byte result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(byte.MaxValue);
                var l = length / (32 / sizeof(byte));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epu8(temp, ptrAs256[i]);
                }
                result = byte.MaxValue;
                var tempAsArray = (byte*)&temp;
                for (int i = 0; i < 32 / sizeof(byte); i++) {
                        if (result > tempAsArray[i]) result = tempAsArray[i];
                    }
                for (int index=l*(32 / sizeof(byte)); index < length; index++)
                {
                        if (result > ptr[index]) result = ptr[index];
                    }
            }
            else {
                    static byte localMin(byte a, byte b) => a < b ? a : b;
                result = byte.MaxValue;
                for (int i = 0; i < length; i++)
                {
                   result = localMin(result, ptr[i]);
                }
            }
        }
                 public static sbyte Min(this NativeList<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Min(this NativeSlice<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Min(this NativeArray<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(sbyte* ptr, [AssumeRange(1, int.MaxValue)] int length, out sbyte result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(sbyte.MaxValue);
                var l = length / (32 / sizeof(sbyte));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epi8(temp, ptrAs256[i]);
                }
                result = sbyte.MaxValue;
                var tempAsArray = (sbyte*)&temp;
                for (int i = 0; i < 32 / sizeof(sbyte); i++) {
                        if (result > tempAsArray[i]) result = tempAsArray[i];
                    }
                for (int index=l*(32 / sizeof(sbyte)); index < length; index++)
                {
                        if (result > ptr[index]) result = ptr[index];
                    }
            }
            else {
                    static sbyte localMin(sbyte a, sbyte b) => a < b ? a : b;
                result = sbyte.MaxValue;
                for (int i = 0; i < length; i++)
                {
                   result = localMin(result, ptr[i]);
                }
            }
        }
                 public static short Min(this NativeList<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Min(this NativeSlice<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Min(this NativeArray<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(short* ptr, [AssumeRange(1, int.MaxValue)] int length, out short result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(short.MaxValue);
                var l = length / (32 / sizeof(short));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epi16(temp, ptrAs256[i]);
                }
                result = short.MaxValue;
                var tempAsArray = (short*)&temp;
                for (int i = 0; i < 32 / sizeof(short); i++) {
                        if (result > tempAsArray[i]) result = tempAsArray[i];
                    }
                for (int index=l*(32 / sizeof(short)); index < length; index++)
                {
                        if (result > ptr[index]) result = ptr[index];
                    }
            }
            else {
                    static short localMin(short a, short b) => a < b ? a : b;
                result = short.MaxValue;
                for (int i = 0; i < length; i++)
                {
                   result = localMin(result, ptr[i]);
                }
            }
        }
                 public static ushort Min(this NativeList<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Min(this NativeSlice<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Min(this NativeArray<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(ushort* ptr, [AssumeRange(1, int.MaxValue)] int length, out ushort result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(ushort.MaxValue);
                var l = length / (32 / sizeof(ushort));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epu16(temp, ptrAs256[i]);
                }
                result = ushort.MaxValue;
                var tempAsArray = (ushort*)&temp;
                for (int i = 0; i < 32 / sizeof(ushort); i++) {
                        if (result > tempAsArray[i]) result = tempAsArray[i];
                    }
                for (int index=l*(32 / sizeof(ushort)); index < length; index++)
                {
                        if (result > ptr[index]) result = ptr[index];
                    }
            }
            else {
                    static ushort localMin(ushort a, ushort b) => a < b ? a : b;
                result = ushort.MaxValue;
                for (int i = 0; i < length; i++)
                {
                   result = localMin(result, ptr[i]);
                }
            }
        }
                 public static int Min(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Min(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Min(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out int result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(int.MaxValue);
                var l = length / (32 / sizeof(int));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epi32(temp, ptrAs256[i]);
                }
                result = int.MaxValue;
                var tempAsArray = (int*)&temp;
                for (int i = 0; i < 32 / sizeof(int); i++) {
                        result = math.min(result, tempAsArray[i]);
                    }
                for (int index=l*(32 / sizeof(int)); index < length; index++)
                {
                        result = math.min(result, ptr[index]);
                    }
            }
            else {
                    var index = 0;
                var result4 = new int4(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
                var l = length / 4;
                for (; index < l; index += 4)
                {
                    result4 = math.min(result4, *(int4*)(ptr + index));
                }

                result = math.cmin(result4);
                for (; index < length; index++)
                {
                    result = math.min(result, ptr[index]);
                }
            }
        }
                 public static uint Min(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Min(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Min(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint result)
        {
         if (IsAvx2Supported) {
                var temp = new v256(uint.MaxValue);
                var l = length / (32 / sizeof(uint));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_epu32(temp, ptrAs256[i]);
                }
                result = uint.MaxValue;
                var tempAsArray = (uint*)&temp;
                for (int i = 0; i < 32 / sizeof(uint); i++) {
                        result = math.min(result, tempAsArray[i]);
                    }
                for (int index=l*(32 / sizeof(uint)); index < length; index++)
                {
                        result = math.min(result, ptr[index]);
                    }
            }
            else {
                    var index = 0;
                var result4 = new uint4(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue);
                var l = length / 4;
                for (; index < l; index += 4)
                {
                    result4 = math.min(result4, *(uint4*)(ptr + index));
                }

                result = math.cmin(result4);
                for (; index < length; index++)
                {
                    result = math.min(result, ptr[index]);
                }
            }
        }
                 public static long Min(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Min(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Min(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out long result)
        {
            static long localMin(long a, long b) => a < b ? a : b;
            result = long.MaxValue;
            for (int i = 0; i < length; i++)
            {
                result = localMin(result, ptr[i]);
            }
        }
             public static ulong Min(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Min(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Min(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out ulong result)
        {
            static ulong localMin(ulong a, ulong b) => a < b ? a : b;
            result = ulong.MaxValue;
            for (int i = 0; i < length; i++)
            {
                result = localMin(result, ptr[i]);
            }
        }
             public static float Min(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Min(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Min(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
         if (IsAvxSupported) {
                var temp = new v256(float.MaxValue);
                var l = length / (32 / sizeof(float));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_ps(temp, ptrAs256[i]);
                }
                result = float.MaxValue;
                var tempAsArray = (float*)&temp;
                for (int i = 0; i < 32 / sizeof(float); i++) {
                        result = math.min(result, tempAsArray[i]);
                    }
                for (int index=l*(32 / sizeof(float)); index < length; index++)
                {
                        result = math.min(result, ptr[index]);
                    }
            }
            else {
                    var index = 0;
                var result4 = new float4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
                var l = length / 4;
                for (; index < l; index += 4)
                {
                    result4 = math.min(result4, *(float4*)(ptr + index));
                }

                result = math.cmin(result4);
                for (; index < length; index++)
                {
                    result = math.min(result, ptr[index]);
                }
            }
        }
                 public static double Min(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Min(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Min(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }
        [BurstCompile]
        internal static void MinCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
         if (IsAvxSupported) {
                var temp = new v256(double.MaxValue);
                var l = length / (32 / sizeof(double));
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < l; i++) {
                    temp = mm256_min_pd(temp, ptrAs256[i]);
                }
                result = double.MaxValue;
                var tempAsArray = (double*)&temp;
                for (int i = 0; i < 32 / sizeof(double); i++) {
                        result = math.min(result, tempAsArray[i]);
                    }
                for (int index=l*(32 / sizeof(double)); index < length; index++)
                {
                        result = math.min(result, ptr[index]);
                    }
            }
            else {
                    var index = 0;
                var result4 = new double4(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
                var l = length / 4;
                for (; index < l; index += 4)
                {
                    result4 = math.min(result4, *(double4*)(ptr + index));
                }

                result = math.cmin(result4);
                for (; index < length; index++)
                {
                    result = math.min(result, ptr[index]);
                }
            }
        }
    }
}