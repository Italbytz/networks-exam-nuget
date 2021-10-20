using System;
using System.Net;

namespace Italbytz.Adapters.Exam.Networks
{
    public class NetmaskSolution
    {
        public NetmaskSolution()
        {
        }

        public IPAddress NetworkAddress { get; internal set; }
        public IPAddress HostAddress { get; internal set; }
    }
}
