using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enum
{
    [CoreJob]
    [MemoryDiagnoser]
    public class DefinedInEnumTest
    {
        private static readonly TestEnum Value = TestEnum.Value1 | TestEnum.Value2;

        [Benchmark]
        public void Native()
        {
            // for flags is defined as follows
            if (decimal.TryParse(Value.ToString(), out _))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(Value, nameof(Value)).DefinedInEnum();
        }

        [Benchmark]
        public void ArgValidaton_Short()
        {
            Arg.DefinedInEnum(Value, nameof(Value));
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(Value, nameof(Value))
                .DefinedInEnum()
                .DefinedInEnum()
                .DefinedInEnum();
        }
    }
}