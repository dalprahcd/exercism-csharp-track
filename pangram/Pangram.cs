using System;
using System.Linq;

public static class Pangram
{
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        return alphabet.All(
            s => input.Contains(s, StringComparison.OrdinalIgnoreCase));
    }
}
