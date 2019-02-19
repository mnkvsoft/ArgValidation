using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enum
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotHasFlagTest
    {
        private static readonly TestEnum Value1AndValue2 = TestEnum.Value1 | TestEnum.Value2;

        [Benchmark]
        public void Native()
        {
            if (Value1AndValue2.HasFlag(TestEnum.Value4))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(Value1AndValue2, nameof(Value1AndValue2)).NotHasFlag(TestEnum.Value4);
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(Value1AndValue2, nameof(Value1AndValue2))
                .NotHasFlag(TestEnum.Value4)
                .NotHasFlag(TestEnum.Value4)
                .NotHasFlag(TestEnum.Value4);
        }
    }
}