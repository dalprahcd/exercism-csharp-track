using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.AllYourBaseExercise
{
    public static class AllYourBase
    {
        public static IEnumerable<int> Rebase(int inputBase, int[] inputDigits, int outputBase) =>
            inputBase < 2 || outputBase < 2 || inputDigits.Any(n => n < 0 || n >= inputBase)
                ? throw new ArgumentException()
                : Deconstruct(outputBase, Contruct(inputBase, inputDigits))
                    .DefaultIfEmpty()
                    .Reverse();

        private static int Contruct(int inputBase, int[] inputDigits)
        {
            int factor = 0;
            int output = 0;

            for (int i = inputDigits.Length - 1; i >= 0; i--)
            {
                output += inputDigits[i] * (int) Math.Pow(inputBase, factor);
                factor++;
            }

            return output;
        }

        private static IEnumerable<int> Deconstruct(int outputBase, int number)
        {
            while (number != 0)
            {
                yield return number % outputBase;
                number /= outputBase;
            }
        }
    }
}