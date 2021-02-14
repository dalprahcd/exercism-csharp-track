using System;
using System.Text;

namespace Exercism.CSharp.Solutions.TwelveDaysExercise
{
    public static class TwelveDays
    {
        private static readonly string[] days =
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth",
            "eleventh",
            "twelfth"
        };

        private static readonly string[] presents =
        {
            " and a Partridge in a Pear Tree.",
            " two Turtle Doves,",
            " three French Hens,",
            " four Calling Birds,",
            " five Gold Rings,",
            " six Geese-a-Laying,",
            " seven Swans-a-Swimming,",
            " eight Maids-a-Milking,",
            " nine Ladies Dancing,",
            " ten Lords-a-Leaping,",
            " eleven Pipers Piping,",
            " twelve Drummers Drumming,"
        };

        public static string Recite(int verseNumber)
        {
            if (verseNumber < 1)
            {
                throw new ArgumentException(nameof(verseNumber), "Must be a positive number other than zero");
            }

            if (verseNumber == 1)
            {
                return NoAnd();
            }

            var builder = new StringBuilder();

            builder.Append(Header(verseNumber - 1));

            for (int i = verseNumber - 1; i >= 0; i--)
            {
                builder.Append(presents[i]);
            }

            return builder.ToString();
        }

        public static string Recite(int startVerse, int endVerse)
        {
            if (endVerse < startVerse)
            {
                throw new ArgumentException(nameof(endVerse), "End verse should be greater than start verse");
            }

            var builder = new StringBuilder();

            for (int i = startVerse; i <= endVerse; i++)
            {
                builder.Append(Recite(i)).Append("\n");
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }

        private static string NoAnd() =>
            Header(0) + " a Partridge in a Pear Tree.";

        private static string Header(int day) =>
            "On the " + days[day] + " day of Christmas my true love gave to me:";
    }
}