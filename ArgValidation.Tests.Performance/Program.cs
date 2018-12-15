using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ArgValidation.Tests.Performance
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NativeVsNameOfVsExpressionTree
    {
        [Params(1)] 
        public int N;

        [Benchmark]
        public void Native()
        {
        }

        [Benchmark]
        public void NameOf()
        {
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NativeVsNameOfVsExpressionTree>();
        }
    }
}