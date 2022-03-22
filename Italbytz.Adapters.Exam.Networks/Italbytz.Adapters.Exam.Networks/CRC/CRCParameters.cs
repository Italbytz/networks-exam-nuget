using System;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class CRCParameters : ICRCParameters
    {
        public byte Term { get; set; }

        public CRCParameters() : this((byte)new Random().Next(32, 64))
        {            
        }

        public CRCParameters(byte term)
        {
            Term = term;
        }
    }
}
