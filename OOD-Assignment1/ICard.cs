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
        int Suit {  get; }

        //define methods all cards would need to implement
        bool ranksMatch();
        bool suitsMatch();
        bool isEightCard();
        
    }

    //define an enum to hold the suit
    enum Suit{
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
