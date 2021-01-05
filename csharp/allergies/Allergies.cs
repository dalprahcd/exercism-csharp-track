using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.AllergiesExercise
{
    [Flags]
    public enum Allergen
    {
        None            = 0,
        Eggs            = 1,
        Peanuts         = 2,
        Shellfish       = 4,
        Strawberries    = 8,
        Tomatoes        = 16,
        Chocolate       = 32,
        Pollen          = 64,
        Cats            = 128
    }

    public class Allergies
    {
        private readonly Allergen _allergies;

        public Allergies(int mask) =>
            _allergies = (Allergen)mask;

        public bool IsAllergicTo(Allergen allergen) =>
            (_allergies & allergen) == allergen;

        public IEnumerable<Allergen> List() =>
            Enum.GetValues(typeof(Allergen))
                .Cast<Allergen>()
                .Where(a => a != Allergen.None && (_allergies & a) == a)
                .DefaultIfEmpty(Allergen.None);
    }
}