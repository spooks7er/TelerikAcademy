using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace Poker.Test
{
    [TestClass]
    public class UnitTest_Hand
    {
        [TestMethod]
        public void Test_Hand_ToString()
        {
            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });


            var bulder = new StringBuilder();
            int count = 0;
            foreach (var card in hand.Cards)
            {
                count++;
                bulder.AppendLine(string.Format("Card {0} - {1}", count, card.ToString()));
            }

            string teststr = hand.ToString();

            string actual = bulder.ToString();

            Assert.AreEqual(teststr, actual);
        }
    }
}
