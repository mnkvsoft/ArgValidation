using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NullOrEmptyTest
    {
        private readonly string EmptyString = "";

        [Benchmark]
        public void Native()
        {
            if (!string.IsNullOrEmpty(EmptyString))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(EmptyString, nameof(EmptyString)).NullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(EmptyString, nameof(EmptyString))
                .NullOrEmpty()
                .NullOrEmpty()
                .NullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NullOrEmpty(EmptyString, nameof(EmptyString));
        }
    }
}