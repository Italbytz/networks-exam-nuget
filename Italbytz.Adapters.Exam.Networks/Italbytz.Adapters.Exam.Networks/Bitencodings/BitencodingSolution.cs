using System;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class BitencodingSolution : IBitencodingSolution
    {
        public string[] NRZ { get; set; }
        public string[] NRZI { get; set; }
        public string[] MLT3 { get; set; }
    }
}
