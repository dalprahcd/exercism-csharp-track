using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.AcronymExercise
{
    public static class Acronym
    {
        private static readonly char[] separators = { ' ', ',', '/', '-', '_' };

        public static string Abbreviate(string phrase) =>
            string.IsNullOrEmpty(phrase)
            ? string.Empty
            : new string(phrase
                        .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s[0])
                        .ToArray()).ToUpper();
    }
}