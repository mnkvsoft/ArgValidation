using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotStartsWithTest
    {
        private readonly string OnlyDigitsString = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (OnlyDigitsString.StartsWith("as"))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString)).NotStartsWith("as");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString))
                .NotStartsWith("as")
                .NotStartsWith("as")
                .NotStartsWith("as");
        }
    }
}