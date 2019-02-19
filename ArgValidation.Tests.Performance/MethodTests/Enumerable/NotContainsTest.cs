using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotContainsTest
    {
        private readonly string[] ArrayWith2Elems = {"1", "2"};

        [Benchmark]
        public void Native()
        {
            if (ArrayWith2Elems.Contains("3"))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems)).NotContains("3");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems))
                .NotContains("3")
                .NotContains("3")
                .NotContains("3");
        }
    }
}