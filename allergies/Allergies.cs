using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.AllergiesExercise
{
    [Flags]
    public enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }

    public class Allergies
    {
        private readonly Allergen allergies;

        public Allergies(int mask) =>
            allergies = (Allergen)mask;

        public bool IsAllergicTo(Allergen allergen) =>
            (allergies & allergen) == allergen;

        public IEnumerable<Allergen> List() =>
            Enum.GetValues(typeof(Allergen))
                .Cast<Allergen>()
                .Where(allergen => (allergies & allergen) == allergen);
    }
}