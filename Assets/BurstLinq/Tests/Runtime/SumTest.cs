using System;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class SumTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test]
        public void Test_Sum_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.RepeatInt(0, 100, 1000).ToList();

                var result1 = Enumerable.Sum(list);
                var result2 = BurstLinqExtensions.Sum(list);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Sum_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.RepeatInt(0, 100, 100).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Sum_Float_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.RepeatFloat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.1f);
            }
        }
    }
}