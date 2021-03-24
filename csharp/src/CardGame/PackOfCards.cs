using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        public List<Card> Cards { get; set; }
        public int Count
        {
            get
            {
                return Cards.Count;
            }
        }

        public PackOfCards()
        {
            this.Cards = new List<Card>();
        }

        public void Shuffle()
        {
            //check if it has all cards, if not create new deck
            if (this.Count != 48)
            {
                this.Cards = ((PackOfCards)new PackOfCardsCreator().Create()).Cards;
            }

            //using Fisher–Yates shuffle
            Random random = new Random();
            for (var i = Count - 1; i > 0; i--)
            {
                var temp = Cards[i];
                var index = random.Next(0, i + 1);
                Cards[i] = Cards[index];
                Cards[index] = temp;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            ICard cardRemoved = Cards[0];
            Cards.RemoveAt(0);
            return cardRemoved;
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return this.Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
