using System;
namespace ConsoleGame
{
    public class ConsoleGame
    {
        public static void Main(string[] args)
        {
            DrawbleBar barForProgres = new DrawbleBar();
            int presHealth = 5, maxHealth = 10;

            barForProgres.drawBar(presHealth, maxHealth, ConsoleColor.Green);
        }
    }
}