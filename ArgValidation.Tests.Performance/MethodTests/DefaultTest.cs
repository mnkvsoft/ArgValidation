using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class DefaultTest
    {
        #region Object

        private static readonly object DefaultObject = default(Object);

        [Benchmark]
        public void Default_Object_Native()
        {
            if (DefaultObject != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Default_Object()
        {
            Arg.Validate(DefaultObject, nameof(DefaultObject)).Default();
        }

        [Benchmark]
        public void Default_Object_Short()
        {
            Arg.Default(DefaultObject, nameof(DefaultObject));
        }

        [Benchmark]
        public void Default_Object_Multiple()
        {
            Arg.Validate(DefaultObject, nameof(DefaultObject))
                .Default()
                .Default()
                .Default();
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Default_Byte_Native()
        {
            var value = default(Byte);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Default_Byte()
        {
            var value = default(Byte);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void Default_Byte_Short()
        {
            var value = default(Byte);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void Default_Byte_Multiple()
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
        public void Default_Int32_Native()
        {
            var value = default(Int32);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Default_Int32()
        {
            var value = default(Int32);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void Default_Int32_Short()
        {
            var value = default(Int32);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void Default_Int32_Multiple()
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
        public void Default_Int64_Native()
        {
            var value = default(Int64);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Default_Int64()
        {
            var value = default(Int64);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void Default_Int64_Short()
        {
            var value = default(Int64);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void Default_Int64_Multiple()
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
        public void Default_Decimal_Native()
        {
            var value = default(Decimal);
            if (value != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Default_Decimal()
        {
            var value = default(Decimal);
            Arg.Validate(value, nameof(value)).Default();
        }

        [Benchmark]
        public void Default_Decimal_Short()
        {
            var value = default(Decimal);
            Arg.Default(value, nameof(value));
        }

        [Benchmark]
        public void Default_Decimal_Multiple()
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