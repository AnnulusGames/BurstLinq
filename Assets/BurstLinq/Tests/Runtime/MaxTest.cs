using System;
using System.Linq;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class MaxTest
    {
        const int IterationCount = 1000;

        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test]
        public void Test_List()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Max(list);
                var result2 = BurstLinqExtensions.Max(list);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_Byte_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatByte((byte)0, (byte)100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_SByte_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatSByte((sbyte)0, (sbyte)100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_Short_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatShort((short)-100, (short)100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_UShort_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatUShort((ushort)0, (ushort)100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_Int_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(-100, 100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_UInt_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_Long_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(-100L, 100L, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_ULong_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatLong(0L, 100L, 100).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Max_Float_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.001f);
            }
        }

        [Test]
        public void Test_Max_Double_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.RepeatDouble(0.0, 100.0, 1000).ToArray();

                var result1 = Enumerable.Max(array);
                var result2 = BurstLinqExtensions.Max(array);

                Assert.IsTrue(Math.Abs(result1 - result2) < 0.00001);
            }
        }
    }
}