using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.SaddlePointsExercise
{
    public static class SaddlePoints
    {
        public static IEnumerable<(int, int)> Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix.Row(i).All(r => r <= matrix[i, j]) &&
                        matrix.Column(j).All(c => c >= matrix[i, j]))
                    {
                        yield return (i + 1, j + 1);
                    }
                }
            }
        }

        public static IEnumerable<T> Column<T>(this T[,] matrix, int column) =>
            Enumerable
                .Range(0, matrix.GetLength(0))
                .Select(x => matrix[x, column]);

        public static IEnumerable<T> Row<T>(this T[,] matrix, int row) =>
            Enumerable
                .Range(0, matrix.GetLength(1))
                .Select(x => matrix[row, x]);
    }
}