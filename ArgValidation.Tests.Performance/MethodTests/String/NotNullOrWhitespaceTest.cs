using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotNullOrWhitespaceTest
    {
        private readonly string NonSpaceString = "non-space string";

        [Benchmark]
        public void Native()
        {
            if (string.IsNullOrEmpty(NonSpaceString))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(NonSpaceString, nameof(NonSpaceString)).NotNullOrWhitespace();
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(NonSpaceString, nameof(NonSpaceString))
                .NotNullOrWhitespace()
                .NotNullOrWhitespace()
                .NotNullOrWhitespace();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NotNullOrWhitespace(NonSpaceString, nameof(NonSpaceString));
        }
    }
}