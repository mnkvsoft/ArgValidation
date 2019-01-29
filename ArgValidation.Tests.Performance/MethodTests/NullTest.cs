using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NullTest
    {
        private static readonly Object NullObj = new Object();

        [Benchmark]
        public void Null_Object_Native()
        {
            if (NullObj != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Null_Object()
        {
            Arg.Validate(NullObj, nameof(NullObj)).Null();
        }

        [Benchmark]
        public void Null_Object_Short()
        {
            Arg.Null(NullObj, nameof(NullObj));
        }
    }
}