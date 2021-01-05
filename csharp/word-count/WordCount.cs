using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.WordCountExercise
{
    public static class WordCount
    {
        private static readonly char[] _separators = { ' ', '.', ',', '\n'};

        public static IDictionary<string, int> CountWords(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                throw new ArgumentException("String is null or empty", nameof(phrase));
            }

            var output = new Dictionary<string, int>();

            foreach (var word in SeparateWords(phrase))
            {
                if (!output.ContainsKey(word))
                {
                    output.Add(word, 0);
                }

                output[word]++;
            }

            return output;
        }

        private static IEnumerable<string> SeparateWords(string phrase)
        {
            var text = phrase
                        .ToLower()
                        .Split(_separators, StringSplitOptions.RemoveEmptyEntries);

            var punctuation = phrase
                                .Where(c => !char.IsLetterOrDigit(c))
                                .Distinct()
                                .ToArray();

            foreach (var word in text)
            {
                yield return word.Trim(punctuation);
            }
        }
    }
}