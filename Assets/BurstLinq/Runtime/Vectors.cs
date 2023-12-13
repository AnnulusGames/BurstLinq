using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Mathematics;

namespace BurstLinq
{
    internal static class VectorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(this bool2 v) => v.x || v.y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(this bool3 v) => v.x || v.y || v.z;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(this bool4 v) => v.x || v.y || v.z || v.w;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(this bool2 v) => v.x && v.y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(this bool3 v) => v.x && v.y && v.z;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(this bool4 v) => v.x && v.y && v.z && v.w;
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit, Size = 32 * sizeof(bool))]
    internal struct bool32
    {
        [FieldOffset(0)]
        public bool x0;

        [FieldOffset(1)]
        public bool x1;

        [FieldOffset(2)]
        public bool x2;

        [FieldOffset(3)]
        public bool x3;

        [FieldOffset(4)]
        public bool x4;

        [FieldOffset(5)]
        public bool x5;

        [FieldOffset(6)]
        public bool x6;

        [FieldOffset(7)]
        public bool x7;

        [FieldOffset(8)]
        public bool x8;

        [FieldOffset(9)]
        public bool x9;

        [FieldOffset(10)]
        public bool x10;

        [FieldOffset(11)]
        public bool x11;

        [FieldOffset(12)]
        public bool x12;

        [FieldOffset(13)]
        public bool x13;

        [FieldOffset(14)]
        public bool x14;

        [FieldOffset(15)]
        public bool x15;

        [FieldOffset(16)]
        public bool x16;

        [FieldOffset(17)]
        public bool x17;

        [FieldOffset(18)]
        public bool x18;

        [FieldOffset(19)]
        public bool x19;

        [FieldOffset(20)]
        public bool x20;

        [FieldOffset(21)]
        public bool x21;

        [FieldOffset(22)]
        public bool x22;

        [FieldOffset(23)]
        public bool x23;

        [FieldOffset(24)]
        public bool x24;

        [FieldOffset(25)]
        public bool x25;

        [FieldOffset(26)]
        public bool x26;

        [FieldOffset(27)]
        public bool x27;

        [FieldOffset(28)]
        public bool x28;

        [FieldOffset(29)]
        public bool x29;

        [FieldOffset(30)]
        public bool x30;

        [FieldOffset(31)]
        public bool x31;

        public bool32(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15, bool x16, bool x17, bool x18, bool x19, bool x20, bool x21, bool x22, bool x23, bool x24, bool x25, bool x26, bool x27, bool x28, bool x29, bool x30, bool x31)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.x6 = x6;
            this.x7 = x7;
            this.x8 = x8;
            this.x9 = x9;
            this.x10 = x10;
            this.x11 = x11;
            this.x12 = x12;
            this.x13 = x13;
            this.x14 = x14;
            this.x15 = x15;
            this.x16 = x16;
            this.x17 = x17;
            this.x18 = x18;
            this.x19 = x19;
            this.x20 = x20;
            this.x21 = x21;
            this.x22 = x22;
            this.x23 = x23;
            this.x24 = x24;
            this.x25 = x25;
            this.x26 = x26;
            this.x27 = x27;
            this.x28 = x28;
            this.x29 = x29;
            this.x30 = x30;
            this.x31 = x31;
        }

        public bool any() => x0 || x1 || x2 || x3 || x4 || x5 || x6 || x7 || x8 || x9 || x10 || x11 || x12 || x13 || x14 || x15 || x16 || x17 || x18 || x19 || x20 || x21 || x22 || x23 || x24 || x25 || x26 || x27 || x28 || x29 || x30 || x31;
        public bool all() => x0 && x1 && x2 && x3 && x4 && x5 && x6 && x7 && x8 && x9 && x10 && x11 && x12 && x13 && x14 && x15 && x16 && x17 && x18 && x19 && x20 && x21 && x22 && x23 && x24 && x25 && x26 && x27 && x28 && x29 && x30 && x31;
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit, Size = 16 * sizeof(bool))]
    internal struct bool16
    {
        [FieldOffset(0)]
        public bool x0;

        [FieldOffset(1)]
        public bool x1;

        [FieldOffset(2)]
        public bool x2;

        [FieldOffset(3)]
        public bool x3;

        [FieldOffset(4)]
        public bool x4;

        [FieldOffset(5)]
        public bool x5;

        [FieldOffset(6)]
        public bool x6;

        [FieldOffset(7)]
        public bool x7;

        [FieldOffset(8)]
        public bool x8;

        [FieldOffset(9)]
        public bool x9;

        [FieldOffset(10)]

        public bool x10;

        [FieldOffset(11)]

        public bool x11;

        [FieldOffset(12)]

        public bool x12;

        [FieldOffset(13)]

        public bool x13;

        [FieldOffset(14)]

        public bool x14;

        [FieldOffset(15)]

        public bool x15;

        public bool16(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7, bool x8, bool x9, bool x10, bool x11, bool x12, bool x13, bool x14, bool x15)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.x6 = x6;
            this.x7 = x7;
            this.x8 = x8;
            this.x9 = x9;
            this.x10 = x10;
            this.x11 = x11;
            this.x12 = x12;
            this.x13 = x13;
            this.x14 = x14;
            this.x15 = x15;
        }


        public bool any() => x0 || x1 || x2 || x3 || x4 || x5 || x6 || x7 || x8 || x9 || x10 || x11 || x12 || x13 || x14 || x15;
        public bool all() => x0 && x1 && x2 && x3 && x4 && x5 && x6 && x7 || x8 && x9 && x10 && x11 && x12 && x13 && x14 && x15;
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit, Size = 8 * sizeof(bool))]
    internal struct bool8
    {
        [FieldOffset(0)]
        public bool x0;

        [FieldOffset(1)]
        public bool x1;

        [FieldOffset(2)]
        public bool x2;

        [FieldOffset(3)]
        public bool x3;

        [FieldOffset(4)]
        public bool x4;

        [FieldOffset(5)]
        public bool x5;

        [FieldOffset(6)]
        public bool x6;

        [FieldOffset(7)]
        public bool x7;
        public bool8(bool x0, bool x1, bool x2, bool x3, bool x4, bool x5, bool x6, bool x7)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.x5 = x5;
            this.x6 = x6;
            this.x7 = x7;
        }

        public bool any() => x0 || x1 || x2 || x3 || x4 || x5 || x6 || x7;
        public bool all() => x0 && x1 && x2 && x3 && x4 && x5 && x6 && x7;
    }
}