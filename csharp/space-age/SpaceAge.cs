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

        private readonly double _livedEarthYears;

        public SpaceAge(int seconds) =>
            _livedEarthYears = seconds / EarthYearInSeconds;

        public double OnEarth() => _livedEarthYears;

        public double OnMercury() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Mercury;

        public double OnVenus() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Venus;

        public double OnMars() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Mars;

        public double OnJupiter() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Jupiter;
        public double OnSaturn() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Saturn;

        public double OnUranus() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Uranus;

        public double OnNeptune() =>
            _livedEarthYears / OrbitalPeriodInEarthYears.Neptune;
    }
}