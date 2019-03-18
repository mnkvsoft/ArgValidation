using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enum
{
    [CoreJob]
    [MemoryDiagnoser]
    public class HasFlagTest
    {
        private static readonly TestEnum Value1AndValue2 = TestEnum.Value1 | TestEnum.Value2;

        [Benchmark]
        public void Native()
        {
            if (!Value1AndValue2.HasFlag(TestEnum.Value1))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(Value1AndValue2, nameof(Value1AndValue2)).HasFlag(TestEnum.Value1);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(Value1AndValue2, nameof(Value1AndValue2))
                .HasFlag(TestEnum.Value1)
                .HasFlag(TestEnum.Value1)
                .HasFlag(TestEnum.Value1);
        }
    }
}