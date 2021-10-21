using System;
using System.Net;
using Italbytz.Ports.Exam;
using Knom.Helpers.Net;

namespace Italbytz.Adapters.Exam.Networks
{
    public class NetmaskSolver : ISolver<NetmaskParameters, NetmaskSolution>
    {
        public NetmaskSolver()
        {
        }

        public NetmaskSolution Solve(NetmaskParameters parameters)
        {
            var IPAddr = IPAddress.Parse(parameters.Address);
            var SubMask = SubnetMask.CreateByNetBitLength(parameters.PrefixLength);
            var solution = new NetmaskSolution
            {
                NetworkAddress = IPAddr.GetNetworkAddress(SubMask),
                HostAddress = IPAddr.GetHostAddress(SubMask)
            };
            return solution;
        }
    }
}
