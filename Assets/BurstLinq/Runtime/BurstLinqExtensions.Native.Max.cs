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
             static byte _max(byte a, byte b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.Byte0, b.Byte0),
                _max(a.Byte1, b.Byte1),
                _max(a.Byte2, b.Byte2),
                _max(a.Byte3, b.Byte3),
                _max(a.Byte4, b.Byte4),
                _max(a.Byte5, b.Byte5),
                _max(a.Byte6, b.Byte6),
                _max(a.Byte7, b.Byte7),
                _max(a.Byte8, b.Byte8),
                _max(a.Byte9, b.Byte9),
                _max(a.Byte10, b.Byte10),
                _max(a.Byte11, b.Byte11),
                _max(a.Byte12, b.Byte12),
                _max(a.Byte13, b.Byte13),
                _max(a.Byte14, b.Byte14),
                _max(a.Byte15, b.Byte15),
                _max(a.Byte16, b.Byte16),
                _max(a.Byte17, b.Byte17),
                _max(a.Byte18, b.Byte18),
                _max(a.Byte19, b.Byte19),
                _max(a.Byte20, b.Byte20),
                _max(a.Byte21, b.Byte21),
                _max(a.Byte22, b.Byte22),
                _max(a.Byte23, b.Byte23),
                _max(a.Byte24, b.Byte24),
                _max(a.Byte25, b.Byte25),
                _max(a.Byte26, b.Byte26),
                _max(a.Byte27, b.Byte27),
                _max(a.Byte28, b.Byte28),
                _max(a.Byte29, b.Byte29),
                _max(a.Byte30, b.Byte30),
                _max(a.Byte31, b.Byte31)
            );
            var tempResult = byte.MinValue;
            var packingLength = sizeof(v256) / sizeof(byte);
            var temp = new v256(byte.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                byte* tempAsArray = (byte*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static sbyte _max(sbyte a, sbyte b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.SByte0, b.SByte0),
                _max(a.SByte1, b.SByte1),
                _max(a.SByte2, b.SByte2),
                _max(a.SByte3, b.SByte3),
                _max(a.SByte4, b.SByte4),
                _max(a.SByte5, b.SByte5),
                _max(a.SByte6, b.SByte6),
                _max(a.SByte7, b.SByte7),
                _max(a.SByte8, b.SByte8),
                _max(a.SByte9, b.SByte9),
                _max(a.SByte10, b.SByte10),
                _max(a.SByte11, b.SByte11),
                _max(a.SByte12, b.SByte12),
                _max(a.SByte13, b.SByte13),
                _max(a.SByte14, b.SByte14),
                _max(a.SByte15, b.SByte15),
                _max(a.SByte16, b.SByte16),
                _max(a.SByte17, b.SByte17),
                _max(a.SByte18, b.SByte18),
                _max(a.SByte19, b.SByte19),
                _max(a.SByte20, b.SByte20),
                _max(a.SByte21, b.SByte21),
                _max(a.SByte22, b.SByte22),
                _max(a.SByte23, b.SByte23),
                _max(a.SByte24, b.SByte24),
                _max(a.SByte25, b.SByte25),
                _max(a.SByte26, b.SByte26),
                _max(a.SByte27, b.SByte27),
                _max(a.SByte28, b.SByte28),
                _max(a.SByte29, b.SByte29),
                _max(a.SByte30, b.SByte30),
                _max(a.SByte31, b.SByte31)
            );
            var tempResult = sbyte.MinValue;
            var packingLength = sizeof(v256) / sizeof(sbyte);
            var temp = new v256(sbyte.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                sbyte* tempAsArray = (sbyte*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static short _max(short a, short b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.SShort0, b.SShort0),
                _max(a.SShort1, b.SShort1),
                _max(a.SShort2, b.SShort2),
                _max(a.SShort3, b.SShort3),
                _max(a.SShort4, b.SShort4),
                _max(a.SShort5, b.SShort5),
                _max(a.SShort6, b.SShort6),
                _max(a.SShort7, b.SShort7),
                _max(a.SShort8, b.SShort8),
                _max(a.SShort9, b.SShort9),
                _max(a.SShort10, b.SShort10),
                _max(a.SShort11, b.SShort11),
                _max(a.SShort12, b.SShort12),
                _max(a.SShort13, b.SShort13),
                _max(a.SShort14, b.SShort14),
                _max(a.SShort15, b.SShort15)
            );
            var tempResult = short.MinValue;
            var packingLength = sizeof(v256) / sizeof(short);
            var temp = new v256(short.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                short* tempAsArray = (short*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static ushort _max(ushort a, ushort b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.UShort0, b.UShort0),
                _max(a.UShort1, b.UShort1),
                _max(a.UShort2, b.UShort2),
                _max(a.UShort3, b.UShort3),
                _max(a.UShort4, b.UShort4),
                _max(a.UShort5, b.UShort5),
                _max(a.UShort6, b.UShort6),
                _max(a.UShort7, b.UShort7),
                _max(a.UShort8, b.UShort8),
                _max(a.UShort9, b.UShort9),
                _max(a.UShort10, b.UShort10),
                _max(a.UShort11, b.UShort11),
                _max(a.UShort12, b.UShort12),
                _max(a.UShort13, b.UShort13),
                _max(a.UShort14, b.UShort14),
                _max(a.UShort15, b.UShort15)
            );
            var tempResult = ushort.MinValue;
            var packingLength = sizeof(v256) / sizeof(ushort);
            var temp = new v256(ushort.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                ushort* tempAsArray = (ushort*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static int _max(int a, int b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.SInt0, b.SInt0),
                _max(a.SInt1, b.SInt1),
                _max(a.SInt2, b.SInt2),
                _max(a.SInt3, b.SInt3),
                _max(a.SInt4, b.SInt4),
                _max(a.SInt5, b.SInt5),
                _max(a.SInt6, b.SInt6),
                _max(a.SInt7, b.SInt7)
            );
            var tempResult = int.MinValue;
            var packingLength = sizeof(v256) / sizeof(int);
            var temp = new v256(int.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                int* tempAsArray = (int*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static uint _max(uint a, uint b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.UInt0, b.UInt0),
                _max(a.UInt1, b.UInt1),
                _max(a.UInt2, b.UInt2),
                _max(a.UInt3, b.UInt3),
                _max(a.UInt4, b.UInt4),
                _max(a.UInt5, b.UInt5),
                _max(a.UInt6, b.UInt6),
                _max(a.UInt7, b.UInt7)
            );
            var tempResult = uint.MinValue;
            var packingLength = sizeof(v256) / sizeof(uint);
            var temp = new v256(uint.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                uint* tempAsArray = (uint*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static long _max(long a, long b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.SLong0, b.SLong0),
                _max(a.SLong1, b.SLong1),
                _max(a.SLong2, b.SLong2),
                _max(a.SLong3, b.SLong3)
            );
            var tempResult = long.MinValue;
            var packingLength = sizeof(v256) / sizeof(long);
            var temp = new v256(long.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                long* tempAsArray = (long*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static ulong _max(ulong a, ulong b) =>  a > b ? a : b;
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.ULong0, b.ULong0),
                _max(a.ULong1, b.ULong1),
                _max(a.ULong2, b.ULong2),
                _max(a.ULong3, b.ULong3)
            );
            var tempResult = ulong.MinValue;
            var packingLength = sizeof(v256) / sizeof(ulong);
            var temp = new v256(ulong.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                ulong* tempAsArray = (ulong*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
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
             static float _max(float a, float b) =>math.max(a,b);
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.Float0, b.Float0),
                _max(a.Float1, b.Float1),
                _max(a.Float2, b.Float2),
                _max(a.Float3, b.Float3),
                _max(a.Float4, b.Float4),
                _max(a.Float5, b.Float5),
                _max(a.Float6, b.Float6),
                _max(a.Float7, b.Float7)
            );
            var tempResult = float.MinValue;
            var packingLength = sizeof(v256) / sizeof(float);
            var temp = new v256(float.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                float* tempAsArray = (float*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
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
             static double _max(double a, double b) =>math.max(a,b);
            static v256 _v_max(v256 a, v256 b) => new v256(
                _max(a.Double0, b.Double0),
                _max(a.Double1, b.Double1),
                _max(a.Double2, b.Double2),
                _max(a.Double3, b.Double3)
            );
            var tempResult = double.MinValue;
            var packingLength = sizeof(v256) / sizeof(double);
            var temp = new v256(double.MinValue);
            var packedLength = length / (packingLength);
            if(0<packedLength) {
                var ptrAs256 = (v256*) ptr;
                for (int i = 0; i < packedLength; i++) {
                    temp = _v_max(temp, ptrAs256[i]);
                }
                double* tempAsArray = (double*) &temp;
                for (int i = 0; i < packingLength; i++) {
                    tempResult = _max(tempResult, tempAsArray[i]);
                }
            }
            for (var index = packedLength * packingLength; index < length; index++) {
                tempResult = _max(tempResult, ptr[index]);
            }
            result =  tempResult;
        }
    }
}