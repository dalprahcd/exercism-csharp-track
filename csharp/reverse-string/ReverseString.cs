using System;
//using System.Linq;

namespace Exercism.CSharp.Solutions.ResistorColorExercise
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);
            return new string(reversed);

            //return new string(input.Reverse().ToArray());
        }
    }
}