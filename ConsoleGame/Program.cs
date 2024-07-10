using System;
namespace ConsoleGame
{
    public class ConsoleGame
    {
        private static readonly CortClass cortClass = new CortClass(16, 64);
        
        public static void Main(string[] args)
        {
            ushort n = 16;
            ushort m = 64;
            checkForConsole();

            while (true)
            {
                // Key reader
            }
        }

        private static void checkForConsole() {
            setAndPrint(0, 0, ConsoleColor.Green);
            setAndPrint(0, 16, ConsoleColor.Red);
            setAndPrint(64, 0, ConsoleColor.Cyan);
            setAndPrint(64, 16, ConsoleColor.Magenta);
        }

        private static void setAndPrint(int posX, int posY, ConsoleColor colorToPrint) { 

            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.SetCursorPosition(posX, posY);
            Console.BackgroundColor = colorToPrint;

            Console.WriteLine("|");

            Console.BackgroundColor = defaultColor;
        }
    }
}