using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    class Vertex
    {
        public int x, y;
        public Color color;
        public int Vertex_Stepen;
        public int Vertex_number;



        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
            color = Color.White;
            Vertex_number = 0;
            Vertex_Stepen = 0;
        }

        public Vertex(int x, int y, Color c)
        {
            this.x = x;
            this.y = y;
            color = c;
            Vertex_number = 0;
            Vertex_Stepen = 0;
        }
    }
}
