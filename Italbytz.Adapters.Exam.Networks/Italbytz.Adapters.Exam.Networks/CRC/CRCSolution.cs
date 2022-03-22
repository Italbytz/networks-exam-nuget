using System;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class CRCSolution : ICRCSolution
    {
        public CRCSolution()
        {
        }

        public string Calculation { get; set; }
        public string Check { get; set; }
    }
}
