using System;
using System.Linq;
using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class MinTest
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
                var list = RandomEnumerable.Repeat(0, 100, 1000).ToList();

                var result1 = Enumerable.Min(list);
                var result2 = BurstLinqExtensions.Min(list);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Byte_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat((byte)0, (byte)100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_SByte_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat((sbyte)0, (sbyte)100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Short_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat((short)-100, (short)100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_UShort_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat((ushort)0, (ushort)100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Int_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(-100, 100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_UInt_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(0, 100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Long_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(-100L, 100L, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_ULong_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(0L, 100L, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Float_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.001f);
            }
        }

        [Test]
        public void Test_Min_Double_Array()
        {
            for (int i = 0; i < IterationCount; i++)
            {
                var array = RandomEnumerable.Repeat(0.0, 100.0, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.IsTrue(Math.Abs(result1 - result2) < 0.00001);
            }
        }
    }
}