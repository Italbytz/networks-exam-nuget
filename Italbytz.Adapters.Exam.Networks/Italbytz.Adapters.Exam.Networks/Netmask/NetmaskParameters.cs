using System;
using Italbytz.Extensions;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class NetmaskParameters : INetmaskParameters
    {
        public int PrefixLength { get; set; }
        public string Address { get; set; }

        public NetmaskParameters() : this(
            string.Join(".", new Random().NextIntArray(4, 1, 255)),
            new Random().Next(21, 30))
        {
        }

        public NetmaskParameters(string address, int prefixLength)
        {
            PrefixLength = prefixLength;
            Address = address;
        }
    }
}
