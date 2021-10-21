using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam;
using QuikGraph;
using QuikGraph.Algorithms;

namespace Italbytz.Adapters.Exam.Networks
{
    public class ShortestPathsSolver : ISolver<ShortestPathsParameters, ShortestPathsSolution>
    {
        public ShortestPathsSolver()
        {
        }

        public ShortestPathsSolution Solve(ShortestPathsParameters parameters)
        {
            var graph = parameters.Graph;
            TryFunc<string, IEnumerable<TaggedEdge<string, double>>>
                tryGetPaths = graph.ShortestPathsDijkstra((edge) => edge.Tag, "A");
            var paths = new List<string>();
            foreach (var vertex in parameters.Vertices)
            {
                if (vertex != "A" && tryGetPaths(vertex, out IEnumerable<TaggedEdge<string, double>> path))
                {
                    var pathString = "";
                    foreach (var edge in path)
                    {
                        pathString += edge;
                    }
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
