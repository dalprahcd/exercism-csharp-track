using System.Collections.Generic;

namespace Exercism.CSharp.Solutions.PascalsTriangleExercise
{
    public static class PascalsTriangle
    {
        public static IEnumerable<IEnumerable<int>> Calculate(int lines)
        {
            for (int line = 1; line <= lines; line++)
            {
                yield return CalculateLine(line);
            }
        }

        private static IEnumerable<int> CalculateLine(int line)
        {
            int c = 1;

            for (int i = 1; i <= line; i++)
            {
                yield return c;

                c = (c * (line - i)) / i;
            }
        }
    }
}