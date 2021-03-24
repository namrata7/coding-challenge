using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            PackOfCards newPack = new PackOfCards();

            //for each suit
            for (int i = 0; i < 4; i++)
            {
                //for each Value
                for (int j = 0; j < 12; j++)
                {
                    newPack.Cards.Add(new Card((Suit)i, (Value)j));
                }
            }
            return newPack;
        }
    }
}
