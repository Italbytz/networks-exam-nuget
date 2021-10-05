using System;
using System.Net;

namespace NetworksExam.Netmask
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
