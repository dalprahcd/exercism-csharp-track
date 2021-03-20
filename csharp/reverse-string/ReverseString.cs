using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.ResistorColorExercise
{
    public static class ReverseString
    {
        public static string Reverse(string input) =>
            input is null
            ? throw new ArgumentNullException(nameof(input))
            : new string(input.Reverse().ToArray());
    }
}