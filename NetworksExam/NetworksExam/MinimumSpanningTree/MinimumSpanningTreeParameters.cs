using System;
using QuikGraph;
using RandomExtensions;

namespace NetworksExam.MinimumSpanningTree
{
    public class MinimumSpanningTreeParameters
    {
        readonly Random _random = new Random();
        public UndirectedGraph<string, TaggedEdge<string, double>> Graph { get; set; }

        public MinimumSpanningTreeParameters()
        {
            Graph = CreateRandomGraph();
        }

        private UndirectedGraph<string, TaggedEdge<string, double>> CreateRandomGraph()
        {
            var graph = new UndirectedGraph<string, TaggedEdge<string, double>>();
            var vertices = new string[] { "A", "B", "C", "D", "E", "F" };
            var shuffledVertices = _random.ShuffledStrings(vertices);
            var weights = new double[] { 2, 4, 19, 62, 100, 250 };
            for (int i = 0; i < shuffledVertices.Length - 1; i++)
            {
                graph.AddVerticesAndEdge(new TaggedEdge<string, double>(shuffledVertices[i], shuffledVertices[i + 1], _random.RandomElement<double>(weights)));
            }

            var rnd = new Random();
            for (int i = 0; i < rnd.Next(3, 6); i++)
            {
                string vertex1, vertex2;
                do
                {
                    vertex1 = _random.RandomElement<string>(vertices);
                    vertex2 = _random.RandomElement<string>(vertices);
                } while (graph.ContainsEdge(vertex1, vertex2) || vertex1.Equals(vertex2));
                graph.AddVerticesAndEdge(new TaggedEdge<string, double>(vertex1, vertex2, _random.RandomElement<double>(weights)));

            }
            return graph;
        }
    }
}
