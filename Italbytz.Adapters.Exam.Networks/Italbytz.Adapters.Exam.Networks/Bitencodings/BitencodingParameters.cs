using System;
using Italbytz.Extensions;

namespace Italbytz.Adapters.Exam.Networks
{
    public class BitencodingParameters
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
