using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.MatrixExercise
{
    public class Matrix
    {
        private readonly int[][] matrix;

        public Matrix(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            matrix = ParseMatrix(input);
        }

        public int Rows => matrix.GetLength(0);

        public int Cols => matrix.GetLength(1);

        public IEnumerable<int> Row(int row) => matrix[row - 1];

        public IEnumerable<int> Column(int col) =>
            Enumerable
                .Range(0, Rows)
                .Select(row => matrix[row][col - 1]);

        private int[][] ParseMatrix(string input)
        {
            var lines = input.Split(new[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);

            var result = new int[lines.Length][];

            int i = 0, j = 0;
            foreach (var line in lines)
            {
                var numbers = line.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                result[i] = new int[numbers.Length];

                foreach (var number in numbers)
                {
                    result[i][j] = int.Parse(number);
                    j++;
                }
                j = 0;
                i++;
            }

            return result;
        }
    }
}