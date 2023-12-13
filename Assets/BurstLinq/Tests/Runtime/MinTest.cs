using System;
using System.Linq;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class MinTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test]
        public void Test_List()
        {
            for (int i = 0; i < 1000; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Min(list);
                var result2 = BurstLinqExtensions.Min(list);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Byte()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_SByte()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatSByte(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Short()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UShort()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatUShort(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Int()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_UInt()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatUInt(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Long()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatLong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_ULong()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatULong(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Float()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Array_Double()
        {
            for (int i = 0; i < 1000; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0, 100, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

    }
}