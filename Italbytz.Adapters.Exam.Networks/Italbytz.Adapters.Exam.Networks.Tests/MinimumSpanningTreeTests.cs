using Italbytz.Ports.Exam.Networks;
using NUnit.Framework;

namespace Italbytz.Adapters.Exam.Networks.Tests
{
    public class MinimumSpanningTreeTests
    {
        IMinimumSpanningTreeSolver solver;

        [SetUp]
        public void Setup()
        {
            solver = new MinimumSpanningTreeSolver();
        }

        [Test]
        public void TestSolverGivesSolution()
        {
            var parameters = new MinimumSpanningTreeParameters();            
            var solution = solver.Solve(parameters);            
        }
    }
}
