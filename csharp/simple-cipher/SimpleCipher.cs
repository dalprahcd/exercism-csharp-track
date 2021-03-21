using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.SimpleCipherExercise
{
    public class SimpleCipher
    {
        private readonly int[] rotate;

        public SimpleCipher()
        {
            var rnd = new Random();

            rotate = Enumerable
                        .Range(0, 100)
                        .Select(_ => rnd.Next(0, 'z' - 'a'))
                        .ToArray();

            Key = new string(rotate.Select(i => (char)('a' + i)).ToArray());
        }

        public SimpleCipher(string key)
        {
            rotate = key.Select(c => c - 'a').ToArray();

            Key = key;
        }

        public string Key { get; }

        public string Encode(string plaintext)
        {
            var encoded = new char[plaintext.Length];

            for (int i = 0; i < plaintext.Length; i++)
            {
                encoded[i] = Shift(plaintext[i], rotate[i % rotate.Length]);
            }

            return new string(encoded);
        }

        public string Decode(string ciphertext)
        {
            var decoded = new char[ciphertext.Length];

            for (int i = 0; i < ciphertext.Length; i++)
            {
                decoded[i] = Shift(ciphertext[i], -rotate[i % rotate.Length]);
            }

            return new string(decoded);
        }

        public char Shift(int letter, int shift)
        {
            var output = letter + shift;

            if (output < 'a')
            {
                var diff = 'a' - output - 1;

                return (char)('z' - diff);
            }

            if (output > 'z')
            {
                var diff = output - 'z' - 1;

                return (char)('a' + diff);
            }

            return (char)output;
        }
    }
}