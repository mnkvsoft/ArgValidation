using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotDefaultTest
    {
        #region Object

        private static readonly object Obj = new System.Object();

        [Benchmark]
        public void Native_Object()
        {
            var value = Obj;
            if (value == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Object()
        {
            var value = Obj;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void ArgValidation_Object_Short()
        {
            var value = Obj;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Object_Multiple()
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
        public void Native_Byte()
        {
            Byte value = 1;
            if (value == 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            Byte value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void ArgValidation_Byte_Short()
        {
            Byte value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
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
        public void Native_Int32()
        {
            Int32 value = 1;
            if (value == 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void ArgValidation_Int32_Short()
        {
            Int32 value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
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
        public void Native_Int64()
        {
            Int64 value = 1;
            if (value == 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void ArgValidation_Int64_Short()
        {
            Int64 value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
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
        public void Native_Decimal()
        {
            Decimal value = 1;
            if (value == 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Decimal()
        {
            Decimal value = 1;
            Arg.Validate(value, nameof(value)).NotDefault();
        }

        [Benchmark]
        public void ArgValidation_Decimal_Short()
        {
            Decimal value = 1;
            Arg.NotDefault(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
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