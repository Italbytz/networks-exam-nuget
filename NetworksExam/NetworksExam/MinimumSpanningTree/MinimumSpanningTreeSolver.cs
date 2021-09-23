using System;
using System.Collections.Generic;
using ExamPorts;
using QuikGraph;
using QuikGraph.Algorithms;

namespace NetworksExam.MinimumSpanningTree
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
