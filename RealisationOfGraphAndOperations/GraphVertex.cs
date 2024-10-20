using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{

    public class GraphVertex
    {

        public string Name { get; }


        public List<GraphEdge> Edges { get; }


        public GraphVertex(string vertexName)
        {
            Name = vertexName;
            Edges = new List<GraphEdge>();
        }


        public void AddEdge(GraphEdge newEdge)
        {
            Edges.Add(newEdge);
        }

  
        public void AddEdge(GraphVertex vertex, int edgeWeight)
        {
            AddEdge(new GraphEdge(vertex, edgeWeight));
        }

 
        public override string ToString() => Name;
    }
}
