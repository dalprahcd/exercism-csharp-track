using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.SeriesExercise
{
    public static class Series
    {
        public static IEnumerable<string> Slices(string numbers, int sliceLength)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                throw new ArgumentException(nameof(numbers));
            }

            if (sliceLength < 1 || sliceLength > numbers.Length)
            {
                throw new ArgumentException(nameof(sliceLength));
            }

            return Enumerable
                        .Range(0, numbers.Length - sliceLength + 1)
                        .Select(i => numbers.Substring(i, sliceLength));
        }
    }
}