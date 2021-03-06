﻿using System;

namespace Exercism.CSharp.Solutions.GrainsExercise
{
    public static class Grains
    {
        public static ulong Square(int n) =>
            n < 1 || n > 64
            ? throw new ArgumentOutOfRangeException(nameof(n))
            : 1UL << (n - 1);

        public static ulong Total() => ulong.MaxValue;
    }
}