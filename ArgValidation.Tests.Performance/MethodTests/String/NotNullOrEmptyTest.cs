using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotNullOrEmptyTest
    {
        private readonly string NotEmptyString = "not empty string";

        [Benchmark]
        public void Native()
        {
            if (string.IsNullOrEmpty(NotEmptyString))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(NotEmptyString, nameof(NotEmptyString)).NotNullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(NotEmptyString, nameof(NotEmptyString))
                .NotNullOrEmpty()
                .NotNullOrEmpty()
                .NotNullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NotNullOrEmpty(NotEmptyString, nameof(NotEmptyString));
        }
    }
}