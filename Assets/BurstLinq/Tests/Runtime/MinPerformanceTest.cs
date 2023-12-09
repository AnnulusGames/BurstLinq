using System.Linq;
using NUnit.Framework;
using Unity.Mathematics;
using Unity.PerformanceTesting;
using UnityEngine;

namespace BurstLinq.Tests
{
    public class MinPerformanceTest
    {
        const int WarmupCount = 10;
        const int MeasurementCount = 100;

        const int ArraySize = 100000;

        static readonly int[] intArray = Enumerable.Repeat(1, ArraySize).ToArray();
        static readonly long[] longArray = Enumerable.Repeat((long)1, ArraySize).ToArray();
        static readonly float[] floatArray = Enumerable.Repeat(1f, ArraySize).ToArray();
        static readonly double[] doubleArray = Enumerable.Repeat(1.0, ArraySize).ToArray();

        [Test, Performance]
        public void Min_Int_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(intArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Int_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(intArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Long_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(longArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Long_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(longArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }


        [Test, Performance]
        public void Min_Float_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(floatArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Float_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(floatArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Double_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Min(doubleArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Min_Double_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Min(doubleArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }
    }
}
