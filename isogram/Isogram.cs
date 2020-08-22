using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word == null)
        {
            return false;
        }

        if (word.All(char.IsWhiteSpace))
        {
            return true;
        }

        var onlyLetters = word
                            .Where(char.IsLetter)
                            .Select(c => c.ToString());

        return onlyLetters.Count() == onlyLetters
                                        .Distinct(StringComparer.OrdinalIgnoreCase)
                                        .Count();
    }
}
