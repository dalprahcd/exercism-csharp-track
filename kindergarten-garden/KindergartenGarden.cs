using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.KindergartenGardenExercise
{
    public enum Plant
    {
        Violets     = 'V',
        Radishes    = 'R',
        Clover      = 'C',
        Grass       = 'G'
    }

    public enum Students
    {
        Alice       = 0,
        Bob         = 2,
        Charlie     = 4,
        David       = 6,
        Eve         = 8,
        Fred        = 10,
        Ginny       = 12,
        Harriet     = 14,
        Ileana      = 16,
        Joseph      = 18,
        Kincaid     = 20,
        Larry       = 22
    }

    public class KindergartenGarden
    {
        private readonly string[] rows;

        public KindergartenGarden(string diagram) =>
            rows = diagram.Split(new[] { "\n" }, StringSplitOptions.None);

        public IEnumerable<Plant> Plants(string student)
        {
            if (!Enum.TryParse(student, out Students enumStudent))
            {
                return Array.Empty<Plant>();
            }

            int start = (int)enumStudent;
            if (rows.Any(r => r.Length < start + 2))
            {
                return Array.Empty<Plant>();
            }

            List<Plant> output = new List<Plant>();

            foreach (var row in rows)
            {
                output.AddRange(row
                                .Skip(start)
                                .Take(2)
                                .Select(c => (Plant)c));
            }

            return output;
        }
    }
}