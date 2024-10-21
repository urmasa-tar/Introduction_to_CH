using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    class compSearch
    {
        private int vertices; // Количество вершин
        private List<int>[] adjacencyList; // Список смежности

        public compSearch(int v)
        {
            vertices = v;
            adjacencyList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        // Метод для добавления ребра
        public void AddEdge(int v, int w)
        {
            adjacencyList[v].Add(w);
            adjacencyList[w].Add(v); // Для неориентированного графа
        }

        // Рекурсивный метод DFS
        private void DFS(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " "); // Обработка текущей вершины

            foreach (var neighbor in adjacencyList[v])
            {
                if (!visited[neighbor])
                {
                    DFS(neighbor, visited);
                }
            }
        }

        // Метод для определения компонент связности
        public void FindConnectedComponents()
        {
            bool[] visited = new bool[vertices];
            int componentCount = 0;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v])
                {
                    Console.WriteLine($"Компонента связности {++componentCount}:");
                    DFS(v, visited);
                    Console.WriteLine();
                }
            }

            if (componentCount == 0)
            {
                Console.WriteLine("Граф не содержит ни одной компоненты связности.");
            }
        }
    }
}
