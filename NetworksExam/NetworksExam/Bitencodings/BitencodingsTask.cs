using System;
using ExamPorts;

namespace NetworksExam.Bitencodings
{
    public class BitencodingsTask : ITask
    {
        public BitencodingsTask(int score, bool mock) :
            this(score, new BitencodingParameters(), mock)
        {

        }

        public BitencodingsTask(int score, BitencodingParameters parameters, bool mock)
        {
            Score = score;
            Parameters = parameters;
            Mock = mock;

            var solver = new BitencodingSolver();
            Solution = solver.Solve(Parameters);

            Text = TextGenerator?.Generate(this);
        }

        public static ITaskTextGenerator<BitencodingsTask> TextGenerator { get; set; }

        public int Score { get; set; }
        public string Topic { get; set; } = "Bitcodierungen";
        public BitencodingSolution Solution { get; private set; }
        public ITaskText Text { get; set; }
        public BitencodingParameters Parameters { get; set; }
        public bool Mock { get; set; }
    }
}
