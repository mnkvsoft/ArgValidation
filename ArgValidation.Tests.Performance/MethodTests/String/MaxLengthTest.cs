using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.String
{
    [CoreJob]
    [MemoryDiagnoser]
    public class MinLengthTest
    {
        private readonly string StringWithLength10 = "1234567890";

        [Benchmark]
        public void Native()
        {
            if (StringWithLength10.Length < 1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10)).MinLength(1);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(StringWithLength10, nameof(StringWithLength10))
                .MinLength(1)
                .MinLength(1)
                .MinLength(1);
        }
    }
}