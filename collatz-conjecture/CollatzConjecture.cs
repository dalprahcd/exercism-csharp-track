using System;

namespace Exercism.CSharp.Solutions.CollatzConjectureExercise
{
    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            int steps = 0;

            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1;
                }

                steps++;
            }

            return steps;
        }
    }
}