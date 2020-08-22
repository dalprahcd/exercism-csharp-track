using System;
using System.Linq;

public static class Acronym
{
    private static readonly char[] separators = {' ', ',', '/', '-', '_'};

    public static string Abbreviate(string phrase)
    {
        if (string.IsNullOrEmpty(phrase))
        {
            return string.Empty;
        }

        return new string(
            phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.First())
            .ToArray()
        ).ToUpper();
    }
}