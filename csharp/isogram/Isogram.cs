using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.IsogramExercise
{
    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            if (word is null)
            {
                return false;
            }

            if (word.All(char.IsWhiteSpace))
            {
                return true;
            }

            var onlyLetters = word
                                .Where(char.IsLetter)
                                .Select(c => c.ToString());

            return onlyLetters.Count() == onlyLetters
                                            .Distinct(StringComparer.OrdinalIgnoreCase)
                                            .Count();
        }
    }
}