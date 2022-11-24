using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.Networks;
using Italbytz.Ports.Graph;
using QuikGraph;

namespace Italbytz.Adapters.Exam.Networks
{
    public class MinimumSpanningTreeSolution : IMinimumSpanningTreeSolution
    {
        public MinimumSpanningTreeSolution()
        {
        }

        public IEnumerable<ITaggedEdge<string, double>> Edges { get; set; }
    }
}
