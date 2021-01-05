using System;

namespace Exercism.CSharp.Solutions.DartsExercise
{
    public static class Darts
    {
        private struct Points
        {
            public const int Outside        = 0;
            public const int OuterCircle   = 1;
            public const int MiddleCircle  = 5;
            public const int InnerCircle   = 10;
        }

        private struct Radius
        {
            public const double OuterCircle    = 10.0d;
            public const double MiddleCircle   = 5.0d;
            public const double InnerCircle    = 1.0d;
        }

        public static int Score(double x, double y)
        {
            double landingRadius = GetRadius(x, y);

            if (landingRadius <= Radius.InnerCircle)
            {
                return Points.InnerCircle;
            }
            else if (landingRadius <= Radius.MiddleCircle)
            {
                return Points.MiddleCircle;
            }
            else if (landingRadius <= Radius.OuterCircle)
            {
                return Points.OuterCircle;
            }

            return Points.Outside;
        }

        private static double GetRadius(double x, double y) =>
            Math.Sqrt((x * x) + (y * y));
    }
}