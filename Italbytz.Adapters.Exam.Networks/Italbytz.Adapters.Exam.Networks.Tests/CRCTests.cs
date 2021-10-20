using System;
using NUnit.Framework;

namespace Italbytz.Adapters.Exam.Networks.Tests
{
    public class CRCTests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test42()
        {
            var parameters = new CRCParameters((byte)42);
            var solver = new CRCSolver();
            var solution = solver.Solve(parameters);
            Assert.AreEqual(solution.Calculation.Substring(110), "10110");
            Assert.AreEqual(solution.Check.Substring(110), "00000");
        }

        [Test]
        public void Test1()
        {
            // Umsetzung mit System.Data.HashFunction.CRC.
            // https://github.com/brandondahler/Data.HashFunction/
            // Erklärt in A PAINLESS GUIDE TO CRC ERROR DETECTION ALGORITHMS
            /*
            var mycrc = CRCFactory.Instance.Create(new CRCConfig()
            {
                HashSizeInBits = 5,
                Polynomial = 0b101,
                InitialValue = 0x0,
                ReflectIn = false,
                ReflectOut = false,
                XOrOut = 0x0,
            });

            var myBytes = BitConverter.GetBytes(42);
            var myValue = mycrc.ComputeHash(myBytes);
            var myBinaryValue = myValue.AsBitArray(); /// 00011
            var representation = myBinaryValue.ToString();
            */
        }
    }
}
