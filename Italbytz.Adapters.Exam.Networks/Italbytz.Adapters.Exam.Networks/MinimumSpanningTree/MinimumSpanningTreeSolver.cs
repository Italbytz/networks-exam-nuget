using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.Networks;
using QuikGraph;
using QuikGraph.Algorithms;
using Italbytz.Adapters.Exam.Networks.Graph;
using System.Linq;

namespace Italbytz.Adapters.Exam.Networks
{
    public class MinimumSpanningTreeSolver : IMinimumSpanningTreeSolver
    {
        public MinimumSpanningTreeSolver()
        {
        }

        public IMinimumSpanningTreeSolution Solve(IMinimumSpanningTreeParameters parameters)
        {
            var graph = parameters.Graph.ToQuikGraph();
            IEnumerable<QuikGraph.TaggedEdge<string, double>> minimumSpanningTree = graph.MinimumSpanningTreePrim((edge) => edge.Tag);
            return new MinimumSpanningTreeSolution
            {
                Edges = (IEnumerable<Ports.Exam.Networks.ITagged<string>>)minimumSpanningTree.Select(edge => edge.ToGenericEdge())
            };
        }

    }
}
