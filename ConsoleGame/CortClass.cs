using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class CortClass
    {
        int[][] cort;
        int lenX, lenY;


        public CortClass(ushort n, ushort m)
        {
            lenX = n; lenY = m;
            cort = new int[m][];
            inpInRow(ref cort, m, n);
            cortInp(ref cort);
        }

        private void cortInp(ref int[][] cort)
        {
            for(int posY = 0; posY < this.lenY; posY++)
            {
                for (int posX = 0; posX < this.lenX; posX++)
                {
                    if((posX == 0 )||(posY == 0) || (posX == this.lenX - 1) || (posY == this.lenY - 1)){ cort[posX][posY] = 1; } 

                }
            }
        }

        private void inpInRow(ref int[][] arr, int rows, int columns)
        {
            for (int i = 0; i < rows; i++){ arr[i] = new int[columns]; }
        }

        public int[][] getCort()
        {
            return this.cort;
        }
    }
}
