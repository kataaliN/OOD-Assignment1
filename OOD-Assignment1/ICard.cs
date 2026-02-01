using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Assignment1
{
    interface ICard
    {
        //start with properties needed for all cards
        string rank { get; }
        int suit {  get; }

        //define methods all cards would need to implement
        bool ranksMatch(Rank rank);
        bool suitsMatch(Suit suit);
        bool isEightCard(ICard card);
        bool isCardPlayable(ICard card, Suit suit); //defines whether the current move is legal or not
        
    }

    //define an enum to hold the suit
    enum Suit{
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    //define an enum to hold the rank as well
    enum Rank
    {
        Ace,
        Two,
        Three,
        Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
}
