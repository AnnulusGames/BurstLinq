using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using static Unity.Burst.Intrinsics.Arm.Neon;

namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static byte Min(this NativeList<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = byte.MaxValue;
            static byte _min(byte a, byte b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static sbyte Min(this NativeList<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = sbyte.MaxValue;
            static sbyte _min(sbyte a, sbyte b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static short Min(this NativeList<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((short*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = short.MaxValue;
            static short _min(short a, short b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static ushort Min(this NativeList<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = ushort.MaxValue;
            static ushort _min(ushort a, ushort b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static int Min(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((int*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = int.MaxValue;
            static int _min(int a, int b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static uint Min(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = uint.MaxValue;
            static uint _min(uint a, uint b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static long Min(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((long*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = long.MaxValue;
            static long _min(long a, long b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static ulong Min(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = ulong.MaxValue;
            static ulong _min(ulong a, ulong b) => a < b ? a : b;
        
            for (var i = 0; i < length; i++)
            {
                tempResult = _min(tempResult, ptr[i]);
            }

            result = tempResult;
        }

        public static float Min(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((float*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = float.MaxValue;
            static float _min(float a, float b) => IsNeonSupported ? math.min(a,b): a < b ? a : b;
            var index = 0;
            if (BurstHelpers.IsV256Supported)
            {
                static v256 _min256(v256 a, float* b) => new v256(
                    _min(a.Float0, b[0]),
                    _min(a.Float1, b[1]),
                    _min(a.Float2, b[2]),
                    _min(a.Float3, b[3]),
                    _min(a.Float4, b[4]),
                    _min(a.Float5, b[5]),
                    _min(a.Float6, b[6]),
                    _min(a.Float7, b[7])
                );
                
                var packingLength = sizeof(v256) / sizeof(float);
                 
                if (0 < length / packingLength)
                {
                    var temp = new v256(float.MaxValue);
                    for (; index < length - packingLength; index += packingLength)
                    {
                        temp = _min256(temp, ptr+index);
                    }
                    float* tempAsArray = (float*)&temp;
                    for (int i = 0; i < packingLength; i++)
                    {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
            }
            else if (BurstHelpers.IsV128Supported)
            {
                static v128 _min128(v128 a, float* b) => new v128(
                    _min(a.Float0, b[0]),
                    _min(a.Float1, b[1]),
                    _min(a.Float2, b[2]),
                    _min(a.Float3, b[3])
                );
                
                var packingLength = sizeof(v128) / sizeof(float);
                 
                if (0 < length / packingLength)
                {
                    var temp = new v128(float.MaxValue);
                    for (; index < length - packingLength; index += packingLength)
                    {
                        temp = _min128(temp, ptr+index);
                    }
                    float* tempAsArray = (float*) &temp;
                    for (int i = 0; i < packingLength; i++)
                    {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
            }

            for (; index < length; index++)
            {
                tempResult = _min(tempResult, ptr[index]);
            }

            result =  tempResult;
        }

        public static double Min(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MinCore((double*)source.GetUnsafePtr(), source.Length, out var result);
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
            var tempResult = double.MaxValue;
            static double _min(double a, double b) => IsNeonSupported ? math.min(a,b): a < b ? a : b;
            var index = 0;
            if (BurstHelpers.IsV256Supported)
            {
                static v256 _min256(v256 a, double* b) => new v256(
                    _min(a.Double0, b[0]),
                    _min(a.Double1, b[1]),
                    _min(a.Double2, b[2]),
                    _min(a.Double3, b[3])
                );
                
                var packingLength = sizeof(v256) / sizeof(double);
                 
                if (0 < length / packingLength)
                {
                    var temp = new v256(double.MaxValue);
                    for (; index < length - packingLength; index += packingLength)
                    {
                        temp = _min256(temp, ptr+index);
                    }
                    double* tempAsArray = (double*)&temp;
                    for (int i = 0; i < packingLength; i++)
                    {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
            }
            else if (BurstHelpers.IsV128Supported)
            {
                static v128 _min128(v128 a, double* b) => new v128(
                    _min(a.Double0, b[0]),
                    _min(a.Double1, b[1])
                );
                
                var packingLength = sizeof(v128) / sizeof(double);
                 
                if (0 < length / packingLength)
                {
                    var temp = new v128(double.MaxValue);
                    for (; index < length - packingLength; index += packingLength)
                    {
                        temp = _min128(temp, ptr+index);
                    }
                    double* tempAsArray = (double*) &temp;
                    for (int i = 0; i < packingLength; i++)
                    {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
            }

            for (; index < length; index++)
            {
                tempResult = _min(tempResult, ptr[index]);
            }

            result =  tempResult;
        }

        
    }
}