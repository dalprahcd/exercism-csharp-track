using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.PokerExercise
{
    public static class EvaluationService
    {
        public static IEnumerable<IEnumerable<Card>> EvaluateBestHands(this IEnumerable<IEnumerable<Card>> hands)
        {
            var besthands = new List<IEnumerable<Card>>();
            var highestScore = 0L;

            foreach (var hand in hands)
            {
                var score = EvaluateHandScore(hand);

                if (score > highestScore)
                {
                    besthands.Clear();
                    besthands.Add(hand);
                    highestScore = score;
                }
                else if (score == highestScore)
                {
                    besthands.Add(hand);
                }
            }

            return besthands;
        }

        private static long EvaluateHandScore(IEnumerable<Card> cards)
        {
            var cardRanks = cards.Select(card => card.Rank);

            var isFlush = cards.GroupBy(card => card.Color).Count() == 1;
            var isStraight = cardRanks.IsStraight();
            var isLowStraight = cardRanks.IsLowStraight();

            if (isStraight && isFlush)
            {
                return EvaluateScore(HandRanks.StraightFlush, new[] { cardRanks.Max() });
            }
            else if (isFlush)
            {
                return EvaluateScore(HandRanks.Flush, cardRanks.OrderByDescending(rank => rank));
            }
            else if (isStraight)
            {
                return EvaluateScore(HandRanks.Straight, new[] { cardRanks.Max() });
            }
            else if (isLowStraight)
            {
                return EvaluateScore(HandRanks.Straight, new[]{ CardRanks.Five });
            }

            var groups = cardRanks.GroupBy(rank => rank);
            if (groups.Any(g => g.Count() > 1))
            {
                var four = groups.FirstOrDefault(g => g.Count() == 4);
                var three = groups.FirstOrDefault(g => g.Count() == 3);
                var pairs = groups.Where(g => g.Count() == 2);

                if (four != null)
                {
                    var highCard = cardRanks.First(rank => rank != four.Key);
                    return EvaluateScore(HandRanks.FourOfAKind, new[] { four.Key, highCard });
                }
                else if (three != null)
                {
                    if (pairs.Any())
                    {
                        return EvaluateScore(HandRanks.FullHouse, new[] { three.Key, pairs.First().Key });
                    }
                    else
                    {
                        var orderedCards = cardRanks.Where(rank=> rank != three.Key).OrderByDescending(rank => rank);

                        return EvaluateScore(HandRanks.ThreeOfAKind, new[] { three.Key }.Concat(orderedCards));
                    }
                }
                else if (pairs.Count() == 2)
                {
                    var highPair = pairs.Max(g => g.Key);
                    var lowPair = pairs.Min(g => g.Key);
                    var highCard = cardRanks.First(rank => rank != highPair && rank != lowPair);

                    return EvaluateScore(HandRanks.TwoPair, new[] { highPair, lowPair, highCard });
                }
                else if (pairs.Count() == 1)
                {
                    var pair = pairs.First().Key;
                    var orderedCards = cardRanks.Where(rank=> rank != pair).OrderByDescending(rank => rank);

                    return EvaluateScore(HandRanks.OnePair, new[] { pair }.Concat(orderedCards));
                }
            }

            return EvaluateScore(HandRanks.HighCard, cardRanks.OrderByDescending(rank => rank));
        }

        private static long EvaluateScore(HandRanks handRank, IEnumerable<CardRanks> tieBreakers)
        {
            var factor = 10000000000;
            var sum = factor * (int)handRank;

            foreach (var cardRank in tieBreakers)
            {
                factor /= 100;
                sum += factor * (int)cardRank;
            }

            return sum;
        }

        private static bool IsStraight(this IEnumerable<CardRanks> cardRanks)
        {
            var orderedRanks = cardRanks.OrderBy(rank => rank).Distinct();
            if (orderedRanks.Count() != 5)
            {
                return false;
            }

            return orderedRanks.Max() - orderedRanks.Min() == 4;
        }

        private static bool IsLowStraight(this IEnumerable<CardRanks> cardRanks)
        {
            var orderedRanks = cardRanks.OrderBy(rank => rank);

            return orderedRanks
                .SequenceEqual(new[] { CardRanks.Two, CardRanks.Three, CardRanks.Four, CardRanks.Five, CardRanks.Ace });
        }
    }
}