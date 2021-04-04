using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Exercism.CSharp.Solutions.ParallelLetterFrequencyExercise
{
    public static class ParallelLetterFrequency
    {
        public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
        {
            var letterFrequency = new ConcurrentDictionary<char, int>();

            Parallel.ForEach(
                texts.Where(text => !string.IsNullOrEmpty(text)).Select(text => text.ToLower()),
                text =>
                {
                    foreach (var letter in text.Where(char.IsLetter))
                    {
                        letterFrequency.AddOrUpdate(
                            letter,
                            1,
                            (_, oldValue) => ++oldValue);
                    }
                });

            return new Dictionary<char, int>(letterFrequency);
        }
    }
}