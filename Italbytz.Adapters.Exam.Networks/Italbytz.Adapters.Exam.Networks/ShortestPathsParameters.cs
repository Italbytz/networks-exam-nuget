using System;
using Italbytz.Extensions;
using QuikGraph;

namespace Italbytz.Adapters.Exam.Networks
{
    public class ShortestPathsParameters
    {
        readonly Random _random = new Random();
        public UndirectedGraph<string, TaggedEdge<string, double>> Graph { get; set; }
        public String[] Vertices { get; set; }

        public ShortestPathsParameters()
        {
            Vertices = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            Graph = CreateRandomGraph();
        }

        private UndirectedGraph<string, TaggedEdge<string, double>> CreateRandomGraph()
        {
            var graph = new UndirectedGraph<string, TaggedEdge<string, double>>();
            var shuffledVertices = _random.ShuffledStrings(Vertices);
            var weights = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < shuffledVertices.Length - 1; i++)
            {
                graph.AddVerticesAndEdge(new TaggedEdge<string, double>(shuffledVertices[i], shuffledVertices[i + 1], _random.RandomElement<double>(weights)));
            }

            var rnd = new Random();
            for (int i = 0; i < rnd.Next(5, 10); i++)
            {
                string vertex1, vertex2;
                do
                {
                    vertex1 = _random.RandomElement<string>(Vertices);
                    vertex2 = _random.RandomElement<string>(Vertices);
                } while (graph.ContainsEdge(vertex1, vertex2) || vertex1.Equals(vertex2));
                graph.AddVerticesAndEdge(new TaggedEdge<string, double>(vertex1, vertex2, _random.RandomElement<double>(weights)));

            }

            return graph;
        }
    }
}
