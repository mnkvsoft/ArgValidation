using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NullOrWhitespaceTest
    {
        private readonly string WhitespaceString = "   ";

        [Benchmark]
        public void Native()
        {
            if (!string.IsNullOrWhiteSpace(WhitespaceString))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(WhitespaceString, nameof(WhitespaceString)).NullOrWhitespace();
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(WhitespaceString, nameof(WhitespaceString))
                .NullOrWhitespace()
                .NullOrWhitespace()
                .NullOrWhitespace();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NullOrWhitespace(WhitespaceString, nameof(WhitespaceString));
        }
    }
}