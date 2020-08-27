using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.ArmstrongNumbersExercise
{
    public static class ArmstrongNumbers
    {
        public static bool IsArmstrongNumber(int number) =>
            number == number
                        .ToString()
                        .Select(c => c - '0')
                        .Sum(n => Math.Pow(n, number.ToString().Length));
    }
}