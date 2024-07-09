using System;
namespace ConsoleGame
{
    public class ConsoleGame
    {
        public static void Main(string[] args)
        {

            checkForConsole();

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