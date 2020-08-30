using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.ProteinTranslationExercise
{
    public static class ProteinTranslation
    {
        private const int codonSize = 3;
        private static readonly Dictionary<string, string> translations = new Dictionary<string, string>
        {
            ["AUG"] = "Methionine",
            ["UUU"] = "Phenylalanine",
            ["UUC"] = "Phenylalanine",
            ["UUA"] = "Leucine",
            ["UUG"] = "Leucine",
            ["UCU"] = "Serine",
            ["UCC"] = "Serine",
            ["UCA"] = "Serine",
            ["UCG"] = "Serine",
            ["UAU"] = "Tyrosine",
            ["UAC"] = "Tyrosine",
            ["UGU"] = "Cysteine",
            ["UGC"] = "Cysteine",
            ["UGG"] = "Tryptophan",
            ["UAA"] = "STOP",
            ["UAG"] = "STOP",
            ["UGA"] = "STOP"
        };

        public static IEnumerable<string> Proteins(string strand) =>
            Enumerable
                .Range(0, strand.Length / codonSize)
                .Select(i => strand.Substring(i * codonSize, codonSize))
                .Select(s => translations[s])
                .TakeWhile(s => s != "STOP");
    }
}