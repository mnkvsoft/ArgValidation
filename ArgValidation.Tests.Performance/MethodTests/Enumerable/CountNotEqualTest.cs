using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class CountNotEqualTest
    {
        private readonly string[] ArrayWith2Elems = {"1", "2"};

        [Benchmark]
        public void Native()
        {
            if (ArrayWith2Elems.Length == 3)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems)).CountNotEqual(3);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems))
                .CountNotEqual(3)
                .CountNotEqual(3)
                .CountNotEqual(3);
        }
    }
}