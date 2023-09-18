using NUnit.Framework;
using System;
using UnityEngine;

namespace Tests
{
    public class FactFilterTest
    {
        [Test]
        public void FactFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = FactFilter.fact(input);
            int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

            foreach (int i in output)
            {
                Debug.Log(i);
            }
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
