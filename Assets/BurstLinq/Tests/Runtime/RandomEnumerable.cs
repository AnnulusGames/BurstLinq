using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace BurstLinq.Tests
{
    public static class RandomEnumerable
    {
        public static IEnumerable<int> Repeat(int min, int max, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return Random.Range(min, max);
            }
        }
        public static IEnumerable<float> Repeat(float min, float max, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return Random.Range(min, max);
            }
        }
        public static void Fill(this Span<int> span, int min, int max)
        {
            for (int i = 0; i < span.Length; i++)
            {
                span[i] = Random.Range(min, max);
            }
        }
        public static void Fill(this Span<float> span, float min, float max)
        {
            for (int i = 0; i < span.Length; i++)
            {
                span[i] = Random.Range(min, max);
            }
        }
    }
}