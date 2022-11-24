using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using Italbytz.Ports.Exam.Networks;
using Microsoft.Msagl.Core.Geometry;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;

namespace Italbytz.Adapters.Exam.Networks.Graph
{
    public static class Extensions
    {
        public static BasicGraphOnEdges<Microsoft.Msagl.Core.GraphAlgorithms.IEdge> ToBasicGraphOnEdges(this Ports.Exam.Networks.IUndirectedGraph<string, ITaggedEdge<string, double>> graph)
        {
            var edges = graph.Edges.Select(edge => edge.ToWeightedEdge()).ToList();
            return new BasicGraphOnEdges<Microsoft.Msagl.Core.GraphAlgorithms.IEdge>(edges);
        }

        public static GeometryGraph ToGeometryGraph(this Ports.Exam.Networks.IUndirectedGraph<string, ITaggedEdge<string, double>> graph,
        double nodeSize = 30.0, double labelWidth = 60.0, double labelHeight = 30.0)
        {
            var geometryGraph = new GeometryGraph();
            var nodes = new Dictionary<string, Node>();
            foreach (var edge in graph.Edges)
            {
                Node? node = null;
                if (!nodes.ContainsKey(edge.Source))
                {
                    node = new Node(CurveFactory.CreateRectangle(nodeSize, nodeSize, new Point()), edge.Source);
                    nodes.Add(edge.Source, node);
                    geometryGraph.Nodes.Add(node);
                }
                if (!nodes.ContainsKey(edge.Target))
                {
                    node = new Node(CurveFactory.CreateRectangle(nodeSize, nodeSize, new Point()), edge.Target);
                    nodes.Add(edge.Target, node);
                    geometryGraph.Nodes.Add(node);
                }
                geometryGraph.Edges.Add(new Edge(nodes[edge.Source], nodes[edge.Target])
                {
                    Label = new Microsoft.Msagl.Core.Layout.Label()
                    {
                        Width = labelWidth,
                        Height = labelHeight
                    }
                });
            }

            return geometryGraph;
        }

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

        public static ITaggedEdge<string, double> ToGenericEdge(this WeightedEdge<double> edge)
            => new TaggedEdge<string, double>(((char)edge.Source).ToString(), ((char)edge.Target).ToString(), edge.Weight);

        public static ITaggedEdge<string, double> ToGenericEdge(this QuikGraph.TaggedEdge<string, double> edge)
            => new TaggedEdge<string, double>(edge.Source, edge.Target, edge.Tag);

        public static QuikGraph.TaggedEdge<string, double> ToQuikEdge(this ITaggedEdge<string, double> edge)
            => new QuikGraph.TaggedEdge<string, double>(edge.Source, edge.Target, edge.Tag);

        public static WeightedEdge<Double> ToWeightedEdge(this ITaggedEdge<string, double> edge) =>
        new WeightedEdge<double>()
        {
            Source = (int)edge.Source.ToCharArray()[0],
            Target = (int)edge.Target.ToCharArray()[0],
            Weight = edge.Tag
        };

    }
}
