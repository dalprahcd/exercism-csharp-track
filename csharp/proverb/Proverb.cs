using System;
using System.Collections.Generic;

namespace Exercism.CSharp.Solutions.ProverbExercise
{
    public static class Proverb
    {
        public static IEnumerable<string> Recite(string[] subjects)
        {
            if (subjects?.Length == 0)
            {
                return Array.Empty<string>();
            }

            List<string> proverb = new List<string>();

            for (int i = 0; i < subjects.Length - 1; i++)
            {
                proverb.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
            }

            proverb.Add($"And all for the want of a {subjects[0]}.");

            return proverb;
        }
    }
}