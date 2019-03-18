using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class EmptyTest
    {
        private readonly string[] EmptyArray = {};

        [Benchmark]
        public void Native()
        {
            if (EmptyArray.Length > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(EmptyArray, nameof(EmptyArray)).Empty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.Empty(EmptyArray, nameof(EmptyArray));
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(EmptyArray, nameof(EmptyArray))
                .Empty()
                .Empty()
                .Empty();
        }
    }
}