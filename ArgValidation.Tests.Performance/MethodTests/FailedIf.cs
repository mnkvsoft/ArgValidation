using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class FailedIfTest
    {
        private static readonly bool FalseBool = false;

        [Benchmark]
        public void Native()
        {
            if(FalseBool)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation()
        {
            Arg.Validate(FalseBool, nameof(FalseBool)).FailedIf(FalseBool, "error message");
        }
    }
}