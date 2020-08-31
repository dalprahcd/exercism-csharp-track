using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.RnaTranscriptionExercise
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide) =>
            new string(nucleotide.Select(SwitchNucleotide).ToArray());

        private static char SwitchNucleotide(char nucleotide) =>
            nucleotide switch
            {
                'G' => 'C',
                'C' => 'G',
                'T' => 'A',
                'A' => 'U',
                _   => throw new ArgumentException("Invalid nucleotide parameter.", nameof(nucleotide)),
            };
    }
}