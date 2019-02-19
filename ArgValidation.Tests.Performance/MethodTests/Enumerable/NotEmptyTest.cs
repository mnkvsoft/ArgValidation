using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotEmptyTest
    {
        private readonly string[] NotEmptyArray = {"1"};

        [Benchmark]
        public void Native()
        {
            if (NotEmptyArray.Length == 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(NotEmptyArray, nameof(NotEmptyArray)).NotEmpty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NotEmpty(NotEmptyArray, nameof(NotEmptyArray));
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(NotEmptyArray, nameof(NotEmptyArray))
                .NotEmpty()
                .NotEmpty()
                .NotEmpty();
        }
    }
}