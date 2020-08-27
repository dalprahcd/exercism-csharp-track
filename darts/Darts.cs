using System;

namespace Exercism.CSharp.Solutions.DartsExercise
{
    public static class Darts
    {
        private struct SCORE
        {
            public const int OUTSIDE        = 0;
            public const int OUTER_CIRCLE   = 1;
            public const int MIDDLE_CIRCLE  = 5;
            public const int INNER_CIRCLE   = 10;
        }

        private struct RADIUS
        {
            public const double OUTER_CIRCLE    = 10.0d;
            public const double MIDDLE_CIRCLE   = 5.0d;
            public const double INNER_CIRCLE    = 1.0d;
        }

        public static int Score(double x, double y)
        {
            double landingRadius = GetRadius(x, y);

            if (landingRadius <= RADIUS.INNER_CIRCLE)
            {
                return SCORE.INNER_CIRCLE;
            }
            else if (landingRadius <= RADIUS.MIDDLE_CIRCLE)
            {
                return SCORE.MIDDLE_CIRCLE;
            }
            else if (landingRadius <= RADIUS.OUTER_CIRCLE)
            {
                return SCORE.OUTER_CIRCLE;
            }

            return SCORE.OUTSIDE;
        }

        private static double GetRadius(double x, double y) =>
            Math.Sqrt((x * x) + (y * y));
    }
}