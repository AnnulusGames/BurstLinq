using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using static Unity.Burst.Intrinsics.Arm.Neon;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using System.Runtime.CompilerServices;
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
            var tempResult = byte.MaxValue;
              static byte _min(byte a, byte b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, byte* b) => new v256(
                        _min(a.Byte0, b[0]),
                        _min(a.Byte1, b[1]),
                        _min(a.Byte2, b[2]),
                        _min(a.Byte3, b[3]),
                        _min(a.Byte4, b[4]),
                        _min(a.Byte5, b[5]),
                        _min(a.Byte6, b[6]),
                        _min(a.Byte7, b[7]),
                        _min(a.Byte8, b[8]),
                        _min(a.Byte9, b[9]),
                        _min(a.Byte10, b[10]),
                        _min(a.Byte11, b[11]),
                        _min(a.Byte12, b[12]),
                        _min(a.Byte13, b[13]),
                        _min(a.Byte14, b[14]),
                        _min(a.Byte15, b[15]),
                        _min(a.Byte16, b[16]),
                        _min(a.Byte17, b[17]),
                        _min(a.Byte18, b[18]),
                        _min(a.Byte19, b[19]),
                        _min(a.Byte20, b[20]),
                        _min(a.Byte21, b[21]),
                        _min(a.Byte22, b[22]),
                        _min(a.Byte23, b[23]),
                        _min(a.Byte24, b[24]),
                        _min(a.Byte25, b[25]),
                        _min(a.Byte26, b[26]),
                        _min(a.Byte27, b[27]),
                        _min(a.Byte28, b[28]),
                        _min(a.Byte29, b[29]),
                        _min(a.Byte30, b[30]),
                        _min(a.Byte31, b[31])
                );
                
                var packingLength = sizeof(v256) / sizeof(byte);
                 
                if(0<length / packingLength) {
                    var temp = new v256(byte.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    byte* tempAsArray = (byte*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, byte* b) => new v128(
                    _min(a.Byte0, b[0]),
                    _min(a.Byte1, b[1]),
                    _min(a.Byte2, b[2]),
                    _min(a.Byte3, b[3]),
                    _min(a.Byte4, b[4]),
                    _min(a.Byte5, b[5]),
                    _min(a.Byte6, b[6]),
                    _min(a.Byte7, b[7]),
                    _min(a.Byte8, b[8]),
                    _min(a.Byte9, b[9]),
                    _min(a.Byte10, b[10]),
                    _min(a.Byte11, b[11]),
                    _min(a.Byte12, b[12]),
                    _min(a.Byte13, b[13]),
                    _min(a.Byte14, b[14]),
                    _min(a.Byte15, b[15])
                );
                
                var packingLength = sizeof(v128) / sizeof(byte);
                 
                if(0<length / packingLength) {
                    var temp = new v128(byte.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    byte* tempAsArray = (byte*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = sbyte.MaxValue;
              static sbyte _min(sbyte a, sbyte b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, sbyte* b) => new v256(
                        _min(a.SByte0, b[0]),
                        _min(a.SByte1, b[1]),
                        _min(a.SByte2, b[2]),
                        _min(a.SByte3, b[3]),
                        _min(a.SByte4, b[4]),
                        _min(a.SByte5, b[5]),
                        _min(a.SByte6, b[6]),
                        _min(a.SByte7, b[7]),
                        _min(a.SByte8, b[8]),
                        _min(a.SByte9, b[9]),
                        _min(a.SByte10, b[10]),
                        _min(a.SByte11, b[11]),
                        _min(a.SByte12, b[12]),
                        _min(a.SByte13, b[13]),
                        _min(a.SByte14, b[14]),
                        _min(a.SByte15, b[15]),
                        _min(a.SByte16, b[16]),
                        _min(a.SByte17, b[17]),
                        _min(a.SByte18, b[18]),
                        _min(a.SByte19, b[19]),
                        _min(a.SByte20, b[20]),
                        _min(a.SByte21, b[21]),
                        _min(a.SByte22, b[22]),
                        _min(a.SByte23, b[23]),
                        _min(a.SByte24, b[24]),
                        _min(a.SByte25, b[25]),
                        _min(a.SByte26, b[26]),
                        _min(a.SByte27, b[27]),
                        _min(a.SByte28, b[28]),
                        _min(a.SByte29, b[29]),
                        _min(a.SByte30, b[30]),
                        _min(a.SByte31, b[31])
                );
                
                var packingLength = sizeof(v256) / sizeof(sbyte);
                 
                if(0<length / packingLength) {
                    var temp = new v256(sbyte.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    sbyte* tempAsArray = (sbyte*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, sbyte* b) => new v128(
                    _min(a.SByte0, b[0]),
                    _min(a.SByte1, b[1]),
                    _min(a.SByte2, b[2]),
                    _min(a.SByte3, b[3]),
                    _min(a.SByte4, b[4]),
                    _min(a.SByte5, b[5]),
                    _min(a.SByte6, b[6]),
                    _min(a.SByte7, b[7]),
                    _min(a.SByte8, b[8]),
                    _min(a.SByte9, b[9]),
                    _min(a.SByte10, b[10]),
                    _min(a.SByte11, b[11]),
                    _min(a.SByte12, b[12]),
                    _min(a.SByte13, b[13]),
                    _min(a.SByte14, b[14]),
                    _min(a.SByte15, b[15])
                );
                
                var packingLength = sizeof(v128) / sizeof(sbyte);
                 
                if(0<length / packingLength) {
                    var temp = new v128(sbyte.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    sbyte* tempAsArray = (sbyte*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = short.MaxValue;
              static short _min(short a, short b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, short* b) => new v256(
                        _min(a.SShort0, b[0]),
                        _min(a.SShort1, b[1]),
                        _min(a.SShort2, b[2]),
                        _min(a.SShort3, b[3]),
                        _min(a.SShort4, b[4]),
                        _min(a.SShort5, b[5]),
                        _min(a.SShort6, b[6]),
                        _min(a.SShort7, b[7]),
                        _min(a.SShort8, b[8]),
                        _min(a.SShort9, b[9]),
                        _min(a.SShort10, b[10]),
                        _min(a.SShort11, b[11]),
                        _min(a.SShort12, b[12]),
                        _min(a.SShort13, b[13]),
                        _min(a.SShort14, b[14]),
                        _min(a.SShort15, b[15])
                );
                
                var packingLength = sizeof(v256) / sizeof(short);
                 
                if(0<length / packingLength) {
                    var temp = new v256(short.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    short* tempAsArray = (short*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, short* b) => new v128(
                    _min(a.SShort0, b[0]),
                    _min(a.SShort1, b[1]),
                    _min(a.SShort2, b[2]),
                    _min(a.SShort3, b[3]),
                    _min(a.SShort4, b[4]),
                    _min(a.SShort5, b[5]),
                    _min(a.SShort6, b[6]),
                    _min(a.SShort7, b[7])
                );
                
                var packingLength = sizeof(v128) / sizeof(short);
                 
                if(0<length / packingLength) {
                    var temp = new v128(short.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    short* tempAsArray = (short*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = ushort.MaxValue;
              static ushort _min(ushort a, ushort b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, ushort* b) => new v256(
                        _min(a.UShort0, b[0]),
                        _min(a.UShort1, b[1]),
                        _min(a.UShort2, b[2]),
                        _min(a.UShort3, b[3]),
                        _min(a.UShort4, b[4]),
                        _min(a.UShort5, b[5]),
                        _min(a.UShort6, b[6]),
                        _min(a.UShort7, b[7]),
                        _min(a.UShort8, b[8]),
                        _min(a.UShort9, b[9]),
                        _min(a.UShort10, b[10]),
                        _min(a.UShort11, b[11]),
                        _min(a.UShort12, b[12]),
                        _min(a.UShort13, b[13]),
                        _min(a.UShort14, b[14]),
                        _min(a.UShort15, b[15])
                );
                
                var packingLength = sizeof(v256) / sizeof(ushort);
                 
                if(0<length / packingLength) {
                    var temp = new v256(ushort.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    ushort* tempAsArray = (ushort*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, ushort* b) => new v128(
                    _min(a.UShort0, b[0]),
                    _min(a.UShort1, b[1]),
                    _min(a.UShort2, b[2]),
                    _min(a.UShort3, b[3]),
                    _min(a.UShort4, b[4]),
                    _min(a.UShort5, b[5]),
                    _min(a.UShort6, b[6]),
                    _min(a.UShort7, b[7])
                );
                
                var packingLength = sizeof(v128) / sizeof(ushort);
                 
                if(0<length / packingLength) {
                    var temp = new v128(ushort.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    ushort* tempAsArray = (ushort*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = int.MaxValue;
              static int _min(int a, int b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, int* b) => new v256(
                        _min(a.SInt0, b[0]),
                        _min(a.SInt1, b[1]),
                        _min(a.SInt2, b[2]),
                        _min(a.SInt3, b[3]),
                        _min(a.SInt4, b[4]),
                        _min(a.SInt5, b[5]),
                        _min(a.SInt6, b[6]),
                        _min(a.SInt7, b[7])
                );
                
                var packingLength = sizeof(v256) / sizeof(int);
                 
                if(0<length / packingLength) {
                    var temp = new v256(int.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    int* tempAsArray = (int*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, int* b) => new v128(
                    _min(a.SInt0, b[0]),
                    _min(a.SInt1, b[1]),
                    _min(a.SInt2, b[2]),
                    _min(a.SInt3, b[3])
                );
                
                var packingLength = sizeof(v128) / sizeof(int);
                 
                if(0<length / packingLength) {
                    var temp = new v128(int.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    int* tempAsArray = (int*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = uint.MaxValue;
              static uint _min(uint a, uint b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, uint* b) => new v256(
                        _min(a.UInt0, b[0]),
                        _min(a.UInt1, b[1]),
                        _min(a.UInt2, b[2]),
                        _min(a.UInt3, b[3]),
                        _min(a.UInt4, b[4]),
                        _min(a.UInt5, b[5]),
                        _min(a.UInt6, b[6]),
                        _min(a.UInt7, b[7])
                );
                
                var packingLength = sizeof(v256) / sizeof(uint);
                 
                if(0<length / packingLength) {
                    var temp = new v256(uint.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    uint* tempAsArray = (uint*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, uint* b) => new v128(
                    _min(a.UInt0, b[0]),
                    _min(a.UInt1, b[1]),
                    _min(a.UInt2, b[2]),
                    _min(a.UInt3, b[3])
                );
                
                var packingLength = sizeof(v128) / sizeof(uint);
                 
                if(0<length / packingLength) {
                    var temp = new v128(uint.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    uint* tempAsArray = (uint*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = long.MaxValue;
              static long _min(long a, long b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, long* b) => new v256(
                        _min(a.SLong0, b[0]),
                        _min(a.SLong1, b[1]),
                        _min(a.SLong2, b[2]),
                        _min(a.SLong3, b[3])
                );
                
                var packingLength = sizeof(v256) / sizeof(long);
                 
                if(0<length / packingLength) {
                    var temp = new v256(long.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    long* tempAsArray = (long*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, long* b) => new v128(
                    _min(a.SLong0, b[0]),
                    _min(a.SLong1, b[1])
                );
                
                var packingLength = sizeof(v128) / sizeof(long);
                 
                if(0<length / packingLength) {
                    var temp = new v128(long.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    long* tempAsArray = (long*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = ulong.MaxValue;
              static ulong _min(ulong a, ulong b) =>a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, ulong* b) => new v256(
                        _min(a.ULong0, b[0]),
                        _min(a.ULong1, b[1]),
                        _min(a.ULong2, b[2]),
                        _min(a.ULong3, b[3])
                );
                
                var packingLength = sizeof(v256) / sizeof(ulong);
                 
                if(0<length / packingLength) {
                    var temp = new v256(ulong.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    ulong* tempAsArray = (ulong*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, ulong* b) => new v128(
                    _min(a.ULong0, b[0]),
                    _min(a.ULong1, b[1])
                );
                
                var packingLength = sizeof(v128) / sizeof(ulong);
                 
                if(0<length / packingLength) {
                    var temp = new v128(ulong.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    ulong* tempAsArray = (ulong*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = float.MaxValue;
            static float _min(float a, float b) =>IsNeonSupported?math.min(a,b): a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
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
                 
                if(0<length / packingLength) {
                    var temp = new v256(float.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    float* tempAsArray = (float*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, float* b) => new v128(
                    _min(a.Float0, b[0]),
                    _min(a.Float1, b[1]),
                    _min(a.Float2, b[2]),
                    _min(a.Float3, b[3])
                );
                
                var packingLength = sizeof(v128) / sizeof(float);
                 
                if(0<length / packingLength) {
                    var temp = new v128(float.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    float* tempAsArray = (float*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
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
            var tempResult = double.MaxValue;
            static double _min(double a, double b) =>IsNeonSupported?math.min(a,b): a < b ? a : b;
            var index= 0;
            if(BurstHelpers.IsV256Supported){
                static v256 _min256(v256 a, double* b) => new v256(
                        _min(a.Double0, b[0]),
                        _min(a.Double1, b[1]),
                        _min(a.Double2, b[2]),
                        _min(a.Double3, b[3])
                );
                
                var packingLength = sizeof(v256) / sizeof(double);
                 
                if(0<length / packingLength) {
                    var temp = new v256(double.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min256(temp, ptr+index);
                    }
                    double* tempAsArray = (double*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }    
             }else if(BurstHelpers.IsV128Supported){
                static v128 _min128(v128 a, double* b) => new v128(
                    _min(a.Double0, b[0]),
                    _min(a.Double1, b[1])
                );
                
                var packingLength = sizeof(v128) / sizeof(double);
                 
                if(0<length / packingLength) {
                    var temp = new v128(double.MaxValue);
                    for (; index < length-packingLength; index+=packingLength) {
                        temp = _min128(temp, ptr+index);
                    }
                    double* tempAsArray = (double*) &temp;
                    for (int i = 0; i < packingLength; i++) {
                        tempResult = _min(tempResult, tempAsArray[i]);
                    }
                }
             }
             for (; index < length; index++) {
                 tempResult = _min(tempResult, ptr[index]);
             }
             result =  tempResult;
           
            
             for (var i = 0; i < length; i++) {
                tempResult = _min(tempResult, ptr[i]);
             }
             result = tempResult;
        }
        
    }
}