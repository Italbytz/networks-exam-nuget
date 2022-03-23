using System;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks.Graph
{
    public class TaggedEdge<TVertex, TTag> : ITaggedEdge<TVertex, TTag>
    {
        public TaggedEdge()
        {
        }

        public TaggedEdge(TVertex source, TVertex target, TTag tag)
        {
            Source = source;
            Target = target;
            Tag = tag;
        }

        public TTag Tag { get; set; }

        public TVertex Source { get; set; }

        public TVertex Target { get; set; }
    }
}
