namespace Exercism.CSharp.Solutions.SpaceAgeExercise
{
    public class SpaceAge
    {
        private const double EarthYearInSeconds     = 31557600d;
        private struct OrbitalPeriodInEarthYears
        {
            public const double Earth               = 1.0d;
            public const double Mercury             = 0.2408467d;
            public const double Venus               = 0.61519726d;
            public const double Mars                = 1.8808158d;
            public const double Jupiter             = 11.862615d;
            public const double Saturn              = 29.447498d;
            public const double Uranus              = 84.016846d;
            public const double Neptune             = 164.79132d;
        }

        private readonly double livedEarthYears;

        public SpaceAge(int seconds) =>
            livedEarthYears = seconds / EarthYearInSeconds;

        public double OnEarth() => livedEarthYears;

        public double OnMercury() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Mercury;

        public double OnVenus() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Venus;

        public double OnMars() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Mars;

        public double OnJupiter() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Jupiter;
        public double OnSaturn() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Saturn;

        public double OnUranus() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Uranus;

        public double OnNeptune() =>
            livedEarthYears / OrbitalPeriodInEarthYears.Neptune;
    }
}