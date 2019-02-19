using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class StartsWithTest
    {
        private readonly string OnlyDigitsString = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (!OnlyDigitsString.StartsWith("12"))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString)).StartsWith("12");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString))
                .StartsWith("12")
                .StartsWith("12")
                .StartsWith("12");
        }
    }
}