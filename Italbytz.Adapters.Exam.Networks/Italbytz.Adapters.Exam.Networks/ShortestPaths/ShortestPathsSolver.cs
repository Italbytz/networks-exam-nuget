using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.Networks;
using QuikGraph;
using QuikGraph.Algorithms;
using Italbytz.Adapters.Exam.Networks.Graph;

namespace Italbytz.Adapters.Exam.Networks
{
    public class ShortestPathsSolver : IShortestPathsSolver
    {
        public ShortestPathsSolver()
        {
        }

        public IShortestPathsSolution Solve(IShortestPathsParameters parameters)
        {
            var graph = parameters.Graph.ToQuikGraph();
            TryFunc<string, IEnumerable<QuikGraph.TaggedEdge<string, double>>>
                tryGetPaths = graph.ShortestPathsDijkstra((edge) => edge.Tag, "A");
            var paths = new List<string>();
            foreach (var vertex in parameters.Vertices)
            {
                if (vertex != "A" && tryGetPaths(vertex, out IEnumerable<QuikGraph.TaggedEdge<string, double>> path))
                {
                    var pathString = "A";
                    var cost = 0;
                    var lastVertex = "A";
                    foreach (var edge in path)
                    {
                        cost += (int)edge.Tag;
                        lastVertex = edge.GetOtherVertex(lastVertex);
                        pathString += $" -> {lastVertex}";
                    }
                    pathString += $" ({cost})";
                    paths.Add(pathString);
                }
            }
            return new ShortestPathsSolution
            {
                Paths = paths
            };
        }
    }
}
