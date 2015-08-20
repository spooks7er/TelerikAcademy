using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class UnitTest_Card
    {
        [TestMethod]
        public void Test_Card_ToString()
        {
            var card = new Card(CardFace.Ace, CardSuit.Hearts);
            string teststr = card.ToString();
            string actual = string.Format("Face: {0}, Suit: {1}", card.Face, card.Suit);

            Assert.AreEqual(teststr, actual);
        }
    }
}