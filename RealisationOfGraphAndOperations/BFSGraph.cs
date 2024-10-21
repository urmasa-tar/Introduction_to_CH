using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// BFSGraph
namespace RealisationOfGraphAndOperations
{
    public class BFSGraph

    {
        private readonly Dictionary<string, List<string>> _adjacencyList;

        public BFSGraph()
        {
            _adjacencyList = new Dictionary<string, List<string>>();
        }

        // Метод для добавления вершины в граф
        public void AddVertex(string vertex)
        {
            if (!_adjacencyList.ContainsKey(vertex))
            {
                _adjacencyList[vertex] = new List<string>();
            }
        }

        // Метод для добавления ребра между вершинами
        public void AddEdge(string from, string to)
        {
            if (!_adjacencyList.ContainsKey(from))
            {
                AddVertex(from);
            }
            if (!_adjacencyList.ContainsKey(to))
            {
                AddVertex(to);
            }
            _adjacencyList[from].Add(to);
        }

        // Поиск в ширину
        public void BreadthFirstSearch(string startVertex)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<string>();

            visited.Add(startVertex);
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                string currentVertex = queue.Dequeue();
                Console.WriteLine(currentVertex); // Обработка текущей вершины

                foreach (var neighbor in _adjacencyList[currentVertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
