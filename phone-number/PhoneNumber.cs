using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercism.CSharp.Solutions.PhoneNumberExercise
{
    public static class PhoneNumber
    {
        public static string Clean(string phoneNumber)
        {
            char[] clean = Regex.Replace(phoneNumber, "[^0-9]", "").ToCharArray();

            if (clean.Length < 10 || clean.Length > 11)
            {
                throw new ArgumentException("Invalid phone number length", nameof(phoneNumber));
            }

            if (clean.Length == 11 && clean[0] != '1')
            {
                throw new ArgumentException("Invalid country code", nameof(phoneNumber));
            }

            if (clean.Length == 11)
            {
                clean = clean.Skip(1).ToArray();
            }

            if (clean[0] == '0' || clean[0] == '1')
            {
                throw new ArgumentException("Invalid area code", nameof(phoneNumber));
            }

            if (clean[3] == '0' || clean[3] == '1')
            {
                throw new ArgumentException("Invalid exchange code", nameof(phoneNumber));
            }

            return new string(clean);
        }
    }
}