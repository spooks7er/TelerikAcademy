namespace Deck.NUnitTest
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using Santase.Logic.Cards;

    [TestFixture]
    public class Deck_Tests
    {
        [TestCase(1)]
        [TestCase(12)]
        [TestCase(24)]
        public void Test_GetNextCard_ShouldRemoveCardsFromDeck(int count)
        {
            var deck = new Deck();

            int cardsLeft = 24;

            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
                cardsLeft--;
            }

            Assert.AreEqual(cardsLeft, deck.CardsLeft);
        }
    }
}