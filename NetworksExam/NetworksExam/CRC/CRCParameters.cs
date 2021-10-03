using System;
namespace NetworksExam.CRC
{
    public class CRCParameters
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
