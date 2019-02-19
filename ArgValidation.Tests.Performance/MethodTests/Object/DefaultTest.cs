using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    [CoreJob]
    [MemoryDiagnoser]
    public class DefaultTest
    {
        #region Object

        private static readonly object DefaultObject = default(System.Object);

        [Benchmark]
        public void Native_Object()
        {
            if (DefaultObject != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Object()
        {
            Arg.Validate(DefaultObject, nameof(DefaultObject)).Default();
        }

        [Benchmark]
        public void ArgValidation_Object_Short()
        {
            Arg.Default(DefaultObject, nameof(DefaultObject));
        }

        [Benchmark]
        public void ArgValidation_Object_Multiple()
        {
            Arg.Validate(DefaultObject, nameof(DefaultObject))
                .Default()
                .Default()
                .Default();
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            var value = default(Byte);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            var value = default(Byte);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void ArgValidation_Byte_Short()
        {
            var value = default(Byte);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            var value = default(Byte);
            Arg.Validate(value, nameof(value))
                .Default()
                .Default()
                .Default();
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            var value = default(Int32);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            var value = default(Int32);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void ArgValidation_Int32_Short()
        {
            var value = default(Int32);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            var value = default(Int32);
            Arg.Validate(value, nameof(value))
                .Default()
                .Default()
                .Default();
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            var value = default(Int64);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            var value = default(Int64);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void ArgValidation_Int64_Short()
        {
            var value = default(Int64);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            var value = default(Int64);
            Arg.Validate(value, nameof(value))
                .Default()
                .Default()
                .Default();
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            var value = default(Decimal);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Decimal()
        {
            var value = default(Decimal);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void ArgValidation_Decimal_Short()
        {
            var value = default(Decimal);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            var value = default(Decimal);
            Arg.Validate(value, nameof(value))
                .Default()
                .Default()
                .Default();
        }

        #endregion
    }
}