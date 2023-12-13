using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using System.Runtime.CompilerServices;
using static Unity.Burst.Intrinsics.Arm.Neon;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace BurstLinq
{  

    public unsafe static partial class BurstLinqExtensions
    {
         public static byte Max(this NativeList<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Max(this NativeSlice<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static byte Max(this NativeArray<byte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((byte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(byte* ptr, [AssumeRange(1, int.MaxValue)] int length, out byte result)
        {
            var tempResult = byte.MinValue;
             static byte _max(byte a, byte b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static sbyte Max(this NativeList<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Max(this NativeSlice<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static sbyte Max(this NativeArray<sbyte> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((sbyte*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(sbyte* ptr, [AssumeRange(1, int.MaxValue)] int length, out sbyte result)
        {
            var tempResult = sbyte.MinValue;
             static sbyte _max(sbyte a, sbyte b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static short Max(this NativeList<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Max(this NativeSlice<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static short Max(this NativeArray<short> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((short*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(short* ptr, [AssumeRange(1, int.MaxValue)] int length, out short result)
        {
            var tempResult = short.MinValue;
             static short _max(short a, short b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static ushort Max(this NativeList<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Max(this NativeSlice<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ushort Max(this NativeArray<ushort> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ushort*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(ushort* ptr, [AssumeRange(1, int.MaxValue)] int length, out ushort result)
        {
            var tempResult = ushort.MinValue;
             static ushort _max(ushort a, ushort b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static int Max(this NativeList<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Max(this NativeSlice<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static int Max(this NativeArray<int> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((int*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(int* ptr, [AssumeRange(1, int.MaxValue)] int length, out int result)
        {
            var tempResult = int.MinValue;
             static int _max(int a, int b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static uint Max(this NativeList<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Max(this NativeSlice<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static uint Max(this NativeArray<uint> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((uint*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(uint* ptr, [AssumeRange(1, int.MaxValue)] int length, out uint result)
        {
            var tempResult = uint.MinValue;
             static uint _max(uint a, uint b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static long Max(this NativeList<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Max(this NativeSlice<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static long Max(this NativeArray<long> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((long*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, out long result)
        {
            var tempResult = long.MinValue;
             static long _max(long a, long b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static ulong Max(this NativeList<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Max(this NativeSlice<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static ulong Max(this NativeArray<ulong> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((ulong*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, out ulong result)
        {
            var tempResult = ulong.MinValue;
             static ulong _max(ulong a, ulong b) =>a > b ? a : b;
            
             for (var i = 0; i < length; i++) {
                tempResult = _max(tempResult, ptr[i]);
             }
             result = tempResult;
        }
         public static float Max(this NativeList<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Max(this NativeSlice<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static float Max(this NativeArray<float> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((float*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(float* ptr, [AssumeRange(1, int.MaxValue)] int length, out float result)
        {
            var tempResult = float.MinValue;
            static float _max(float a, float b) =>IsNeonSupported?math.max(a,b): a > b ? a : b;
            
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _max256(v256 a, float* b) => new v256(
                        _max(a.Float0, b[0]),
                        _max(a.Float1, b[1]),
                        _max(a.Float2, b[2]),
                        _max(a.Float3, b[3]),
                        _max(a.Float4, b[4]),
                        _max(a.Float5, b[5]),
                        _max(a.Float6, b[6]),
                        _max(a.Float7, b[7])
                );
                
                var packingLength = sizeof(v256) / sizeof(float);
                 
                if(0<length / packingLength) {
                    var temp = new v256(float.MinValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _max256(temp, (ptr+index));
                    }
                    float* tempAsArray = (float*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _max(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _max128(v128 a, float* b) => new v128(
                    _max(a.Float0, b[0]),
                    _max(a.Float1, b[1]),
                    _max(a.Float2, b[2]),
                    _max(a.Float3, b[3])
                );
                
                var packingLength = sizeof(v128) / sizeof(float);
                 
                if(0<length / packingLength) {
                    var temp = new v128(float.MinValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _max128(temp, (ptr+index));
                    }
                    float* tempAsArray = (float*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _max(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _max(tempResult, ptr[index]);
             }
             result =  tempResult;
        }
         public static double Max(this NativeList<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore(source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Max(this NativeSlice<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        public static double Max(this NativeArray<double> source)
        {
            Error.ThrowIfEmpty(source.Length);
            MaxCore((double*)source.GetUnsafePtr(), source.Length, out var result);
            return result;
        }

        [BurstCompile]
        internal static void MaxCore(double* ptr, [AssumeRange(1, int.MaxValue)] int length, out double result)
        {
            var tempResult = double.MinValue;
            static double _max(double a, double b) =>IsNeonSupported?math.max(a,b): a > b ? a : b;
            
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _max256(v256 a, double* b) => new v256(
                        _max(a.Double0, b[0]),
                        _max(a.Double1, b[1]),
                        _max(a.Double2, b[2]),
                        _max(a.Double3, b[3])
                );
                
                var packingLength = sizeof(v256) / sizeof(double);
                 
                if(0<length / packingLength) {
                    var temp = new v256(double.MinValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _max256(temp, (ptr+index));
                    }
                    double* tempAsArray = (double*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _max(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _max128(v128 a, double* b) => new v128(
                    _max(a.Double0, b[0]),
                    _max(a.Double1, b[1])
                );
                
                var packingLength = sizeof(v128) / sizeof(double);
                 
                if(0<length / packingLength) {
                    var temp = new v128(double.MinValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _max128(temp, (ptr+index));
                    }
                    double* tempAsArray = (double*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _max(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _max(tempResult, ptr[index]);
             }
             result =  tempResult;
        }
    }
}