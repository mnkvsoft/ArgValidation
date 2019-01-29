using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class EqualTest
    {
        #region Object

        private static readonly object Obj = new Object();

        [Benchmark]
        public void Equal_Object_Native()
        {
            var value1 = Obj;
            var value2 = value1;
            if(value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Equal_Object()
        {
            var value1 = Obj;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void Equal_Object_Multiple()
        {
            var value1 = Obj;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Equal_Byte_Native()
        {
            Byte value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Equal_Byte()
        {
            Byte value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void Equal_Byte_Multiple()
        {
            Byte value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Equal_Int32_Native()
        {
            Int32 value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Equal_Int32()
        {
            Int32 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void Equal_Int32_Multiple()
        {
            Int32 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Equal_Int64_Native()
        {
            Int64 value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Equal_Int64()
        {
            Int64 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void Equal_Int64_Multiple()
        {
            Int64 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Equal_Decimal_Native()
        {
            Decimal value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void Equal_Decimal()
        {
            Decimal value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void Equal_Decimal_Multiple()
        {
            Decimal value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion
    }
}