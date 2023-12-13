using Unity.Burst.Intrinsics;

namespace BurstLinq
{
    public static unsafe class BurstHelpers
    {
        internal static bool IsFloatingPoint256Supported => X86.Avx.IsAvxSupported;
        internal static bool IsInteger256Supported => X86.Avx2.IsAvx2Supported;
        internal static bool IsV256Supported => X86.Avx2.IsAvx2Supported;
        internal static bool IsV128Supported => Arm.Neon.IsNeonSupported||X86.Sse4_1.IsSse41Supported;
    }
}