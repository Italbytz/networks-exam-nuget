using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.Networks;
using QuikGraph;

namespace Italbytz.Adapters.Exam.Networks
{
    public class MinimumSpanningTreeSolution : IMinimumSpanningTreeSolution
    {
        public MinimumSpanningTreeSolution()
        {
        }

        public IEnumerable<Ports.Exam.Networks.ITagged<string>> Edges { get; set; }
    }
}
