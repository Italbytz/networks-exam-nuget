using NetworksExam.Bitencodings;
using NUnit.Framework;

namespace NetworksExam.Tests
{
    public class BitencodingsTests
    {
        BitencodingSolver solver;

        [SetUp]
        public void Setup()
        {
            solver = new BitencodingSolver();
        }

        [Test]
        public void TestSolverGivesSolution()
        {
            var parameters = new BitencodingParameters();            
            var solution = solver.Solve(parameters);
            Assert.True(solution.NRZ.Length > 0);
            Assert.True(solution.NRZI.Length > 0);
            Assert.True(solution.MLT3.Length > 0);
        }
    }
}
