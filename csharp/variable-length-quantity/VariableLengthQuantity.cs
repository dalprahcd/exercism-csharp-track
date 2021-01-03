using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.VariableLengthQuantityExercise
{
    public static class VariableLengthQuantity
    {
        public static IEnumerable<uint> Encode(IEnumerable<uint> numbers) =>
            numbers.SelectMany(number => Encode(number).Reverse());

        public static IEnumerable<uint> Decode(IEnumerable<uint> bytes)
        {
            var last = bytes.Last();

            // Last byte has not a high bit clear,
            // Incomplete sequence
            if ((last & 0x80u) != 0)
            {
                throw new InvalidOperationException("Incomplete encoded sequence");
            }

            return Combine(bytes);
        }

        private static IEnumerable<uint> Encode(uint number)
        {
            // Flag the first byte
            var first = true;
            // Store the number in a temporary variable;
            var value = number;

            do
            {
                // Grab the lowest 7 bits
                var lower7bits = value & 0x7Fu;

                // Shift the value 7 bits to the right,
                // We have stored them in the previous variable
                value >>= 7;

                if (first)
                {
                    // leave the first 7 bits clear
                    first = false;
                }
                else
                {
                    // Set the high bit for all others
                    lower7bits |= 128;
                }

                yield return lower7bits;

            // There is still value to be encoded
            } while (value > 0);
        }

        private static IEnumerable<uint> Combine(IEnumerable<uint> bytes)
        {
            var combined = 0x00u;
            foreach (var b in bytes)
            {
                 // Grab the lowest 7 bits
                var lower7bits = b & 0x7Fu;

                // Shift number 7 bits to the left.
                combined <<= 7;

                // Combine lower 7 bits.
                combined |= lower7bits;

                // If high bit is clear
                if ((b & 0x80u) == 0)
                {
                    // There is a complete number
                    yield return combined;

                    // Reset temporary variable
                    combined = 0x00u;
                }
            }
        }
    }
}
