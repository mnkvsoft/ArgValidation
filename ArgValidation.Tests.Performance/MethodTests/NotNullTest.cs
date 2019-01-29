using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    public class NotNullTest
    {
        private static readonly Object Obj = new Object();

        [Benchmark]
        public void NotNull_Object_Native()
        {
            if (Obj == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotNull_Object()
        {
            Arg.Validate(Obj, nameof(Obj)).NotNull();
        }

        [Benchmark]
        public void NotNull_Object_Short()
        {
            Arg.NotNull(Obj, nameof(Obj));
        }

        [Benchmark]
        public void NotNull_Object_Multiple()
        {
            Arg.Validate(Obj, nameof(Obj))
                .NotNull()
                .NotNull()
                .NotNull();
        }
    }
}