using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.PangramExercise
{
    public static class Pangram
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static bool IsPangram(string input) =>
            !string.IsNullOrWhiteSpace(input) &&
            Alphabet.All(s => input.Contains(s, StringComparison.OrdinalIgnoreCase));
    }
}