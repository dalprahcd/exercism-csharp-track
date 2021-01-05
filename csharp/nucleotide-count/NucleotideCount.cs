using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.NucleotideCountExercise
{
    public static class NucleotideCount
    {
        private static readonly char[] _nucleotide = { 'A', 'C', 'G', 'T' };

        public static IDictionary<char, int> Count(string sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            if (sequence.ToCharArray().Any(c => !_nucleotide.Contains(c)))
            {
                throw new ArgumentException(nameof(sequence));
            }

            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (var n in _nucleotide)
            {
                output.Add(n, sequence.ToCharArray().Count(c => c == n));
            }

            return output;
        }
    }
}