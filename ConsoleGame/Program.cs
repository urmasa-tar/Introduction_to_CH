using System;
namespace ConsoleGame
{
    public class ConsoleGame
    {
        private static readonly CortClass cortClass = new CortClass(16, 64);
        
        public static void Main(string[] args)
        {
            // checkForConsole();

            while (true)
            {
                cortPianter(64, 16);
                // Key reader
                char exit = keyReader();
                if(exit == 'e') { break; }
                
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

        private static char keyReader()
        {
            char keyChar = 'e';
            Console.ReadKey();
            return keyChar;
        }

        private static void cortPianter(int n, int m)
        {
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (cortClass.getCort()[i][j] == 1)setAndPrint(n, m, ConsoleColor.Cyan);
                }
            }
        }
    }
}