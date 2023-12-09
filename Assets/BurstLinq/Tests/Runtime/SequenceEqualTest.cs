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
        public void Test_SequenceEqual_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array1 = RandomEnumerable.Repeat(0, 2, 10).ToArray();
                var array2 = RandomEnumerable.Repeat(0, 2, 10).ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_SequenceEqual_Float_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var enumerable = RandomEnumerable.Repeat(0f, 1f, 10);
                var array1 = enumerable.ToArray();
                var array2 = enumerable.ToArray();

                var result1 = Enumerable.SequenceEqual(array1, array2);
                var result2 = BurstLinqExtensions.SequenceEqual(array1, array2);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_SequenceEqual_Int_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list1 = RandomEnumerable.Repeat(0, 2, 10).ToList();
                var list2 = RandomEnumerable.Repeat(0, 2, 10).ToList();

                var result1 = Enumerable.SequenceEqual(list1, list2);
                var result2 = BurstLinqExtensions.SequenceEqual(list1, list2);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}