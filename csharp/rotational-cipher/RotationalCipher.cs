using System.Linq;

namespace Exercism.CSharp.Solutions.RotationalCipherExercise
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            var cipheredText = text
                                .Select(c => c.Encrypt(shiftKey))
                                .ToArray();

            return new string(cipheredText);
        }

        private static char Encrypt(this char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            int offset = char.IsUpper(ch) ? 'A' : 'a';
            int rotated = (ch - offset + key) % 26;

            return (char)(rotated + offset);
        }
    }
}