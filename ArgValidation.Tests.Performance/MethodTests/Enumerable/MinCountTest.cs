using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class MinCountTest
    {
        private readonly string[] ArrayWith2Elems = {"1", "2"};

        [Benchmark]
        public void Native()
        {
            if (ArrayWith2Elems.Length < 1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems)).MinCount(1);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems))
                .MinCount(1)
                .MinCount(1)
                .MinCount(1);
        }
    }
}