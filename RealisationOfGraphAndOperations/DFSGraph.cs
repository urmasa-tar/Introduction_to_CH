using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    class DFSGraph
    {
        private Dictionary<string, List<string>> adjacencyList;

        public DFSGraph()
        {
            adjacencyList = new Dictionary<string, List<string>>();
        }

        public void AddEdge(string v, string w)
        {
            if (!adjacencyList.ContainsKey(v))
            {
                adjacencyList[v] = new List<string>();
            }
            adjacencyList[v].Add(w);
        }

        public void DFS(string startVertex)
        {
            HashSet<string> visited = new HashSet<string>();
            DFSRecursive(startVertex, visited);
        }

        private void DFSRecursive(string vertex, HashSet<string> visited)
        {
            visited.Add(vertex);
            Console.WriteLine(vertex); // Обработка текущей вершины

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    DFSRecursive(neighbor, visited);
                }
            }
        }
    }
}
