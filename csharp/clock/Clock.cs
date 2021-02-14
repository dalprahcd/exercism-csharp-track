using System;

namespace Exercism.CSharp.Solutions.ClockExercise
{
    public class Clock : IEquatable<Clock>
    {
        private readonly int hours;
        private readonly int minutes;

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

            this.hours = newHours;
            this.minutes = newMinutes;
        }

        public Clock Add(int minutesToAdd) =>
            new Clock(hours, minutes + minutesToAdd);

        public Clock Subtract(int minutesToSubtract) =>
            new Clock(hours, minutes - minutesToSubtract);

        public override string ToString() =>
            $"{hours:00}:{minutes:00}";

        public bool Equals(Clock other)
        {
            if (other is null) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return hours == other.hours && minutes == other.minutes;
        }

        public override bool Equals(object obj) =>
            Equals(obj as Clock);

        public override int GetHashCode() =>
            HashCode.Combine(hours, minutes);

        public static bool operator ==(Clock clock1, Clock clock2) =>
            clock1.Equals(clock2);

        public static bool operator !=(Clock clock1, Clock clock2) =>
            !(clock1 == clock2);
    }
}