using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks.Graph
{
    public class UndirectedGraph<TVertex, TEdge> : IUndirectedGraph<TVertex, TEdge> where TEdge : IEdge<TVertex>
    {
        public UndirectedGraph()
        {
        }

        public IEnumerable<TEdge> Edges { get; set; }
    }
}
