using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.PerfectNumbersExercise
{
    public enum Classification
    {
        Perfect,
        Abundant,
        Deficient
    }

    public static class PerfectNumbers
    {
        public static Classification Classify(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            int aliquotSum = Enumerable.Range(1, number / 2)
                                .Where(x => number % x == 0)
                                .Sum();


            if (aliquotSum > number)
            {
                return Classification.Abundant;
            }

            if (aliquotSum < number)
            {
                return Classification.Deficient;
            }

            return Classification.Perfect;
        }
    }
}