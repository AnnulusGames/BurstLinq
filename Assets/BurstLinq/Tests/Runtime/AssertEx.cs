using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Assertions;

namespace BurstLinq.Tests
{
    public static class AssertEx
    {
        public static void AreApproximatelyEqual(float a, float b)
        {
            Assert.AreApproximatelyEqual(a, b, 0.1f);
        }

        public static void AreApproximatelyEqual(Vector2 a, Vector2 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
        }

        public static void AreApproximatelyEqual(Vector3 a, Vector3 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
            Assert.AreApproximatelyEqual(a.z, b.z, 0.1f);
        }

        public static void AreApproximatelyEqual(Vector4 a, Vector4 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
            Assert.AreApproximatelyEqual(a.z, b.z, 0.1f);
            Assert.AreApproximatelyEqual(a.w, b.w, 0.1f);
        }

        public static void AreApproximatelyEqual(double a, double b)
        {
            Assert.IsTrue(Math.Abs(a - b) < 0.001);
        }

        public static void AreApproximatelyEqual(double2 a, double2 b)
        {
            AreApproximatelyEqual(a.x, b.x);
            AreApproximatelyEqual(a.y, b.y);
        }

        public static void AreApproximatelyEqual(double3 a, double3 b)
        {
            AreApproximatelyEqual(a.x, b.x);
            AreApproximatelyEqual(a.y, b.y);
            AreApproximatelyEqual(a.z, b.z);
        }

        public static void AreApproximatelyEqual(double4 a, double4 b)
        {
            AreApproximatelyEqual(a.x, b.x);
            AreApproximatelyEqual(a.y, b.y);
            AreApproximatelyEqual(a.z, b.z);
            AreApproximatelyEqual(a.w, b.w);
        }

        public static void AreApproximatelyEqual(float2 a, float2 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
        }

        public static void AreApproximatelyEqual(float3 a, float3 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
            Assert.AreApproximatelyEqual(a.z, b.z, 0.1f);
        }

        public static void AreApproximatelyEqual(float4 a, float4 b)
        {
            Assert.AreApproximatelyEqual(a.x, b.x, 0.1f);
            Assert.AreApproximatelyEqual(a.y, b.y, 0.1f);
            Assert.AreApproximatelyEqual(a.z, b.z, 0.1f);
            Assert.AreApproximatelyEqual(a.w, b.w, 0.1f);
        }
    }
}