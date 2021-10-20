using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam;
using QuikGraph;
using QuikGraph.Algorithms;

namespace Italbytz.Adapters.Exam.Networks
{
    public class MinimumSpanningTreeSolver : ISolver<MinimumSpanningTreeParameters, MinimumSpanningTreeSolution>
    {
        public MinimumSpanningTreeSolver()
        {
        }

        public MinimumSpanningTreeSolution Solve(MinimumSpanningTreeParameters parameters)
        {
            var graph = parameters.Graph;
            IEnumerable<TaggedEdge<string, double>> minimumSpanningTree = graph.MinimumSpanningTreePrim((edge) => edge.Tag);
            return new MinimumSpanningTreeSolution
            {
                Edges = minimumSpanningTree
            };
        }
    }
}
