using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class DrawbleBar
    {

        public void drawBar(int stValue, int maxVal, ConsoleColor colorState)
        {
            ConsoleColor defColor = Console.BackgroundColor;
            string progBar = "";

            for (int barPart = 0; barPart < stValue; barPart++) { progBar += " "; }

            Console.SetCursorPosition(0, 0);

            Console.Write("[");
            Console.BackgroundColor = colorState;
            Console.Write(progBar);

            Console.BackgroundColor = defColor;
            progBar = "";
            for (int barPart = stValue; barPart < maxVal; barPart++) { progBar += " "; }
            Console.Write(progBar);
            Console.Write("]\n");

        }

        public void drawBar(int stValue, int maxVal, ConsoleColor colorState, int posX, int posY)
        {
            ConsoleColor defColor = Console.BackgroundColor;
            string progBar = "";

            for (int barPart = 0; barPart < stValue; barPart++) { progBar += " "; }

            Console.SetCursorPosition(posY, posX);

            Console.Write("[");
            Console.BackgroundColor = colorState;
            Console.Write(progBar);

            Console.BackgroundColor = defColor;
            progBar = "";
            for(int barPart = stValue; barPart < maxVal; barPart++){ progBar += " "; }
            Console.Write(progBar);
            Console.Write("]\n");

        }
    }
}
