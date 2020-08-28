using System;
using System.Linq;

namespace Exercism.CSharp.Solutions.SecretHandshakeExercise
{
    [Flags]
    public enum Secrets
    {
        None            = 0,
        Wink            = 1,
        DoubleBlink     = 2,
        CloseYourEyes   = 4,
        Jump            = 8,
        ReverseOrder    = 16

    }

    public static class SecretHandshake
    {
        public static string[] Commands(int cmd)
        {
            var query = Enum.GetValues(typeof(Secrets))
                            .Cast<int>()
                            .Where(x => x != 0 && (cmd & x) == x);

            if (query.Contains((int)Secrets.ReverseOrder))
            {
                query = query
                            .Where(x => x != (int)Secrets.ReverseOrder)
                            .Reverse();
            }

            return query
                    .Select(x => ParseSecretToString((Secrets)x))
                    .ToArray();
        }

        private static string ParseSecretToString(Secrets secret) =>
        secret switch
        {
            Secrets.None            => "none",
            Secrets.Wink            => "wink",
            Secrets.DoubleBlink     => "double blink",
            Secrets.CloseYourEyes   => "close your eyes",
            Secrets.Jump            => "jump",
            Secrets.ReverseOrder    => "reverse order",
            _                       => throw new ArgumentException("Invalid Secret", nameof(secret)),
        };
    }
}