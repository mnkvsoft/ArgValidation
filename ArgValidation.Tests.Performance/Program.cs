using ArgValidation.Tests.Performance.MethodTests;
using BenchmarkDotNet.Running;

namespace ArgValidation.Tests.Performance
{
    class Program
    {
        public static void Main(string[] args)
        {
            //BenchmarkRunner.Run<DefaultTest>();
            //BenchmarkRunner.Run<NotDefaultTest>();
            //BenchmarkRunner.Run<NotNullTest>();
            //BenchmarkRunner.Run<NullTest>();
            //BenchmarkRunner.Run<EqualTest>();
            //BenchmarkRunner.Run<NotEqualTest>();
            //BenchmarkRunner.Run<InTest>();
            //BenchmarkRunner.Run<NotInTest>();
            BenchmarkRunner.Run<FailedIfTest>();
        }
    }
}