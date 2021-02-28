using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.PokerExercise
{
    public static class Poker
    {
        public static IEnumerable<string> BestHands(IEnumerable<string> hands) =>
            hands
                .Select(ParsingService.ReadHand)
                .EvaluateBestHands()
                .Select(ParsingService.WriteHand);
    }
}