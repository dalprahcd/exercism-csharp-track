using System.Collections.Generic;

namespace Exercism.CSharp.Solutions.PythagoreanTripletExercise
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            // We know previously that a < b < c
            // So we can assume a < sum / 3
            // And a < b < sum / 2

            for (int a = 1; a <= sum / 3; a++)
            {
                for (int b = a + 1; b <= sum / 2; b++)
                {
                    int c = sum - a - b;
                    if (IsPythagorean(a, b, c))
                    {
                        yield return (a, b, c);
                    }
                }
            }
        }

        private static bool IsPythagorean(int a, int b, int c) =>
            (a * a) + (b * b) == (c * c);
    }
}