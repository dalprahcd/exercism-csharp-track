using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.GradeSchoolExercise
{
    public class GradeSchool
    {
        private readonly Dictionary<string, int> schoolRoster = new Dictionary<string, int>();

        public void Add(string student, int grade) =>
            schoolRoster[student] = grade;

        public IEnumerable<string> Roster() =>
            schoolRoster
                .OrderBy(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .Select(kvp => kvp.Key);

        public IEnumerable<string> Grade(int grade) =>
            schoolRoster
                .Where(kvp => kvp.Value == grade)
                .Select(kvp => kvp.Key)
                .OrderBy(student => student);
    }
}