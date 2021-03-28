using System.Linq;

namespace Exercism.CSharp.Solutions.BobExercise
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            if (statement.IsSilence())
            {
                return "Fine. Be that way!";
            }

            if (statement.IsShouting() && statement.IsQuestion())
            {
                return "Calm down, I know what I'm doing!";
            }

            if (statement.IsQuestion())
            {
                return "Sure.";
            }

            if (statement.IsShouting())
            {
                return "Whoa, chill out!";
            }

            return "Whatever.";
        }

        private static bool IsShouting(this string message) =>
            message.Any(char.IsLetter) && message == message.ToUpper();

        private static bool IsQuestion(this string message) =>
            message.TrimEnd().EndsWith("?");

        private static bool IsSilence(this string message) =>
            string.IsNullOrWhiteSpace(message);
    }
}