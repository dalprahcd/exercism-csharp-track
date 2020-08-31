using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercism.CSharp.Solutions.RaindropsExercise
{
    public static class Raindrops
    {
        public static string Convert(int number)
        {
            IEnumerable<int> factors = Enumerable
                                            .Range(1, number)
                                            .Where(n => number % n == 0);

            if (factors.All(f => f != 3 && f != 5 && f != 7))
            {
                return number.ToString();
            }

            StringBuilder rainsDropBuilder = new StringBuilder();

            if (factors.Contains(3))
            {
                rainsDropBuilder.Append("Pling");
            }

            if (factors.Contains(5))
            {
                rainsDropBuilder.Append("Plang");
            }

            if (factors.Contains(7))
            {
                rainsDropBuilder.Append("Plong");
            }

            return rainsDropBuilder.ToString();
        }
    }
}