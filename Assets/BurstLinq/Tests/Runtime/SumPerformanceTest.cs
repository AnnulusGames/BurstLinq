using System;
using System.Linq;
using NUnit.Framework;
using Unity.Mathematics;
using Unity.PerformanceTesting;
using UnityEngine;

namespace BurstLinq.Tests
{
    public class SumPerformanceTest
    {
        const int WarmupCount = 10;
        const int MeasurementCount = 100;

        const int ArraySize = 100000;

        static readonly int[] intArray = Enumerable.Repeat(1, ArraySize).ToArray();
        static readonly long[] longArray = Enumerable.Repeat((long)1, ArraySize).ToArray();
        static readonly float[] floatArray = Enumerable.Repeat(1f, ArraySize).ToArray();
        static readonly double[] doubleArray = Enumerable.Repeat(1.0, ArraySize).ToArray();
        static readonly Vector3[] vector3Array = Enumerable.Repeat(Vector3.one, ArraySize).ToArray();
        static readonly float3[] float3Array = Enumerable.Repeat(new float3(1f, 1f, 1f), ArraySize).ToArray();

        [Test, Performance]
        public void Sum_Int_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Sum(intArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Int_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(intArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Long_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Sum(longArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Long_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(longArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }


        [Test, Performance]
        public void Sum_Float_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Sum(floatArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Float_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(floatArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Double_Linq()
        {
            Measure.Method(() =>
            {
                Enumerable.Sum(doubleArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Double_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(doubleArray);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Vector3_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(vector3Array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }

        [Test, Performance]
        public void Sum_Float3_BurstLinq()
        {
            Measure.Method(() =>
            {
                BurstLinqExtensions.Sum(float3Array);
            })
            .WarmupCount(WarmupCount)
            .MeasurementCount(MeasurementCount)
            .Run();
        }
    }
}
