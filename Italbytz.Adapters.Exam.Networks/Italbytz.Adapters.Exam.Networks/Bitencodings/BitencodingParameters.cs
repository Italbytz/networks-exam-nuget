using System;
using Italbytz.Extensions;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class BitencodingParameters : IBitencodingParameters
    {
        public int[] Bits { get; set; }

        public BitencodingParameters() : this(new Random().NextIntArray(10, 0, 1))
        {
        }

        public BitencodingParameters(int[] bits)
        {
            Bits = bits;
        }
    }
}
