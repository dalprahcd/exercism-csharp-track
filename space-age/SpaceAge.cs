using System;

public class SpaceAge
{
    private struct ORBITAL_PERIOD_EARTH_YEARS
    {
        public const double EARTH           = 1.0d;
        public const double MERCURY         = 0.2408467d;
        public const double VENUS           = 0.61519726d;
        public const double MARS            = 1.8808158d;
        public const double JUPITER         = 11.862615d;
        public const double SATURN          = 29.447498d;
        public const double URANUS          = 84.016846d;
        public const double NEPTUNE         = 164.79132d;
    }
    
    private const double EARTH_YEAR_SECONDS = 31557600d;
    private readonly double livedEarthYears;

    public SpaceAge(int seconds) =>    
        livedEarthYears = (double) seconds / EARTH_YEAR_SECONDS;
    
    public double OnEarth() => livedEarthYears;
    
    public double OnMercury() =>   
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.MERCURY;
    
    public double OnVenus() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.VENUS;
    
    public double OnMars() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.MARS;

    public double OnJupiter() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.JUPITER;
    public double OnSaturn() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.SATURN;
    
    public double OnUranus() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.URANUS;
    
    public double OnNeptune() =>
        livedEarthYears / ORBITAL_PERIOD_EARTH_YEARS.NEPTUNE;    
}