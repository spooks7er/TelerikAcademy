using System;
using System.Linq;
namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool valid = false;
            valid = hand.Cards.Count == 5;
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
                        valid = false;
                        break;
                    }
                }
            } return valid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var check  = IsFlush(hand);

            var cardsSortedFace = hand.Cards.OrderBy(x => x.Face).ToList();
            for (int i = 0; i < 4; i++)
            {
                if (cardsSortedFace[i].Face + 1 != cardsSortedFace[i + 1].Face)
                {
                    check = false;
                }
            }

            return check;
        }

        public bool IsFourOfAKind(IHand hand)
        {
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
                    return true;
                }
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var firstCard = hand.Cards[0];
            foreach (var card in hand.Cards)
            {
                if (card.Suit != firstCard.Suit)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
