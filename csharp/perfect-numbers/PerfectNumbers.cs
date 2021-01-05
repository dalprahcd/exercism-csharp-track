using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.PerfectNumbersExercise
{
    public enum Classification
    {
        Perfect     = 0,
        Abundant    = 1,
        Deficient   = -1
    }

    public static class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            int aliquotSum = Enumerable
                                .Range(1, number / 2)
                                .Where(x => number % x == 0)
                                .Sum();

            return (Classification) aliquotSum.CompareTo(number);
        }
    }
}