using System;
using System.Collections.Generic;

namespace Exercism.CSharp.Solutions.PrimeFactorsExercise
{
    public static class PrimeFactors
    {
        public static IEnumerable<long> Factors(long number)
        {
            // While is an even number, return 2
            while (number % 2 == 0)
            {
                yield return 2;
                number /= 2;
            }

            // Now check for division for odd numbers
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    yield return i;
                    number /= i;
                }
            }

            // Return the remaining of the division
            if (number > 2)
            {
                yield return number;
            }
        }
    }
}