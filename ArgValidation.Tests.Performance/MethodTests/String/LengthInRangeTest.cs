using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class LengthInRangeTest
    {
        private readonly string StringWithLength10 = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (StringWithLength10.Length >= 1 && StringWithLength10.Length <= 11)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10)).LengthInRange(1, 11);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10))
                .LengthInRange(1, 11)
                .LengthInRange(1, 11)
                .LengthInRange(1, 11);
        }
    }
}