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
        public void Test_Sum_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.Repeat(0, 100, 100).ToArray();

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
                var array = RandomEnumerable.Repeat(0f, 100f, 1000).ToArray();

                var result1 = Enumerable.Sum(array);
                var result2 = BurstLinqExtensions.Sum(array);

                Assert.AreApproximatelyEqual(result1, result2, 0.1f);
            }
        }
        [Test]
        public void Test_Sum_Vector2_Array() {
            var array = new Vector2[1000];
            var span = MemoryMarshal.Cast<Vector2, float>(array);
            for (int i = 0; i < 100; i++)
            {
                span.Fill(0f, 100f);
                var result1 = new Vector2(0, 0);
                foreach (var v in array) {
                    result1+=v;
                }
                var result2 = BurstLinqExtensions.Sum(array);
                Assert.AreApproximatelyEqual(result1.x, result2.x, 0.1f);
                Assert.AreApproximatelyEqual(result1.y, result2.y, 0.1f);
            }
        }
        [Test]
        public void Test_Sum_Vector3Int_Array() {
            var array = new Vector3Int[1000];
            var span = MemoryMarshal.Cast<Vector3Int, int>(array);
            for (int i = 0; i < 100; i++)
            {
                span.Fill(0, 100);
                var result1 = new Vector3Int(0, 0);
                foreach (var v in array) {
                    result1+=v;
                }
                var result2 = BurstLinqExtensions.Sum(array);
                Assert.AreEqual(result1.x, result2.x);
                Assert.AreApproximatelyEqual(result1.y, result2.y);
            }
        }
        [Test]
        public void Test_Sum_Int_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.Repeat(0, 100, 1000).ToList();

                var result1 = Enumerable.Sum(list);
                var result2 = BurstLinqExtensions.Sum(list);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}