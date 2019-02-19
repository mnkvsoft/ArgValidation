using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class LengthMoreThanTest
    {
        private readonly string StringWithLength10 = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (StringWithLength10.Length <= 2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10)).LengthMoreThan(2);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10))
                .LengthMoreThan(2)
                .LengthMoreThan(2)
                .LengthMoreThan(2);
        }
    }
}