using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using System.Runtime.CompilerServices;
namespace BurstLinq
{
    public unsafe static partial class BurstLinqExtensions
    {
        public static bool Contains(this NativeList<byte> source, byte value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<byte> source, byte value)
        {
            return ContainsCore((byte*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<byte> source, byte value)
        {
            return ContainsCore((byte*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(byte* ptr, [AssumeRange(1, int.MaxValue)] int length, in byte value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(byte);

                  static bool32 _contains(v256 a, byte* b) => new bool32(
                     a.Byte0== b[0],
                    a.Byte1== b[1],
                    a.Byte2== b[2],
                    a.Byte3== b[3],
                    a.Byte4== b[4],
                    a.Byte5== b[5],
                    a.Byte6== b[6],
                    a.Byte7== b[7],
                    a.Byte8== b[8],
                    a.Byte9== b[9],
                    a.Byte10== b[10],
                    a.Byte11== b[11],
                    a.Byte12== b[12],
                    a.Byte13== b[13],
                    a.Byte14== b[14],
                    a.Byte15== b[15],
                    a.Byte16== b[16],
                    a.Byte17== b[17],
                    a.Byte18== b[18],
                    a.Byte19== b[19],
                    a.Byte20== b[20],
                    a.Byte21== b[21],
                    a.Byte22== b[22],
                    a.Byte23== b[23],
                    a.Byte24== b[24],
                    a.Byte25== b[25],
                    a.Byte26== b[26],
                    a.Byte27== b[27],
                    a.Byte28== b[28],
                    a.Byte29== b[29],
                    a.Byte30== b[30],
                    a.Byte31== b[31]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(byte);
              
                static bool16 _contains(v128 a, byte* b)  =>new bool16(
                     a.Byte0== b[0],
                    a.Byte1== b[1],
                    a.Byte2== b[2],
                    a.Byte3== b[3],
                    a.Byte4== b[4],
                    a.Byte5== b[5],
                    a.Byte6== b[6],
                    a.Byte7== b[7],
                    a.Byte8== b[8],
                    a.Byte9== b[9],
                    a.Byte10== b[10],
                    a.Byte11== b[11],
                    a.Byte12== b[12],
                    a.Byte13== b[13],
                    a.Byte14== b[14],
                    a.Byte15== b[15]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<sbyte> source, sbyte value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<sbyte> source, sbyte value)
        {
            return ContainsCore((sbyte*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<sbyte> source, sbyte value)
        {
            return ContainsCore((sbyte*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(sbyte* ptr, [AssumeRange(1, int.MaxValue)] int length, in sbyte value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(sbyte);

                  static bool32 _contains(v256 a, sbyte* b) => new bool32(
                     a.SByte0== b[0],
                    a.SByte1== b[1],
                    a.SByte2== b[2],
                    a.SByte3== b[3],
                    a.SByte4== b[4],
                    a.SByte5== b[5],
                    a.SByte6== b[6],
                    a.SByte7== b[7],
                    a.SByte8== b[8],
                    a.SByte9== b[9],
                    a.SByte10== b[10],
                    a.SByte11== b[11],
                    a.SByte12== b[12],
                    a.SByte13== b[13],
                    a.SByte14== b[14],
                    a.SByte15== b[15],
                    a.SByte16== b[16],
                    a.SByte17== b[17],
                    a.SByte18== b[18],
                    a.SByte19== b[19],
                    a.SByte20== b[20],
                    a.SByte21== b[21],
                    a.SByte22== b[22],
                    a.SByte23== b[23],
                    a.SByte24== b[24],
                    a.SByte25== b[25],
                    a.SByte26== b[26],
                    a.SByte27== b[27],
                    a.SByte28== b[28],
                    a.SByte29== b[29],
                    a.SByte30== b[30],
                    a.SByte31== b[31]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(sbyte);
              
                static bool16 _contains(v128 a, sbyte* b)  =>new bool16(
                     a.SByte0== b[0],
                    a.SByte1== b[1],
                    a.SByte2== b[2],
                    a.SByte3== b[3],
                    a.SByte4== b[4],
                    a.SByte5== b[5],
                    a.SByte6== b[6],
                    a.SByte7== b[7],
                    a.SByte8== b[8],
                    a.SByte9== b[9],
                    a.SByte10== b[10],
                    a.SByte11== b[11],
                    a.SByte12== b[12],
                    a.SByte13== b[13],
                    a.SByte14== b[14],
                    a.SByte15== b[15]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<short> source, short value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<short> source, short value)
        {
            return ContainsCore((short*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<short> source, short value)
        {
            return ContainsCore((short*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(short* ptr, [AssumeRange(1, int.MaxValue)] int length, in short value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(short);

                  static bool16 _contains(v256 a, short* b) => new bool16(
                     a.SShort0== b[0],
                    a.SShort1== b[1],
                    a.SShort2== b[2],
                    a.SShort3== b[3],
                    a.SShort4== b[4],
                    a.SShort5== b[5],
                    a.SShort6== b[6],
                    a.SShort7== b[7],
                    a.SShort8== b[8],
                    a.SShort9== b[9],
                    a.SShort10== b[10],
                    a.SShort11== b[11],
                    a.SShort12== b[12],
                    a.SShort13== b[13],
                    a.SShort14== b[14],
                    a.SShort15== b[15]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(short);
              
                static bool8 _contains(v128 a, short* b)  =>new bool8(
                     a.SShort0== b[0],
                    a.SShort1== b[1],
                    a.SShort2== b[2],
                    a.SShort3== b[3],
                    a.SShort4== b[4],
                    a.SShort5== b[5],
                    a.SShort6== b[6],
                    a.SShort7== b[7]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<ushort> source, ushort value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<ushort> source, ushort value)
        {
            return ContainsCore((ushort*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<ushort> source, ushort value)
        {
            return ContainsCore((ushort*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(ushort* ptr, [AssumeRange(1, int.MaxValue)] int length, in ushort value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(ushort);

                  static bool16 _contains(v256 a, ushort* b) => new bool16(
                     a.UShort0== b[0],
                    a.UShort1== b[1],
                    a.UShort2== b[2],
                    a.UShort3== b[3],
                    a.UShort4== b[4],
                    a.UShort5== b[5],
                    a.UShort6== b[6],
                    a.UShort7== b[7],
                    a.UShort8== b[8],
                    a.UShort9== b[9],
                    a.UShort10== b[10],
                    a.UShort11== b[11],
                    a.UShort12== b[12],
                    a.UShort13== b[13],
                    a.UShort14== b[14],
                    a.UShort15== b[15]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(ushort);
              
                static bool8 _contains(v128 a, ushort* b)  =>new bool8(
                     a.UShort0== b[0],
                    a.UShort1== b[1],
                    a.UShort2== b[2],
                    a.UShort3== b[3],
                    a.UShort4== b[4],
                    a.UShort5== b[5],
                    a.UShort6== b[6],
                    a.UShort7== b[7]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<int> source, int value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<int> source, int value)
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
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(int);

                  static bool8 _contains(v256 a, int* b) => new bool8(
                     a.SInt0== b[0],
                    a.SInt1== b[1],
                    a.SInt2== b[2],
                    a.SInt3== b[3],
                    a.SInt4== b[4],
                    a.SInt5== b[5],
                    a.SInt6== b[6],
                    a.SInt7== b[7]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(int);
              
                static bool4 _contains(v128 a, int* b)  =>new bool4(
                     a.SInt0== b[0],
                    a.SInt1== b[1],
                    a.SInt2== b[2],
                    a.SInt3== b[3]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<uint> source, uint value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<uint> source, uint value)
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
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(uint);

                  static bool8 _contains(v256 a, uint* b) => new bool8(
                     a.UInt0== b[0],
                    a.UInt1== b[1],
                    a.UInt2== b[2],
                    a.UInt3== b[3],
                    a.UInt4== b[4],
                    a.UInt5== b[5],
                    a.UInt6== b[6],
                    a.UInt7== b[7]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(uint);
              
                static bool4 _contains(v128 a, uint* b)  =>new bool4(
                     a.UInt0== b[0],
                    a.UInt1== b[1],
                    a.UInt2== b[2],
                    a.UInt3== b[3]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<long> source, long value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<long> source, long value)
        {
            return ContainsCore((long*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<long> source, long value)
        {
            return ContainsCore((long*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(long* ptr, [AssumeRange(1, int.MaxValue)] int length, in long value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(long);

                  static bool4 _contains(v256 a, long* b) => new bool4(
                     a.SLong0== b[0],
                    a.SLong1== b[1],
                    a.SLong2== b[2],
                    a.SLong3== b[3]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(long);
              
                static bool2 _contains(v128 a, long* b)  =>new bool2(
                     a.SLong0== b[0],
                    a.SLong1== b[1]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<ulong> source, ulong value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<ulong> source, ulong value)
        {
            return ContainsCore((ulong*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<ulong> source, ulong value)
        {
            return ContainsCore((ulong*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal static bool ContainsCore(ulong* ptr, [AssumeRange(1, int.MaxValue)] int length, in ulong value)
        {
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(ulong);

                  static bool4 _contains(v256 a, ulong* b) => new bool4(
                     a.ULong0== b[0],
                    a.ULong1== b[1],
                    a.ULong2== b[2],
                    a.ULong3== b[3]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(ulong);
              
                static bool2 _contains(v128 a, ulong* b)  =>new bool2(
                     a.ULong0== b[0],
                    a.ULong1== b[1]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<float> source, float value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<float> source, float value)
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
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(float);

                  static bool8 _contains(v256 a, float* b) => new bool8(
                     a.Float0== b[0],
                    a.Float1== b[1],
                    a.Float2== b[2],
                    a.Float3== b[3],
                    a.Float4== b[4],
                    a.Float5== b[5],
                    a.Float6== b[6],
                    a.Float7== b[7]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(float);
              
                static bool4 _contains(v128 a, float* b)  =>new bool4(
                     a.Float0== b[0],
                    a.Float1== b[1],
                    a.Float2== b[2],
                    a.Float3== b[3]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<double> source, double value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<double> source, double value)
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
             var index= 0;
            if(BurstHelpers.IsV256Supported){
                const int packingLength = 32 / sizeof(double);

                  static bool4 _contains(v256 a, double* b) => new bool4(
                     a.Double0== b[0],
                    a.Double1== b[1],
                    a.Double2== b[2],
                    a.Double3== b[3]);
                
                if(0<length / packingLength) {
                    var valueVector = new v256(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }else if(BurstHelpers.IsV128Supported){
                const int packingLength = 16 / sizeof(double);
              
                static bool2 _contains(v128 a, double* b)  =>new bool2(
                     a.Double0== b[0],
                    a.Double1== b[1]);
                if(0<length / packingLength) {
                    var valueVector = new v128(value);
                    for (; index < length-packingLength; index += packingLength) {
                        if(_contains(valueVector, ptr + index).any()) return true;
                    }
                }
            }
            for (; index < length; index++) {
                if (ptr[index]==value) return true;
            }
            return false;
        }
        public static bool Contains(this NativeList<Vector2> source, Vector2 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<Vector2> source, Vector2 value)
        {
            return ContainsCore((Vector2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector2> source, Vector2 value)
        {
            return ContainsCore((Vector2*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(Vector2* ptr, [AssumeRange(1, int.MaxValue)] int length, in Vector2 value)
        {
           var value2= new float4(value.x,value.y,value.x,value.y);
           if(ContainsCore((float4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore((Vector2Int*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector2Int> source, Vector2Int value)
        {
            return ContainsCore((Vector2Int*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(Vector2Int* ptr, [AssumeRange(1, int.MaxValue)] int length, in Vector2Int value)
        {
           var value2= new int4(value.x,value.y,value.x,value.y);
           if(ContainsCore((int4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<Vector3> source, Vector3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<Vector3> source, Vector3 value)
        {
            return ContainsCore((Vector3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector3> source, Vector3 value)
        {
            return ContainsCore((Vector3*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(Vector3* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector3 value)
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

        public  static bool Contains(this NativeSlice<Vector3Int> source, Vector3Int value)
        {
            return ContainsCore((Vector3Int*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector3Int> source, Vector3Int value)
        {
            return ContainsCore((Vector3Int*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(Vector3Int* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector3Int value)
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

        public  static bool Contains(this NativeSlice<Vector4> source, Vector4 value)
        {
            return ContainsCore((Vector4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<Vector4> source, Vector4 value)
        {
            return ContainsCore((Vector4*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(Vector4* ptr, [AssumeRange(0, int.MaxValue)] int length, in Vector4 value)
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

        public  static bool Contains(this NativeSlice<int2> source, int2 value)
        {
            return ContainsCore((int2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int2> source, int2 value)
        {
            return ContainsCore((int2*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(int2* ptr, [AssumeRange(1, int.MaxValue)] int length, in int2 value)
        {
           var value2= new int4(value.x,value.y,value.x,value.y);
           if(ContainsCore((int4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<int3> source, int3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<int3> source, int3 value)
        {
            return ContainsCore((int3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int3> source, int3 value)
        {
            return ContainsCore((int3*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(int3* ptr, [AssumeRange(0, int.MaxValue)] int length, in int3 value)
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

        public  static bool Contains(this NativeSlice<int4> source, int4 value)
        {
            return ContainsCore((int4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<int4> source, int4 value)
        {
            return ContainsCore((int4*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(int4* ptr, [AssumeRange(0, int.MaxValue)] int length, in int4 value)
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

        public  static bool Contains(this NativeSlice<uint2> source, uint2 value)
        {
            return ContainsCore((uint2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint2> source, uint2 value)
        {
            return ContainsCore((uint2*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(uint2* ptr, [AssumeRange(1, int.MaxValue)] int length, in uint2 value)
        {
           var value2= new uint4(value.x,value.y,value.x,value.y);
           if(ContainsCore((uint4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<uint3> source, uint3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<uint3> source, uint3 value)
        {
            return ContainsCore((uint3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint3> source, uint3 value)
        {
            return ContainsCore((uint3*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(uint3* ptr, [AssumeRange(0, int.MaxValue)] int length, in uint3 value)
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

        public  static bool Contains(this NativeSlice<uint4> source, uint4 value)
        {
            return ContainsCore((uint4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<uint4> source, uint4 value)
        {
            return ContainsCore((uint4*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(uint4* ptr, [AssumeRange(0, int.MaxValue)] int length, in uint4 value)
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

        public  static bool Contains(this NativeSlice<float2> source, float2 value)
        {
            return ContainsCore((float2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float2> source, float2 value)
        {
            return ContainsCore((float2*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(float2* ptr, [AssumeRange(1, int.MaxValue)] int length, in float2 value)
        {
           var value2= new float4(value.x,value.y,value.x,value.y);
           if(ContainsCore((float4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<float3> source, float3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<float3> source, float3 value)
        {
            return ContainsCore((float3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float3> source, float3 value)
        {
            return ContainsCore((float3*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(float3* ptr, [AssumeRange(0, int.MaxValue)] int length, in float3 value)
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

        public  static bool Contains(this NativeSlice<float4> source, float4 value)
        {
            return ContainsCore((float4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<float4> source, float4 value)
        {
            return ContainsCore((float4*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(float4* ptr, [AssumeRange(0, int.MaxValue)] int length, in float4 value)
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

        public  static bool Contains(this NativeSlice<double2> source, double2 value)
        {
            return ContainsCore((double2*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double2> source, double2 value)
        {
            return ContainsCore((double2*)source.GetUnsafePtr(), source.Length, value);
        }
        internal static bool ContainsCore(double2* ptr, [AssumeRange(1, int.MaxValue)] int length, in double2 value)
        {
           var value2= new double4(value.x,value.y,value.x,value.y);
           if(ContainsCore((double4*)ptr,length/2,value2)) return true;
            return (length%2==1)&&(ptr[length-1].Equals(value));
        }
        public static bool Contains(this NativeList<double3> source, double3 value)
        {
            return ContainsCore(source.GetUnsafePtr(), source.Length, value);
        }

        public  static bool Contains(this NativeSlice<double3> source, double3 value)
        {
            return ContainsCore((double3*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double3> source, double3 value)
        {
            return ContainsCore((double3*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(double3* ptr, [AssumeRange(0, int.MaxValue)] int length, in double3 value)
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

        public  static bool Contains(this NativeSlice<double4> source, double4 value)
        {
            return ContainsCore((double4*)source.GetUnsafePtr(), source.Length, value);
        }

        public static bool Contains(this NativeArray<double4> source, double4 value)
        {
            return ContainsCore((double4*)source.GetUnsafePtr(), source.Length, value);
        }
        [BurstCompile]
        internal  static bool ContainsCore(double4* ptr, [AssumeRange(0, int.MaxValue)] int length, in double4 value)
        {
            for (int i = 0; i < length; i++)
            {
                if (ptr[i].Equals(value)) return true;
            }

            return false;
        }
    }
}