using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Assignment1
{
    interface IPlayer
    {
        string playerName { get; }

        void takeTurn(); //decides which player's turn it is
        void playCard(); // requires player to play their turn
        void drawCardFromDeck(); //requires player to add a card to their hand when they can't match suit or deck
        bool hasWon { get; } // determines when a player wins
        void receiveCard(ICard card); //used to deal cards at the start of the game, allows for drawn card to be added to the player's hand
    }
}
