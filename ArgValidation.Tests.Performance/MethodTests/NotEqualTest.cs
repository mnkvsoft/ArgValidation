using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotEqualTest
    {
        #region Object

        private static readonly Object Obj1 = new Object();
        private static readonly Object Obj2 = new Object();

        [Benchmark]
        public void NotEqual_Object_Native()
        {
            if(Obj1 == Obj2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotEqual_Object()
        {
            Arg.Validate(Obj1, nameof(Obj1))
                .NotEqual(Obj2);
        }

        [Benchmark]
        public void NotEqual_Object_Multiple()
        {
            Arg.Validate(Obj1, nameof(Obj1))
                .NotEqual(Obj2);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void NotEqual_Byte_Native()
        {
            Byte value1 = 1;
            Byte value2 = 2;
            if (value1 == value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotEqual_Byte()
        {
            Byte value1 = 1;
            Byte value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        [Benchmark]
        public void NotEqual_Byte_Multiple()
        {
            Byte value1 = 1;
            Byte value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        #endregion


        #region Int32

        [Benchmark]
        public void NotEqual_Int32_Native()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            if (value1 == value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotEqual_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        [Benchmark]
        public void NotEqual_Int32_Multiple()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void NotEqual_Int64_Native()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            if (value1 == value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotEqual_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        [Benchmark]
        public void NotEqual_Int64_Multiple()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void NotEqual_Decimal_Native()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            if (value1 == value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotEqual_Decimal()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        [Benchmark]
        public void NotEqual_Decimal_Multiple()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;

            Arg.Validate(value1, nameof(value1))
                .NotEqual(value2);
        }

        #endregion
    }
}