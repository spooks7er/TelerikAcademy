using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }
        
        public override string ToString()
        {
            var bulder = new StringBuilder();
            int count=0;
            foreach (var card in this.Cards)
            {
                count++;
                bulder.AppendLine(string.Format("Card {0} - {1}", count, card.ToString()));
            }
            return bulder.ToString();
        }
    }
}
