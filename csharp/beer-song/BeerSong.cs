using System;
using System.Text;

namespace Exercism.CSharp.Solutions.BeerSongExercise
{
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            if (startBottles < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startBottles));
            }

            if (takeDown < 0 || takeDown > startBottles + 1)
            {
                throw new ArgumentOutOfRangeException(nameof(takeDown));
            }

            StringBuilder beerSongBuilder = new StringBuilder();

            while (takeDown > 1)
            {
                beerSongBuilder
                        .Append(FirstPhrase(startBottles))
                        .Append(SecondPhrase(startBottles))
                        .Append("\n\n");

                startBottles--;
                takeDown--;
            }

            beerSongBuilder
                        .Append(FirstPhrase(startBottles))
                        .Append(SecondPhrase(startBottles));

            return beerSongBuilder.ToString();
        }

        private static string FirstPhrase(int beerNumber) =>
            beerNumber switch
            {
                0 => "No more bottles of beer on the wall, no more bottles of beer.\n",
                1 => "1 bottle of beer on the wall, 1 bottle of beer.\n",
                _ => $"{beerNumber} bottles of beer on the wall, {beerNumber} bottles of beer.\n",
            };

        private static string SecondPhrase(int beerNumber) =>
            beerNumber switch
            {
                0 => "Go to the store and buy some more, 99 bottles of beer on the wall.",
                1 => "Take it down and pass it around, no more bottles of beer on the wall.",
                2 => "Take one down and pass it around, 1 bottle of beer on the wall.",
                _ => $"Take one down and pass it around, {beerNumber - 1} bottles of beer on the wall."
            };
    }
}