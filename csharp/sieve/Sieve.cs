using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.SieveExercise
{
    public static class Sieve
    {
        public static IEnumerable<int> Primes(int limit)
        {
            if (limit < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(limit));
            }

            Dictionary<int, bool> sieve = Enumerable
                                            .Range(2, limit - 1)
                                            .ToDictionary(i => i, _ => false);

            foreach (var item in sieve.Keys.ToArray())
            {
                int factor = 2;
                int multiple = item * factor;
                do
                {
                    sieve[multiple] = true;
                    factor++;
                    multiple = item * factor;
                }
                while (multiple < limit);
            }

            return sieve
                    .Where(k => !k.Value)
                    .Select(k => k.Key);
        }
    }
}