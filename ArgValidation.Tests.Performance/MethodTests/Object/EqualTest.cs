using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    [CoreJob]
    [MemoryDiagnoser]
    public class EqualTest
    {
        #region Object

        private static readonly object Obj = new System.Object();

        [Benchmark]
        public void Native_Object()
        {
            var value1 = Obj;
            var value2 = value1;
            if(value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Object()
        {
            var value1 = Obj;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void ArgValidation_Object_Multiple()
        {
            var value1 = Obj;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            Byte value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            Byte value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            Byte value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value1 = 1;
            var value2 = value1;
            if (value1 != value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Decimal()
        {
            Decimal value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value1 = 1;
            var value2 = value1;

            Arg.Validate(value1, nameof(value1))
                .Equal(value2);
        }

        #endregion
    }
}