using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    class conGraph
    {
        private Dictionary<int, List<int>> adjacencyList;

        // Конструктор класса Graph
        public conGraph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Метод для добавления вершины в граф
        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();
            }
        }

        // Метод для добавления ребра в граф
        public void AddEdge(int vertex1, int vertex2)
        {
            AddVertex(vertex1);
            AddVertex(vertex2);
            adjacencyList[vertex1].Add(vertex2);
            adjacencyList[vertex2].Add(vertex1); // Для неориентированного графа
        }

        // Метод для проверки связности графа
        public bool IsConnected()
        {
            if (adjacencyList.Count == 0) return true;

            var visited = new HashSet<int>();
            int startVertex = adjacencyList.Keys.First(); // Начинаем с первой вершины

            DFS(startVertex, visited);

            return visited.Count == adjacencyList.Count; // Сравниваем количество посещенных вершин с общим количеством вершин
        }

        // Рекурсивный метод DFS
        private void DFS(int vertex, HashSet<int> visited)
        {
            visited.Add(vertex);

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    DFS(neighbor, visited);
                }
            }
        }
    }
}
