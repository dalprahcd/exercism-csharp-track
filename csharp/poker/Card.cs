using System;
using System.Drawing;

namespace Exercism.CSharp.Solutions.PokerExercise
{
    public class Card
    {
        public Card(CardRanks rank, CardSuits suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public CardRanks Rank { get; }
        public CardSuits Suit { get; }
        public Color Color => Suit switch
        {
            CardSuits.Clubs     => Color.Black,
            CardSuits.Diamonds  => Color.Red,
            CardSuits.Hearts    => Color.Black,
            CardSuits.Spades    => Color.Red,
            _ => throw new ArgumentOutOfRangeException(nameof(Suit), Suit, "Could not find a color for this suit")
        };
    }
}