using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.ResistorColorExercise
{
    public static class ResistorColor
    {
        private enum ResistorBands
        {
            Black = 0,
            Brown,
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Violet,
            Grey,
            White
        }

        public static int ColorCode(string color)
        {
            Enum.TryParse(color, true, out ResistorBands result);
            return (int)result;
        }

        public static string[] Colors() =>
            Enum
            .GetNames(typeof(ResistorBands))
            .Select(s => s.ToLower())
            .ToArray();
    }
}