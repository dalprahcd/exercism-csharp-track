using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.MeetupExercise
{
    public enum Schedule
    {
        Teenth,
        First,
        Second,
        Third,
        Fourth,
        Last
    }

    public class Meetup
    {
        private readonly IEnumerable<DateTime> _monthDays;

        public Meetup(int month, int year) =>
            _monthDays = Enumerable
                            .Range(1, DateTime.DaysInMonth(year, month))
                            .Select(day => new DateTime(year, month, day));

        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        {
            var eligibleDays = _monthDays.Where(date => date.DayOfWeek == dayOfWeek);

            return schedule switch
            {
                Schedule.Teenth => eligibleDays.First(date => date.Day > 12),
                Schedule.First  => eligibleDays.First(),
                Schedule.Second => eligibleDays.ElementAt(1),
                Schedule.Third  => eligibleDays.ElementAt(2),
                Schedule.Fourth => eligibleDays.ElementAt(3),
                Schedule.Last   => eligibleDays.Last(),
                _ => throw new ArgumentOutOfRangeException(nameof(schedule), schedule, "Invalid schedule"),
            };
        }
    }
}