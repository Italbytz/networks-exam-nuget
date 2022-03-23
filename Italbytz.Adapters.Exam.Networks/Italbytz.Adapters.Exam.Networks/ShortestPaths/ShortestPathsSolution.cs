using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.Networks;
using QuikGraph;

namespace Italbytz.Adapters.Exam.Networks
{
    public class ShortestPathsSolution : IShortestPathsSolution
    {
        public ShortestPathsSolution()
        {
        }

        public List<string> Paths { get; set; }
    }
}
