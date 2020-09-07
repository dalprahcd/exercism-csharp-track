namespace Exercism.CSharp.Solutions.SpiralMatrixExercise
{
    public static class SpiralMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            int[,] output = new int[size, size];

            int value = 1;
            int start = 0, end = size - 1;

            while (value <= size * size)
            {
                // Right direction
                for (int row = start; row <= end; row++)
                { output[start, row] = value++; }

                // Down direction
                for (int column = start + 1; column <= end; column++)
                { output[column, end] = value++; }

                // Left direction
                for (int row = end - 1; row >= start; row--)
                { output[end, row] = value++; }

                // Up direction
                for (int column = end - 1; column >= start + 1; column--)
                { output[column, start] = value++; }

                start++;
                end--;
            }

            return output;
        }
    }
}