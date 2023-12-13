using System;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using Unity.Mathematics;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class AverageTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test]
        public void Test_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Average(list);
                var result2 = BurstLinqExtensions.Average(list);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                uint sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Long()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                ulong sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatVector2(0, 100, 1000).ToArray();

                Vector2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector2Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatVector2Int(0, 100, 1000).ToArray();

                Vector2Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatVector3(0, 100, 1000).ToArray();

                Vector3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector3Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatVector3Int(0, 100, 1000).ToArray();

                Vector3Int sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatVector4(0, 100, 1000).ToArray();

                Vector4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (Vector4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatInt2(0, 100, 1000).ToArray();

                int2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatInt3(0, 100, 1000).ToArray();

                int3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatInt4(0, 100, 1000).ToArray();

                int4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatFloat2(0, 100, 1000).ToArray();

                float2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatFloat3(0, 100, 1000).ToArray();

                float3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatFloat4(0, 100, 1000).ToArray();

                float4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (float4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatDouble2(0, 100, 1000).ToArray();

                double2 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double2)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatDouble3(0, 100, 1000).ToArray();

                double3 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double3)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatDouble4(0, 100, 1000).ToArray();

                double4 sum = default;
                for (int n = 0; n < array.Length; n++) sum += array[n];
                var result1 = (double4)sum / array.Length;
                var result2 = BurstLinqExtensions.Average(array);

                AssertEx.AreApproximatelyEqual(result1, result2);
            }
        }

    }
}