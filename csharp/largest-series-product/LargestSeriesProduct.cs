using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.LargestSeriesProductExercise
{
    public static class LargestSeriesProduct
    {
        public static long GetLargestProduct(string digits, int span)
        {
            if (span == 0)
            {
                return 1;
            }

            if (string.IsNullOrEmpty(digits))
            {
                throw new ArgumentException("Digits is null or empty", nameof(digits));
            }

            if (digits.Length < span)
            {
                throw new ArgumentException("Span is longer than string length", nameof(span));
            }

            if (!digits.All(char.IsDigit))
            {
                throw new ArgumentException("There is at least one non digit letter in the string", nameof(digits));
            }

            if (span < 0)
            {
                throw new ArgumentException("Span must not be negative", nameof(span));
            }

            return digits.Extract().Span(span).Max(s => s.Multiply());
        }

        private static IEnumerable<int> Extract(this string text)
        {
            foreach (var letter in text)
            {
                yield return int.Parse(letter.ToString());
            }
        }

        private static IEnumerable<IEnumerable<int>> Span(this IEnumerable<int> numbers, int span)
        {
            for (int i = 0; i <= numbers.Count() - span; i++)
            {
                yield return numbers.Skip(i).Take(span);
            }
        }

        private static long Multiply(this IEnumerable<int> numbers)
        {
            long product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }

            return product;
        }
    }
}