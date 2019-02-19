using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class ContainsTest
    {
        private readonly string OnlyDigitsString = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (!OnlyDigitsString.Contains("12"))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString)).Contains("12");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString))
                .Contains("12")
                .Contains("12")
                .Contains("12");
        }
    }
}