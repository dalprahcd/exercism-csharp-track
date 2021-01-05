using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.AffineCipherExercise
{
    public static class AffineCipher
    {
        private const int M = 26;
        private const int LetterCount = 5;

        public static string Encode(string plainText, int a, int b)
        {
            if (GreatestCommonDivisor(a, M) != 1)
            {
                throw new ArgumentException("Error: a and m must be coprime.", nameof(a));
            }

            var cipheredText = plainText
                                .ToLower()
                                .Where(c => char.IsLetterOrDigit(c))
                                .Select(c => c.Encrypt(a, b))
                                .ToList();

            for (int i = LetterCount; i < cipheredText.Count; i += LetterCount + 1)
            {
                cipheredText.Insert(i, ' ');
            }

            return new string(cipheredText.ToArray());
        }

        public static string Decode(string cipheredText, int a, int b)
        {
            if (GreatestCommonDivisor(a, M) != 1)
            {
                throw new ArgumentException("Error: a and m must be coprime.", nameof(a));
            }

            var plainText = cipheredText
                                .ToLower()
                                .Where(c => char.IsLetterOrDigit(c))
                                .Select(c => c.Decrypt(a, b))
                                .ToArray();

            return new string(plainText);
        }

        private static char Encrypt(this char ch, int a, int b)
        {
            if (char.IsDigit(ch))
            {
                return ch;
            }

            int x = ch - 'a';
            int Ex = ((a * x) + b) % M;

            return (char)(Ex + 'a');
        }

        private static char Decrypt(this char ch, int a, int b)
        {
            if (char.IsDigit(ch))
            {
                return ch;
            }

            int aInv = ModularMultiplicativeInverse(a);

            int x = ch - 'a';
            int Dx = (aInv * (x - b)) % M;

            if (Dx < 0) { Dx += M; }

            return (char)(Dx + 'a');
        }

        private static int ModularMultiplicativeInverse(int a)
        {
            for (int x = 0; x < M; x++)
            {
                if ((a * x) % M == 1)
                {
                    return x;
                }
            }

            throw new ArgumentException("No multiplicative inverse found!", nameof(a));
        }

        private static int GreatestCommonDivisor(int x, int y)
        {
            while (x != 0 && y != 0)
            {
                if (x > y)
                {
                    x %= y;
                }
                else
                {
                    y %= x;
                }
            }

            return x | y;
        }
    }
}