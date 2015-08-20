using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
namespace Poker.Test
{
    [TestClass]
    public class UnitTest_PokerHandsChecker
    {
        [TestMethod]
        public void Test_IsValidHand_If5Cards()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            bool actual = checker.IsValidHand(hand);

            bool check = hand.Cards.Count == 5;

            Assert.AreEqual(check, actual);
        }

        [TestMethod]
        public void Test_IsValidHand_DifferentCards()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Hearts),

                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            bool check = checker.IsValidHand(hand);
            bool actual = true;
            foreach (var card in hand.Cards)
            {
                foreach (var cardCompare in hand.Cards)
                {
                    if (card == cardCompare)
                    {
                        continue;
                    }
                    if (card.Face == cardCompare.Face && card.Suit == cardCompare.Suit)
                    {
                        actual = false;
                        break;
                    }
                }
            }
            Assert.AreEqual(check, actual);
        }

        [TestMethod]
        public void Test_IsStraightFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),
            });

            bool check = checker.IsStraightFlush(hand);
            bool actual = true;
            var firstCard = hand.Cards[0];
            foreach (var card in hand.Cards)
            {
                if (card.Suit != firstCard.Suit)
                {
                    actual = false;
                }
            }

            var cardsSortedFace = hand.Cards.OrderBy(x => x.Face).ToList();
            for (int i = 0; i < 4; i++)
            {
                if (cardsSortedFace[i].Face + 1 != cardsSortedFace[i + 1].Face)
                {
                    actual = false;
                }
            }

            Assert.AreEqual(check, actual);
        }

        [TestMethod]
        public void Test_IsFourOfAKind()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });

            bool check = checker.IsFourOfAKind(hand);
            bool actual = false;
            int count = 1;
            var cards = hand.Cards.OrderBy(x => x.Face).ToList();
            for (int i = 0; i < 4; i++)
            {
                if (cards[i].Face == cards[i + 1].Face)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count == 4)
                {
                    break;
                }
            }
            if (count == 4)
            {
                actual = true;
            }

            Assert.AreEqual(check, actual);
        }

        //[TestMethod]
        //public void Test_IsFullHouse()
        //{
        //    IPokerHandsChecker checker = new PokerHandsChecker();

        //    IHand hand = new Hand(new List<ICard>() { 
        //        new Card(CardFace.Three, CardSuit.Clubs),
        //        new Card(CardFace.Three, CardSuit.Spades),
        //        new Card(CardFace.Five, CardSuit.Diamonds),
        //        new Card(CardFace.Three, CardSuit.Hearts),
        //        new Card(CardFace.Five, CardSuit.Spades),
        //    });

        //    //bool check = checker.IsFullHouse(hand);
        //    bool actual = false;
        //    var cards = hand.Cards.OrderBy(x => x.Face).ToList();
        //    var firstCard = cards[0];
        //    int count2 = 0;
        //    int count3 = 0;

        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (cards[i].Face == cards[i + 1].Face & count2 < 2)
        //        {
        //            count3++;
        //            cards[i] = null;
        //        }
        //        else
        //        {
        //            count3 = 0;
        //        }
        //        if (count3 == 3)
        //        {
        //            break;
        //        }
        //    }

        //    cards = cards.Select(x => x).Where(x => x != null).ToList();

        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (cards[i].Face == cards[i + 1].Face & count2 < 2)
        //        {
        //            count2++;
        //            //cards[i] = null;
        //        }
        //        else
        //        {
        //            count3 = 0;
        //        }
        //        if (count3 == 3)
        //        {
        //            break;
        //        }
        //    }

        //    if (count2 == 2 & count3 == 3)
        //    {
        //        actual = true;
        //    }
        //    Assert.IsTrue(actual);
        //}

        public void Test_IsFlush()
        {
            IPokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Spades),

                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
            });

            bool check = checker.IsFlush(hand);
            bool actual = true;
            var firstCard = hand.Cards[0];
            foreach (var card in hand.Cards)
            {
                if (card.Suit != firstCard.Suit)
                {
                    actual = false;
                }
            }

            Assert.AreEqual(check, actual);
        }

    }
}
