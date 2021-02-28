using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercism.CSharp.Solutions.PokerExercise
{
    public static class ParsingService
    {
        public static IEnumerable<Card> ReadHand(this string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 14 || text.Length > 15)
            {
                throw new ArgumentException("We expect a string with 14 or 15 characters", nameof(text));
            }

            return text
                    .Split(new [] { " "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(ReadCard);
        }

        public static string WriteHand(this IEnumerable<Card> cards) =>
            string.Join(" ", cards.Select(WriteCard));

        public static Card ReadCard(this string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length < 2 || text.Length > 3)
            {
                throw new ArgumentException("We expect a string with 2 or 3 characters", nameof(text));
            }

            var rank = ReadRank(text[0]);
            var suit = ReadSuit(text.Last());

            return new Card(rank, suit);
        }

        public static string WriteCard(this Card card) =>
            string.Concat(card.Rank.WriteRank(), card.Suit.WriteSuit());

        private static CardRanks ReadRank(this char letter) =>
            letter switch
            {
                'A' => CardRanks.Ace,
                '2' => CardRanks.Two,
                '3' => CardRanks.Three,
                '4' => CardRanks.Four,
                '5' => CardRanks.Five,
                '6' => CardRanks.Six,
                '7' => CardRanks.Seven,
                '8' => CardRanks.Eight,
                '9' => CardRanks.Nine,
                '1' => CardRanks.Ten,
                'J' => CardRanks.Jack,
                'Q' => CardRanks.Queen,
                'K' => CardRanks.King,
                _   => throw new ArgumentOutOfRangeException(nameof(letter), letter, "Could not find a card rank for this letter")
            };

        private static string WriteRank(this CardRanks rank) =>
            rank switch
            {
                CardRanks.Ace   => "A",
                CardRanks.Two   => "2",
                CardRanks.Three => "3",
                CardRanks.Four  => "4",
                CardRanks.Five  => "5",
                CardRanks.Six   => "6",
                CardRanks.Seven => "7",
                CardRanks.Eight => "8",
                CardRanks.Nine  => "9",
                CardRanks.Ten   => "10",
                CardRanks.Jack  => "J",
                CardRanks.Queen => "Q",
                CardRanks.King  => "K",
                _ => throw new ArgumentOutOfRangeException(nameof(rank), rank, "Could not find a letter for this card rank")
            };

        private static CardSuits ReadSuit(this char letter) =>
            letter switch
            {
                'C' => CardSuits.Clubs,
                'D' => CardSuits.Diamonds,
                'H' => CardSuits.Hearts,
                'S' => CardSuits.Spades,
                _   => throw new ArgumentOutOfRangeException(nameof(letter), letter, "Could not find a card suit for this letter")
            };

        private static char WriteSuit(this CardSuits suit) =>
            suit switch
            {
                CardSuits.Clubs     => 'C',
                CardSuits.Diamonds  => 'D',
                CardSuits.Hearts    => 'H',
                CardSuits.Spades    => 'S',
                _ => throw new ArgumentOutOfRangeException(nameof(suit), suit, "Could not find a letter for this card suit")
            };
    }
}