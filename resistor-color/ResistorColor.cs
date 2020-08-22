using System;
using System.Linq;

public static class ResistorColor
{
    private enum RESISTOR_BANDS
    {
        Black = 0,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Grey,
        White
    }


    public static int ColorCode(string color)
    {
        Enum.TryParse(color, true, out RESISTOR_BANDS result);
        return (int) result;
    }

    public static string[] Colors()
    {
        return Enum
                .GetNames(typeof(RESISTOR_BANDS))
                .Select(s => s.ToLower())
                .ToArray();
    }
}