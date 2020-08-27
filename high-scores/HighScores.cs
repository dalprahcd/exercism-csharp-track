using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.HighScoresExercise
{
    public class HighScores
    {
        private readonly IEnumerable<int> scores;

        public HighScores(IEnumerable<int> list) =>
            scores = list ?? new List<int>();

        public IEnumerable<int> Scores() =>
            scores;

        public int Latest() =>
            scores.LastOrDefault();

        public int PersonalBest() =>
            scores.Any() ? scores.Max() : default;

        public IEnumerable<int> PersonalTopThree() =>
            scores.OrderByDescending(x => x).Take(3);
    }
}