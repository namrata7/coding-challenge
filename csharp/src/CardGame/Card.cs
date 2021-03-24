using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }

        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public bool Equals(ICard other)
        {
            return this.Suit == other.Suit && this.Value == other.Value;
        }
    }
}
