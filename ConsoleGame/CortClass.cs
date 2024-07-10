using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    internal class CortClass
    {
        ushort[][] cort;
        ushort lenX, lenY;


        public CortClass(ushort n, ushort m)
        {
            lenX = n; lenY = m;
            cort = new ushort[m][n];
            cortInp(ref cort);
        }

        private void cortInp(ref ushort[][] cort)
        {
            for(ushort posY = 0; posY < this.lenY; posY++)
            {
                for (ushort posX = 0; posX < this.lenX; posX++)
                {
                    if((posX == 0 )||(posY == 0) || (posX == this.lenX - 1) || (posY == this.lenY - 1)){ cort[posX][posY] = 1; } 

                }
            }
        }


    }
}
