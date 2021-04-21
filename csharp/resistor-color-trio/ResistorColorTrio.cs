using System;

namespace Exercism.CSharp.Solutions.ResistorColorTrioExercise
{
    public static class ResistorColorTrio
    {
        public static string Label(string[] colors)
        {
            if (colors is null)
            {
                throw new ArgumentNullException(nameof(colors));
            }

            if (colors.Length < 3)
            {
                throw new ArgumentOutOfRangeException(nameof(colors), "Must have at least 2 colors");
            }

            return colors.ToResistorValue().PrettyName();
        }
    }
}