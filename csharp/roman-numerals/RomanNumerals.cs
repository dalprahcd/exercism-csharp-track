using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.RomanNumeralExtensionExercise
{
    public static class RomanNumeralExtension
    {
        private static readonly Dictionary<int, string> romanNumeralsMap = new Dictionary<int, string>
        {
            [1] = "I",
            [4] = "IV",
            [5] = "V",
            [9] = "IX",
            [10] = "X",
            [40] = "XL",
            [50] = "L",
            [90] = "XC",
            [100] = "C",
            [400] = "CD",
            [500] = "D",
            [900] = "CM",
            [1000] = "M"
        };

        public static string ToRoman(this int value)
        {
            var output = string.Empty;

            foreach (var kvp in romanNumeralsMap.OrderByDescending(d => d.Key))
            {
                while (value >= kvp.Key)
                {
                    output += kvp.Value;
                    value -= kvp.Key;
                }
            }

            return output;
        }
    }
}