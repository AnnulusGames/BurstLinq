using System;
using System.Linq;
using System.Runtime.InteropServices;
using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public class ContainsTest
    {
        [SetUp]
        public void SetUp()
        {
            Random.InitState((int)DateTime.Now.Ticks);
        }

        [Test]
        public void Test_Contains_Int_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.Repeat(0, 100, 100).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(array, value);
                var result2 = BurstLinqExtensions.Contains(array, value);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Contains_Float_Array()
        {
            for (int i = 0; i < 100; i++)
            {
                var array = RandomEnumerable.Repeat(0f, 100f, 1000).ToArray();
                var value = Random.Range(0, 2) == 0 ? 50f : -1f;

                var result1 = Enumerable.Contains(array, value);
                var result2 = BurstLinqExtensions.Contains(array, value);

                Assert.AreEqual(result1, result2);
            }
        }

        [Test]
        public void Test_Contains_Int_List()
        {
            for (int i = 0; i < 100; i++)
            {
                var list = RandomEnumerable.Repeat(0, 100, 1000).ToList();
                var value = Random.Range(0, 2) == 0 ? 50 : -1;

                var result1 = Enumerable.Contains(list, value);
                var result2 = BurstLinqExtensions.Contains(list, value);

                Assert.AreEqual(result1, result2);
            }
        }
        [Test]
        public void Test_Contains_Vector2Int_Array()
        {
            var array= new Vector2Int[1000];
            var span = MemoryMarshal.Cast<Vector2Int, int>(array);
            for (int i = 0; i < 100; i++) {
                RandomEnumerable.Fill(span, 0, 30);
                var value =new Vector2Int( Random.Range(0, 30), Random.Range(0, 30)) ;
                
                var result1 = false;
                foreach (var v in array) {
                    if(v == value) {
                        result1 = true;
                        break;
                    }
                }
                
                var result2 = BurstLinqExtensions.Contains(array, value);

                Assert.AreEqual(result1, result2);
            }
        }
    }
}