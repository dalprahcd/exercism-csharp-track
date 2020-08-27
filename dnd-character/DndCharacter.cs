using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.DndCharacterExercise
{
    public class DndCharacter
    {
        private static readonly Random rnd = new Random();

        public int Strength { get; }        = Ability();
        public int Dexterity { get; }       = Ability();
        public int Constitution { get; }    = Ability();
        public int Intelligence { get; }    = Ability();
        public int Wisdom { get; }          = Ability();
        public int Charisma { get; }        = Ability();
        public int Hitpoints                => 10 + Modifier(Constitution);

        public static int Modifier(int score) =>
            (int)Math.Floor((score - 10) / 2.0d);

        public static int Ability() =>
            Enumerable
                .Range(0, 4)
                .Select(_ => rnd.Next(1, 7))
                .OrderByDescending(x => x)
                .Take(3)
                .Sum();

        public static DndCharacter Generate() =>
            new DndCharacter();
    }
}