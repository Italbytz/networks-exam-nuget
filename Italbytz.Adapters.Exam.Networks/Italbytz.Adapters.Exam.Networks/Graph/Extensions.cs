using System;
using System.Linq;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks.Graph
{
    public static class Extensions
    {
        public static Ports.Exam.Networks.IUndirectedGraph<string, ITaggedEdge<string, double>> ToGenericGraph(this QuikGraph.UndirectedGraph<string, QuikGraph.TaggedEdge<string, double>> graph)
        {
            var edges = graph.Edges.Select(edge => edge.ToGenericEdge()).ToList();
            return new UndirectedGraph<string, ITaggedEdge<string, double>>() { Edges = edges };
        }

        public static QuikGraph.UndirectedGraph<string, QuikGraph.TaggedEdge<string, double>> ToQuikGraph(this Ports.Exam.Networks.IUndirectedGraph<string, ITaggedEdge<string, double>> graph)
        {
            var quikgraph = new QuikGraph.UndirectedGraph<string, QuikGraph.TaggedEdge<string, double>>();
            var edges = graph.Edges.Select(edge => edge.ToQuikEdge()).ToList();
            quikgraph.AddVerticesAndEdgeRange(edges);
            return quikgraph;
        }

        public static TaggedEdge<string, double> ToGenericEdge(this QuikGraph.TaggedEdge<string, double> edge)
            => new TaggedEdge<string, double>(edge.Source, edge.Target, edge.Tag);

        public static QuikGraph.TaggedEdge<string, double> ToQuikEdge(this ITaggedEdge<string, double> edge)
            => new QuikGraph.TaggedEdge<string, double>(edge.Source, edge.Target, edge.Tag);

    }
}
