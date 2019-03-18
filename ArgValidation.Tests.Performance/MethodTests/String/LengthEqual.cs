using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class LengthEqualTest
    {
        private readonly string StringWithLength10 = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (StringWithLength10.Length != 10)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10)).LengthEqual(10);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10))
                .LengthEqual(10)
                .LengthEqual(10)
                .LengthEqual(10);
        }
    }
}