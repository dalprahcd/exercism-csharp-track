using System.Linq;

namespace Exercism.CSharp.Solutions.DifferenceOfSquaresExercise
{
    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            var sum = Enumerable.Range(1, max).Sum();
            return sum * sum;
        }

        public static int CalculateSumOfSquares(int max) =>
            Enumerable.Range(1, max).Sum(x => x * x);

        public static int CalculateDifferenceOfSquares(int max)
        {
            // Let's not iterate two times
            var sum = 0;
            var sumSquare = 0;

            for (int i = 1; i < max + 1; i++)
            {
                sum += i;
                sumSquare += i * i;
            }

            return (sum * sum) - sumSquare;
        }
    }
}