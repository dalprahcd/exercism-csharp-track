using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.GradeSchoolExercise
{
    public class GradeSchool
    {
        private readonly Dictionary<string, int> _schoolRoster = new Dictionary<string, int>();

        public void Add(string student, int grade) =>
            _schoolRoster[student] = grade;

        public IEnumerable<string> Roster() =>
            _schoolRoster
                .OrderBy(k => k.Value)
                .ThenBy(k => k.Key)
                .Select(k => k.Key);

        public IEnumerable<string> Grade(int grade) =>
            _schoolRoster
                .Where(k => k.Value == grade)
                .Select(k => k.Key)
                .OrderBy(s => s);
    }
}