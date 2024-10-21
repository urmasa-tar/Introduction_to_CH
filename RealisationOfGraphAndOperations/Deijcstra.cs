using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisationOfGraphAndOperations
{
    public class Dijkstra
    {
        Graph graph;

        List<GraphVertexInfo> infos;

        public Dijkstra(Graph graph)
        {
            this.graph = graph;
        }


        void InitInfo()
        {
            infos = new List<GraphVertexInfo>();
            foreach (var v in graph.Vertices)
            {
                infos.Add(new GraphVertexInfo(v));
            }
        }


        GraphVertexInfo GetVertexInfo(GraphVertex v)
        {
            foreach (var i in infos)
            {
                if (i.Vertex.Equals(v))
                {
                    return i;
                }
            }

            return null;
        }


        public GraphVertexInfo FindUnvisitedVertexWithMinSum()
        {
            var minValue = int.MaxValue;
            GraphVertexInfo minVertexInfo = null;
            foreach (var i in infos)
            {
                if (i.IsUnvisited && i.EdgesWeightSum < minValue)
                {
                    minVertexInfo = i;
                    minValue = i.EdgesWeightSum;
                }
            }

            return minVertexInfo;
        }


        public string FindShortestPath(string startName, string finishName)
        {
            return FindShortestPath(graph.FindVertex(startName), graph.FindVertex(finishName));
        }


        public string FindShortestPath(GraphVertex startVertex, GraphVertex finishVertex)
        {
            InitInfo();
            var first = GetVertexInfo(startVertex);
            first.EdgesWeightSum = 0;
            while (true)
            {
                var current = FindUnvisitedVertexWithMinSum();
                if (current == null)
                {
                    break;
                }

                SetSumToNextVertex(current);
            }

            return GetPath(startVertex, finishVertex);
        }


        void SetSumToNextVertex(GraphVertexInfo info)
        {
            info.IsUnvisited = false;
            foreach (var e in info.Vertex.Edges)
            {
                var nextInfo = GetVertexInfo(e.ConnectedVertex);
                var sum = info.EdgesWeightSum + e.EdgeWeight;
                if (sum < nextInfo.EdgesWeightSum)
                {
                    nextInfo.EdgesWeightSum = sum;
                    nextInfo.PreviousVertex = info.Vertex;
                }
            }
        }


        string GetPath(GraphVertex startVertex, GraphVertex endVertex)
        {
            var path = endVertex.ToString();
            while (startVertex != endVertex)
            {
                endVertex = GetVertexInfo(endVertex).PreviousVertex;
                path = endVertex.ToString() + path;
            }

            return path;
        }
    }
}
