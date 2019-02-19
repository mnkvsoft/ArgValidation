using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    public class NotNullTest
    {
        private static readonly System.Object Obj = new System.Object();

        [Benchmark]
        public void Native_Object()
        {
            if (Obj == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Object()
        {
            Arg.Validate(Obj, nameof(Obj)).NotNull();
        }

        [Benchmark]
        public void ArgValidation_Object_Short()
        {
            Arg.NotNull(Obj, nameof(Obj));
        }

        [Benchmark]
        public void ArgValidation_Object_Multiple()
        {
            Arg.Validate(Obj, nameof(Obj))
                .NotNull()
                .NotNull()
                .NotNull();
        }
    }
}