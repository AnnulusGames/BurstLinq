using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace BurstLinq
{
    [BurstCompile]
    internal static unsafe class CmpHelpers
    {
        [BurstCompile]
        public static bool MemCmp(void* ptr1, void* ptr2, long size)
        {
            return UnsafeUtility.MemCmp(ptr1, ptr2, size) == 0;
        }

        [BurstCompile]
        public static bool FloatCmp(float* ptr1, float* ptr2, [AssumeRange(1, long.MaxValue)] long length)
        {
            long index = 0;
            if (BurstHelpers.IsV256Supported)
            {
                static bool8 _equals256(v256 a, v256 b)
                {
                    return new bool8(
                        a.Float0 == b.Float0,
                        a.Float1 == b.Float1,
                        a.Float2 == b.Float2,
                        a.Float3 == b.Float3,
                        a.Float4 == b.Float4,
                        a.Float5 == b.Float5,
                        a.Float6 == b.Float6,
                        a.Float7 == b.Float7
                    );
                }

                var packingLength = sizeof(v256) / sizeof(float);

                for (; index < length - packingLength; index += packingLength)
                {
                    if (!_equals256(*(v256*)(ptr1 + index), *(v256*)(ptr2 + index)).all())
                        return false;
                }
            }
            else if (BurstHelpers.IsV128Supported)
            {
                var packingLength = sizeof(v128) / sizeof(float);

                for (; index < length - packingLength; index += packingLength)
                {
                    if (math.any(*(float4*)(ptr1 + index) != *(float4*)(ptr2 + index))) return false;
                }
            }

            for (; index < length; index++)
            {
                if (ptr1[index] != ptr2[index]) return false;
            }

            return true;
        }

        [BurstCompile]
        public static bool DoubleCmp(double* ptr1, double* ptr2, [AssumeRange(1, long.MaxValue)] long length)
        {
            long index = 0;
            if (BurstHelpers.IsV256Supported)
            {
                var packingLength = sizeof(v256) / sizeof(double);

                for (; index < length - packingLength; index += packingLength)
                {
                    if (math.any(*(double4*)(ptr1 + index) != *(double4*)(ptr2 + index))) return false;
                }
            }
            else if (BurstHelpers.IsV128Supported)
            {
                static bool _equals(v128 a, v128 b)
                {
                    return a.Double0 == b.Double0 && a.Double1 == b.Double1;
                }
                var packingLength = sizeof(v128) / sizeof(double);

                for (; index < length - packingLength; index += packingLength)
                {
                    if (math.any(*(double2*)(ptr1 + index) != *(double2*)(ptr2 + index))) return false;
                }
            }

            for (; index < length; index++)
            {
                if (ptr1[index] != ptr2[index]) return false;
            }
            return true;
        }

    }
}