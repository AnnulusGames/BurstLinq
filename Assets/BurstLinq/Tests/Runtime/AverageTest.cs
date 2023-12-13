using System;
using System.Linq;
using NUnit.Framework;
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
        public void Test_Average_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Average_Float_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Average(array);
                var result2 = BurstLinqExtensions.Average(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.001f);
            }
        }

        [Test]
        public void Test_Average_Int_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Average(list);
                var result2 = BurstLinqExtensions.Average(list);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}