using CodingChallenge.CardGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGameTest
{
    [TestClass]
    public class PackOfCardsTests
    {
        private PackOfCards deck;

        [TestInitialize]
        public void Setup()
        {
            deck = (PackOfCards)new PackOfCardsCreator().Create();
        }

        [TestMethod]
        public void PackOfCardsCreatorReturnsDeck()
        {
            Assert.IsNotNull(deck);
        }

        [TestMethod]
        public void PackOfCardsShuffleDeck_ReturnsDiffCardOnTop()
        {
            var input = deck.Cards[0];
            deck.Shuffle();
            var result = deck.Cards[0];
            Assert.IsFalse(input == result);
        }

        [TestMethod]
        public void PackOfCardsTakeCardFromTopOfPack_ReturnsOnelessCard()
        {
            var input = deck.Count;
            deck.TakeCardFromTopOfPack();
            var result = deck.Count;
            Assert.IsTrue(input - 1 == result);
        }

        [TestMethod]
        public void PackOfCardsAfterShuffleDeck_CardCountIsFull()
        {
            var input = deck.Count;
            deck.TakeCardFromTopOfPack();
            deck.Shuffle();
            var result = deck.Count;
            Assert.IsTrue(input == result);
        }
    }
}
