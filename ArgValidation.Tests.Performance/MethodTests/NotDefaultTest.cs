using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotDefaultTest
    {
        #region Object

        private static readonly object Obj = new Object();

        [Benchmark]
        public void NotDefault_Object_Native()
        {
            var value = Obj;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotDefault_Object()
        {
            var value = Obj;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void NotDefault_Object_Short()
        {
            var value = Obj;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void NotDefault_Object_Multiple()
        {
            var value = Obj;
            Arg.Validate(value, nameof(value))
                .NotDefault()
                .NotDefault()
                .NotDefault();
        }

        #endregion

        #region Byte

        [Benchmark]
        public void NotDefault_Byte_Native()
        {
            Byte value = 1;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotDefault_Byte()
        {
            Byte value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void NotDefault_Byte_Short()
        {
            Byte value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void NotDefault_Byte_Multiple()
        {
            Byte value = 1;
            Arg.Validate(value, nameof(value))
                .NotDefault()
                .NotDefault()
                .NotDefault();
        }

        #endregion

        #region Int32

        [Benchmark]
        public void NotDefault_Int32_Native()
        {
            Int32 value = 1;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotDefault_Int32()
        {
            Int32 value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void NotDefault_Int32_Short()
        {
            Int32 value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void NotDefault_Int32_Multiple()
        {
            Int32 value = 1;
            Arg.Validate(value, nameof(value))
                .NotDefault()
                .NotDefault()
                .NotDefault();
        }

        #endregion

        #region Int64

        [Benchmark]
        public void NotDefault_Int64_Native()
        {
            Int64 value = 1;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotDefault_Int64()
        {
            Int64 value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void NotDefault_Int64_Short()
        {
            Int64 value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void NotDefault_Int64_Multiple()
        {
            Int64 value = 1;
            Arg.Validate(value, nameof(value))
                .NotDefault()
                .NotDefault()
                .NotDefault();
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void NotDefault_Decimal_Native()
        {
            Decimal value = 1;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotDefault_Decimal()
        {
            Decimal value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void NotDefault_Decimal_Short()
        {
            Decimal value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void NotDefault_Decimal_Multiple()
        {
            Decimal value = 1;
            Arg.Validate(value, nameof(value))
                .NotDefault()
                .NotDefault()
                .NotDefault();
        }

        #endregion
    }
}