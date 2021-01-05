using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.CSharp.Solutions.BobExercise
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            if (string.IsNullOrWhiteSpace(statement))
            {
                return "Fine. Be that way!";
            }

            statement = statement.Trim();

            if (statement.IsShouting())
            {
                return statement.IsQuestion()
                            ? "Calm down, I know what I'm doing!"
                            : "Whoa, chill out!";
            }

            return statement.IsQuestion()
                    ? "Sure."
                    : "Whatever.";
        }

        private static bool IsShouting(this string text) =>
            !text.IsGreeting() &&
            (Regex.IsMatch(text, @"\!$") ||
            (text.Any(char.IsLetter) && Regex.IsMatch(text, "^[^a-z]*$")));

        private static bool IsQuestion(this string text) =>
            Regex.IsMatch(text, @"\?$");

        private static bool IsGreeting(this string text) =>
            Regex.IsMatch(text, @"\b[Hh]i\b") ||
            Regex.IsMatch(text, @"\b[Hh]ello\b");
    }
}