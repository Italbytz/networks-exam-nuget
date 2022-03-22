using System;
using System.Net;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.Networks;
using Knom.Helpers.Net;

namespace Italbytz.Adapters.Exam.Networks
{
    public class NetmaskSolver : INetmaskSolver
    {
        public NetmaskSolver()
        {
        }

        public INetmaskSolution Solve(INetmaskParameters parameters)
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
