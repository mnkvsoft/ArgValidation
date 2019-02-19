using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Enumerable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NullOrEmptyTest
    {
        private readonly string[] EmptyArray = { };

        [Benchmark]
        public void Native()
        {
            if (EmptyArray == null)
                return;

            if (EmptyArray.Length == 0)
                return;

            throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(EmptyArray, nameof(EmptyArray)).NullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Short()
        {
            Arg.NullOrEmpty(EmptyArray, nameof(EmptyArray));
        }

        [Benchmark]
        public void ArgValidation_Multiple()
        {
            Arg.Validate(EmptyArray, nameof(EmptyArray))
                .NullOrEmpty()
                .NullOrEmpty()
                .NullOrEmpty();
        }
    }
}