using System;
using System.Net;
using Italbytz.Ports.Exam.Networks;

namespace Italbytz.Adapters.Exam.Networks
{
    public class NetmaskSolution : INetmaskSolution
    {
        public NetmaskSolution()
        {
        }

        public IPAddress NetworkAddress { get; set; }
        public IPAddress HostAddress { get; set; }
    }
}
