using Italbytz.Ports.Exam.Networks;
using Italbytz.Adapters.Exam.Networks.Graph;
using NUnit.Framework;

namespace Italbytz.Adapters.Exam.Networks.Tests
{
    public class ShortestPathsTests
    {
        IShortestPathsSolver solver;

        [SetUp]
        public void Setup()
        {
            solver = new ShortestPathsSolver();
        }

        [Test]
        public void TestSolverGivesSolution()
        {
            var parameters = new ShortestPathsParameters();
            var solution = solver.Solve(parameters);
            foreach (var path in solution.Paths)
            {
                System.Console.WriteLine(path.ToString());
            }
        }

    }
}
