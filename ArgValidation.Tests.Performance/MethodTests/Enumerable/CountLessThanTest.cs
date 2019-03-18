using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class CountMoreThanTest
    {
        private readonly string[] ArrayWith2Elems = {"1", "2"};

        [Benchmark]
        public void Native()
        {
            if (ArrayWith2Elems.Length < 2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems)).CountMoreThan(1);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(ArrayWith2Elems, nameof(ArrayWith2Elems))
                .CountMoreThan(1)
                .CountMoreThan(1)
                .CountMoreThan(1);
        }
    }
}