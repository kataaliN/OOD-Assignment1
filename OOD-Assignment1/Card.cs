using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Assignment1
{
    class Card : ICard
    {
        public Rank rank;
        public Suit suit;

        public Card (Rank rank, Suit suit) //constructor
        {
            this.rank = rank;
            this.suit = suit;
        }

        public bool ranksMatch(Rank r)
        {
            return r == this.rank;
        }

        public bool suitsMatch(Suit s)
        {
            return s == this.suit;
        }

        public bool isEightCard(ICard card)
        {
            return card.rank == Rank.Eight;
        }

        public bool isCardPlayable(ICard topCard, Suit currentSuit)
        { // a card is playable if it's an 8, if it matches the current suit or if it matches the rank at the top of the stack
            if (this.rank == Rank.Eight)
            {
                return true;
            }

            if (this.rank == topCard.rank)
            {
                return true;
            }

            if (this.suit == currentSuit)
            {
                return true;
            }

            else return false;
        }
    }
}
