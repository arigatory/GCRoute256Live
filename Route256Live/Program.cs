using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;


namespace Route256Live
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Summary[] summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
