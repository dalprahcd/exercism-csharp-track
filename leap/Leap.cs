using System;

namespace Exercism.CSharp.Solutions.LeapExercise
{
    public static class Leap
    {
        public static bool IsLeapYear(int year) => year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}