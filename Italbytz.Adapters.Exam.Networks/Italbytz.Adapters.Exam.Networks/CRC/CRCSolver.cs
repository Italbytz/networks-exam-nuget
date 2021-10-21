using System;
using Italbytz.Ports.Exam;

namespace Italbytz.Adapters.Exam.Networks
{
    public class CRCSolver : ISolver<CRCParameters, CRCSolution>
    {
        public CRCSolver()
        {
        }

        public CRCSolution Solve(CRCParameters parameters)
        {
            var crc = CRC5(parameters.Term, 0x0);
            var crcTest = CRC5(parameters.Term, crc.Item2);
            var solution = new CRCSolution
            {
                Calculation = crc.Item1,
                Check = crcTest.Item1
            };
            return solution;
        }

        private (string, ushort) CRC5(ushort value, ushort crc)
        {
            ushort padded = (ushort)((value << 5) + crc);
            ushort poly = 0x25 << 5;
            var result = "";

            for (int i = 10; i > 4; i--)
            {
                var msb = (padded >> i) & 0x1;
                if (msb == 0x1)
                {
                    result += $"{Convert.ToString(padded, 2).PadLeft(11, '0')}\n\n{Convert.ToString(poly, 2).PadLeft(11, '0')}\n\n";
                    padded ^= poly;
                }
                poly >>= 1;
            }
            result += Convert.ToString(padded, 2).PadLeft(11, '0');
            return (result, (ushort)(padded));

        }
    }
}
