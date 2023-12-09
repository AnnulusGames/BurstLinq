using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;

namespace BurstLinq.Tests
{
    public class SequenceEqualPerformanceTest
    {
        const int WarmupCount = 10;
        const int MeasurementCount = 100;

        static void Test_Linq(int size)
        {
            var array1 = Enumerable.Range(0, size).ToArray();
            var array2 = Enumerable.Range(0, size).ToArray();

            Measure.Method(() =>
            {
                Enumerable.SequenceEqual(array1, array2);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        static void Test_BurstLinq(int size)
        {
            var array1 = Enumerable.Range(0, size).ToArray();
            var array2 = Enumerable.Range(0, size).ToArray();

            Measure.Method(() =>
            {
                BurstLinqExtensions.SequenceEqual(array1, array2);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void SequenceEqual_Linq_Int_1000() => Test_Linq(1000);

        [Test, Performance]
        public void SequenceEqual_Linq_Int_10000() => Test_Linq(10000);

        [Test, Performance]
        public void SequenceEqual_Linq_Int_100000() => Test_Linq(100000);

        [Test, Performance]
        public void SequenceEqual_BurstLinq_Int_1000() => Test_BurstLinq(1000);

        [Test, Performance]
        public void SequenceEqual_BurstLinq_Int_10000() => Test_BurstLinq(10000);

        [Test, Performance]
        public void SequenceEqual_BurstLinq_Int_100000() => Test_BurstLinq(100000);
    }

}