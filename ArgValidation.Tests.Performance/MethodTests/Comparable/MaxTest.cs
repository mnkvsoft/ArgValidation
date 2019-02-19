using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Comparable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class MaxTest
    {
        #region Object

        private static readonly ComparableClass ReferenceValue1 = 1;
        private static readonly ComparableClass ReferenceValue2 = 2;

        [Benchmark]
        public void Native_ReferenceType()
        {
            if (ReferenceValue1.CompareTo(ReferenceValue2) > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_ReferenceType()
        {
            Arg.Validate(ReferenceValue1, nameof(ReferenceValue1))
                .Max(ReferenceValue2);
        }

        [Benchmark]
        public void ArgValidation_ReferenceType_Multiple()
        {
            Arg.Validate(ReferenceValue1, nameof(ReferenceValue1))
                .Max(ReferenceValue2)
                .Max(ReferenceValue2)
                .Max(ReferenceValue2);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            if (value1 > value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2);
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            byte value1 = 1;
            byte value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2)
                .Max(value2)
                .Max(value2);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            if (value1 > value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2);
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2)
                .Max(value2)
                .Max(value2);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            if (value1 > value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2);
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2)
                .Max(value2)
                .Max(value2);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            if (value1 > value2)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2);
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Arg.Validate(value1, nameof(value1))
                .Max(value2)
                .Max(value2)
                .Max(value2);
        }

        #endregion
    }
}