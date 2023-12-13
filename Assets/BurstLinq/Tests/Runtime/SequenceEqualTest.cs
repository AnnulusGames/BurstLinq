using System;
using System.Linq;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class SequenceEqualTest
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
                var list1 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();
                var list2 = RandomEnumerable.RepeatInt(0, 2, 10).ToList();

                var result1 = Enumerable.SequenceEqual(list1, list2);
                var result2 = BurstLinqExtensions.SequenceEqual(list1, list2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Byte()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_SByte()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatSByte(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Short()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UShort()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUShort(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Long()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatLong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatULong(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector2Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector2Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector3Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector3Int(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Vector4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatVector4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatUInt4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatFloat4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble2(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double3()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble3(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double4()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array1 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.RepeatDouble4(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

    }
}
