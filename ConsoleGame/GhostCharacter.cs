using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class GhostCharacter
    {
        ushort posX, posY;
        public GhostCharacter(ushort baseX = 0, ushort baseY = 0)
        { 
            posX = baseX;
            posY = baseY;
        }

        public bool Move()
        {
            bool res = true;

            return res;
        }

    }
}
