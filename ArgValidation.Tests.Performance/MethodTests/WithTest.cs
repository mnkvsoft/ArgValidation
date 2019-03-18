using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class WithTest
    {
        [Benchmark]
        public void String()
        {
            string value = "value";
            Arg.Validate(value, nameof(value))
                .With<Exception>()
                .NotNull()
                .NotEmpty();
        }

        [Benchmark]
        public void Byte()
        {
            byte value = 1;
            Arg.Validate(value, nameof(value))
                .With<Exception>()
                .MoreThan((byte)0);
        }

        [Benchmark]
        public void Int32()
        {
            int value = 1;
            Arg.Validate(value, nameof(value))
                .With<Exception>()
                .MoreThan(0);
        }

        [Benchmark]
        public void Int64()
        {
            long value = 1;
            Arg.Validate(value, nameof(value))
                .With<Exception>()
                .MoreThan(0);
        }

        [Benchmark]
        public void Decimal()
        {
            decimal value = 1;
            Arg.Validate(value, nameof(value))
                .With<Exception>()
                .MoreThan(0);
        }
    }
}
