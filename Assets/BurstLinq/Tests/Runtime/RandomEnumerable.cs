using System.Collections.Generic;
using UnityEngine;

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
    }
}