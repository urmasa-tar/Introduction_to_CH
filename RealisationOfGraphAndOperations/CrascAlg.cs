using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    public class CrascalAlg
    {
        private List<Edge> edges;
        private int verticesCount;

        public CrascalAlg(int verticesCount)
        {
            this.verticesCount = verticesCount;
            edges = new List<Edge>();
        }

        public void AddEdge(int source, int destination, int weight)
        {
            edges.Add(new Edge(source, destination, weight));
        }

        public List<Edge> KruskalMST()
        {
            edges.Sort(); // Сортируем рёбра по весу
            var parent = new int[verticesCount];
            var rank = new int[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                parent[i] = i;
                rank[i] = 0;
            }

            List<Edge> result = new List<Edge>();

            foreach (var edge in edges)
            {
                int root1 = Find(parent, edge.Source);
                int root2 = Find(parent, edge.Destination);

                // Если корни разные, добавляем это ребро в результат
                if (root1 != root2)
                {
                    result.Add(edge);
                    Union(parent, rank, root1, root2);
                }
            }

            return result;
        }

        private int Find(int[] parent, int vertex)
        {
            if (parent[vertex] != vertex)
            {
                parent[vertex] = Find(parent, parent[vertex]);
            }
            return parent[vertex];
        }

        private void Union(int[] parent, int[] rank, int root1, int root2)
        {
            if (rank[root1] > rank[root2])
            {
                parent[root2] = root1;
            }
            else if (rank[root1] < rank[root2])
            {
                parent[root1] = root2;
            }
            else
            {
                parent[root2] = root1;
                rank[root1]++;
            }
        }
    }

}
