using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class EndsWithTest
    {
        private readonly string OnlyDigitsString = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (!OnlyDigitsString.EndsWith("90"))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString)).EndsWith("90");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(OnlyDigitsString, nameof(OnlyDigitsString))
                .EndsWith("90")
                .EndsWith("90")
                .EndsWith("90");
        }
    }
}