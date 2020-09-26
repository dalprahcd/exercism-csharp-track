using System;

namespace Exercism.CSharp.Solutions.RationalNumberExercise
{
    public struct RationalNumber
    {
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException(nameof(denominator));
            }

            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; }
        public int Denominator { get; }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int a1 = r1.Numerator;
            int b1 = r1.Denominator;

            int a2 = r2.Numerator;
            int b2 = r2.Denominator;

            int num = (a1 * b2) + (a2 * b1);
            int den = b1 * b2;

            return new RationalNumber(num, den).Reduce();
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int a1 = r1.Numerator;
            int b1 = r1.Denominator;

            int a2 = r2.Numerator;
            int b2 = r2.Denominator;

            int num = (a1 * b2) - (a2 * b1);
            int den = b1 * b2;

            return new RationalNumber(num, den).Reduce();
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            int a1 = r1.Numerator;
            int b1 = r1.Denominator;

            int a2 = r2.Numerator;
            int b2 = r2.Denominator;

            int num = a1 * a2;
            int den = b1 * b2;

            return new RationalNumber(num, den).Reduce();
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            int a1 = r1.Numerator;
            int b1 = r1.Denominator;

            int a2 = r2.Numerator;
            int b2 = r2.Denominator;

            int num = a1 * b2;
            int den = a2 * b1;

            return new RationalNumber(num, den).Reduce();
        }

        public RationalNumber Abs()
        {
            return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();
        }

        public RationalNumber Reduce()
        {
            int num = Numerator;
            int den = Denominator;

            int gcd = GCD(Math.Abs(num), Math.Abs(den));

            if (gcd != 1)
            {
                num /= gcd;
                den /= gcd;
            }

            return new RationalNumber(num, den);
        }

        public RationalNumber Exprational(int power)
        {
            int n = Math.Abs(power);
            int num = (int) Math.Pow(Numerator, n);
            int den = (int) Math.Pow(Denominator, n);

            var output = power > 0
                        ? new RationalNumber(num, den)
                        : new RationalNumber(den, num);

            return output.Reduce();
        }

        public double Expreal(int baseNumber) => Math.Pow(baseNumber, Numerator / (double) Denominator);

        private static int GCD(int x, int y)
        {
            while (x != 0 && y != 0)
            {
                if (x > y)
                {
                    x %= y;
                }
                else
                {
                    y %= x;
                }
            }

            return x | y;
        }
    }
}