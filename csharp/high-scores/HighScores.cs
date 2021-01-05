using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.HighScoresExercise
{
    public class HighScores
    {
        private readonly IEnumerable<int> _scores;

        public HighScores(IEnumerable<int> list) =>
            _scores = list ?? new List<int>();

        public IEnumerable<int> Scores() =>
            _scores;

        public int Latest() =>
            _scores.LastOrDefault();

        public int PersonalBest() =>
            _scores.Any() ? _scores.Max() : default;

        public IEnumerable<int> PersonalTopThree() =>
            _scores.OrderByDescending(x => x).Take(3);
    }
}