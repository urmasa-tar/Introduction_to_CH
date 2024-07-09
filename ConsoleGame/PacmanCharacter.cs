using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class PacmanCharacter
    {
        char characterSymbol = Convert.ToChar(2);
        int posX = 32; // from 0 to 64
        int posY = 8; // from 0 to 16
        
        public PacmanCharacter(char symSet, ConsoleColor charCol) {
            characterSymbol = symSet;
            Console.ForegroundColor = charCol;
        }

        public static void Move(char keyChar)
        {

        }

        private bool Colysion()
        {
            bool corStat = false;

            if(posX <= 0){ posX = 63; }
            if (posX >= 64){ posX = 1; }
            if (posY <= 0){ posY = 15; }
            if (posY >= 16){ posY = 1; }
            return corStat;
        }
    }
}
