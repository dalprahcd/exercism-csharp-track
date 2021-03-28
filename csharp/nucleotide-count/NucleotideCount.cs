using System;
using System.Collections.Generic;

namespace Exercism.CSharp.Solutions.NucleotideCountExercise
{
    public static class NucleotideCount
    {
        public static IDictionary<char, int> Count(string sequence)
        {
            var nucleotideCounts = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };

            foreach (var c in sequence)
            {
                if (nucleotideCounts.ContainsKey(c))
                {
                    nucleotideCounts[c]++;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            return nucleotideCounts;
        }
    }
}