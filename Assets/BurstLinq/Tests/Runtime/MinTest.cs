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
        public void Test_Min_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.Repeat(0, 100, 100).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Min_Float_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.Repeat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Min(array);
                var result2 = BurstLinqExtensions.Min(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.001f);
            }
        }

        [Test]
        public void Test_Min_Int_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.Repeat(0, 100, 1000).ToList();

                var result1 = Enumerable.Min(list);
                var result2 = BurstLinqExtensions.Min(list);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}