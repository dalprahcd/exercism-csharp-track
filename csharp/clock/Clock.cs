using System;

namespace Exercism.CSharp.Solutions.ClockExercise
{
    public class Clock
    {
        private readonly int _hours;
        private readonly int _minutes;

        public Clock(int hours, int minutes)
        {
            int newHours = (hours + (minutes / 60)) % 24;
            int newMinutes = minutes % 60;

            if (newMinutes < 0)
            {
                newMinutes += 60;
                newHours--;
            }

            if (newHours < 0)
            {
                newHours += 24;
            }

            _hours = newHours;
            _minutes = newMinutes;
        }

        public Clock Add(int minutesToAdd) =>
            new Clock(_hours, _minutes + minutesToAdd);

        public Clock Subtract(int minutesToSubtract) =>
            new Clock(_hours, _minutes - minutesToSubtract);

        public override string ToString() =>
            $"{_hours:00}:{_minutes:00}";

        public override bool Equals(object obj) =>
            obj is Clock clock &&
            _hours == clock._hours &&
            _minutes == clock._minutes;

        public override int GetHashCode() =>
            HashCode.Combine(_hours, _minutes);
    }
}