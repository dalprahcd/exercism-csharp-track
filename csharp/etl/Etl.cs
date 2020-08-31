using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.EtlExercise
{
    public static class Etl
    {
        public static Dictionary<string, int> Transform(Dictionary<int, string[]> old) =>
            old
            .SelectMany(keyPair => keyPair.Value.Select(letter => (keyPair, letter)))
            .ToDictionary(p => p.letter.ToLower(), p => p.keyPair.Key);
    }
}