using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        return 1UL << (n - 1);
    }

    public static ulong Total() => ulong.MaxValue;
}