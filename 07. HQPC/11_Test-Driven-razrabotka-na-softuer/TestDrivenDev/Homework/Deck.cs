using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Deck : IDeck
    {
        private readonly IList<Card> listOfCards;
        private readonly Random rand = new Random();

        public Deck()
        {
            this.listOfCards = new List<Card>();
            foreach (var cardSuit in this.GetAllCardSuits())
            {
                foreach (var cardFace in this.GetAllCardTypes())
                {
                    this.listOfCards.Add(new Card(cardFace, cardSuit));
                }
            }

            this.listOfCards = Shuffle(this.listOfCards).ToList();
        }

        private IEnumerable<Card> Shuffle(IEnumerable<Card> source)
        {
            var array = source.ToArray();
            var n = array.Length;
            for (var i = 0; i < n; i++)
            {
                // Exchange a[i] with random element in a[i..n-1]
                int r = i + rand.Next(0, n - i);
                var temp = array[i];
                array[i] = array[r];
                array[r] = temp;
            }

            return array;
        }

        public Card GetNextCard()
        {
            if (this.listOfCards.Count == 0)
            {
                throw new ArgumentException("Deck is empty!");
            }

            var card = this.listOfCards[this.listOfCards.Count - 1];
            this.listOfCards.RemoveAt(this.listOfCards.Count - 1);
            return card;
        }

        public int CardsLeft
        {
            get { return this.listOfCards.Count; }
        }

        private IEnumerable<CardFace> GetAllCardTypes()
        {
            return new List<CardFace>
            {
                CardFace.Two,
                CardFace.Three,
                CardFace.Four,
                CardFace.Five,
                CardFace.Six,
                CardFace.Seven,
                CardFace.Eight,
                CardFace.Nine,
                CardFace.Ten,
                CardFace.Jack,
                CardFace.Queen,
                CardFace.King,
                CardFace.Ace,
            };
        }

        private IEnumerable<CardSuit> GetAllCardSuits()
        {
            return new List<CardSuit>
            {
                CardSuit.Clubs,
                CardSuit.Diamonds,
                CardSuit.Hearts,
                CardSuit.Spades,
            };
        }
    }
}
