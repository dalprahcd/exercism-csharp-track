using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }

        return Power(2UL, (ulong)(n - 1));
    }

    public static ulong Total()
    {
        return (Power(2UL, 64UL) - 1);
    }

    private static ulong Power(ulong value, ulong factor)
    {
        ulong power = 1;

        for (ulong i = 0; i < factor; i++)
        {
            power *= value;
        }

        return power;
    }
}