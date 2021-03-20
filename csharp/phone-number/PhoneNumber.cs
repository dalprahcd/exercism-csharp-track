using System;
using System.Text.RegularExpressions;

namespace Exercism.CSharp.Solutions.PhoneNumberExercise
{
    public static class PhoneNumber
    {
        public static string Clean(string phoneNumber)
        {
            var clean = Regex.Replace(phoneNumber, "[^0-9]", "");

            var match = Regex.Match(clean, @"^1?([2-9]\d{2}[2-9]\d{6})$");

            return match.Success
                    ? match.Groups[1].ToString()
                    : throw new ArgumentException();
        }
    }
}