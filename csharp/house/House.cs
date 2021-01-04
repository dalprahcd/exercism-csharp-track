using System;
using System.Text;

namespace Exercism.CSharp.Solutions.HouseExercise
{
    public static class House
    {
        private const string Header = "This is";
        private static readonly string[] _verses =
        {
            " the house that Jack built.",
            " the malt that lay in",
            " the rat that ate",
            " the cat that killed",
            " the dog that worried",
            " the cow with the crumpled horn that tossed",
            " the maiden all forlorn that milked",
            " the man all tattered and torn that kissed",
            " the priest all shaven and shorn that married",
            " the rooster that crowed in the morn that woke",
            " the farmer sowing his corn that kept",
            " the horse and the hound and the horn that belonged to"
        };

        public static string Recite(int verseNumber)
        {
            if (verseNumber < 1)
            {
                throw new ArgumentException(nameof(verseNumber), "Must be a positive number other than zero");
            }

            var builder = new StringBuilder();
            builder.Append(Header);

            for (int i = verseNumber - 1; i >= 0; i--)
            {
                builder.Append(_verses[i]);
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
    }
}