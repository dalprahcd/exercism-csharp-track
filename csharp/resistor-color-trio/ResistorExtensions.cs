using System;

namespace Exercism.CSharp.Solutions.ResistorColorTrioExercise
{
    public static class ResistorExtensions
    {
        public static int ToResistorValue(this string[] colors)
        {
            int factor = (int)Math.Pow(10, colors[2].ToResistorValue());

            return factor * ((10 * colors[0].ToResistorValue()) + colors[1].ToResistorValue());
        }

        public static int ToResistorValue(this string color) =>
            color.ToLower() switch
            {
                "black"     => 0,
                "brown"     => 1,
                "red"       => 2,
                "orange"    => 3,
                "yellow"    => 4,
                "green"     => 5,
                "blue"      => 6,
                "violet"    => 7,
                "grey"      => 8,
                "white"     => 9,
                _ => throw new ArgumentOutOfRangeException(nameof(color), "Invalid resistor color band")
            };

        public static string PrettyName(this int resistor)
        {
            if (resistor > 1000)
            {
                resistor /= 1000;
                return resistor + " kiloohms";
            }

            return resistor + " ohms";
        }
    }
}