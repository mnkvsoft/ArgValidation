using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotNullOrEmptyTest
    {
        private readonly string[] NotEmptyArray = {"1"};

        [Benchmark]
        public void Native()
        {
            if (NotEmptyArray == null || NotEmptyArray.Length < 1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(NotEmptyArray, nameof(NotEmptyArray)).NotNullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NotNullOrEmpty(NotEmptyArray, nameof(NotEmptyArray));
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(NotEmptyArray, nameof(NotEmptyArray))
                .NotNullOrEmpty()
                .NotNullOrEmpty()
                .NotNullOrEmpty();
        }
    }
}