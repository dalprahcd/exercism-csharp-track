using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.AnagramExercise
{
    public class Anagram
    {
        private readonly string word;

        public Anagram(string baseWord) => word = baseWord.ToLower();

        public IEnumerable<string> FindAnagrams(IEnumerable<string> potentialMatches)
        {
            foreach (var word in potentialMatches)
            {
                if (IsAnagram(this.word, word.ToLower()))
                {
                    yield return word;
                }
            }
        }

        private static bool IsAnagram(string a, string b) =>
            !a.SequenceEqual(b) &&
            a.OrderBy(c => c).SequenceEqual(b.OrderBy(c => c));
    }
}