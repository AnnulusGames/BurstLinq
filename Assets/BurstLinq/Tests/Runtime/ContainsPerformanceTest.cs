using System;
using System.Linq;
using NUnit.Framework;
using Unity.PerformanceTesting;

namespace BurstLinq.Tests
{
    public class ContainsPerformanceTest
    {
        const int WarmupCount = 10;
        const int MeasurementCount = 100;

        [Test, Performance]
        public void Contains_Linq_Int_10()
        {
            var intArray = Enumerable.Range(0, 10).ToArray();

            Measure.Method(() =>
            {
                Enumerable.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Contains_Linq_Int_1000()
        {
            var intArray = Enumerable.Range(0, 1000).ToArray();

            Measure.Method(() =>
            {
                Enumerable.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Contains_Linq_Int_100000()
        {
            var intArray = Enumerable.Range(0, 100000).ToArray();

            Measure.Method(() =>
            {
                Enumerable.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Contains_BurstLinq_Int_10()
        {
            var intArray = Enumerable.Range(0, 10).ToArray();

            Measure.Method(() =>
            {
                BurstLinqExtensions.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Contains_BurstLinq_Int_1000()
        {
            var intArray = Enumerable.Range(0, 1000).ToArray();

            Measure.Method(() =>
            {
                BurstLinqExtensions.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Contains_BurstLinq_Int_100000()
        {
            var intArray = Enumerable.Range(0, 100000).ToArray();

            Measure.Method(() =>
            {
                BurstLinqExtensions.Contains(intArray, intArray.Last());
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }
    }

}