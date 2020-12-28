using System;

namespace Exercism.CSharp.Solutions.ResistorColorDuoExercise
{
    public static class ResistorColorDuo
    {
        public static int Value(string[] colors)
        {
            if (colors is null)
            {
                throw new ArgumentNullException(nameof(colors));
            }

            if (colors.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(colors), "Must have at least 2 colors");
            }

            return (10 * GetResistorColorBandValue(colors[0])) +
                GetResistorColorBandValue(colors[1]);
        }

        private static int GetResistorColorBandValue(string color) =>
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
    }
}