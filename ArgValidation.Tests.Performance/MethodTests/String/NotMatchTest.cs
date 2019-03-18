using System;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class MatchTest
    {
        private readonly string String12 = "12";

        [Benchmark]
        public void Native()
        {
            Regex regex=new Regex("\\d\\d");
            if (!regex.IsMatch(String12))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(String12, nameof(String12)).Match("\\d\\d");
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(String12, nameof(String12))
                .Match("\\d\\d")
                .Match("\\d\\d")
                .Match("\\d\\d");
        }
    }
}