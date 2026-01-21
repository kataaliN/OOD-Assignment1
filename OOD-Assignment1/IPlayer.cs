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

        void takeTurn();
        void playCard();
        void drawCard();
        bool hasWon { get; }
    }
}
