using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Comparable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class MinTest
    {
        #region Object

        private static readonly ComparableClass ReferenceValue1 = 1;
        private static readonly ComparableClass ReferenceValue2 = 2;

        [Benchmark]
        public void Native_ReferenceType()
        {

            if (ReferenceValue2.CompareTo(ReferenceValue1) < 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_ReferenceType()
        {
            Arg.Validate(ReferenceValue2, nameof(ReferenceValue2))
                .Min(ReferenceValue1);
        }

        [Benchmark]
        public void ArgValidation_ReferenceType_Multiple()
        {
            Arg.Validate(ReferenceValue2, nameof(ReferenceValue2))
                .Min(ReferenceValue1)
                .Min(ReferenceValue1)
                .Min(ReferenceValue1);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            if (value2 <= value1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1);
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            byte value1 = 1;
            byte value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1)
                .Min(value1)
                .Min(value1);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            if (value2 <= value1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1);
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1)
                .Min(value1)
                .Min(value1);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            if (value2 <= value1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1);
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1)
                .Min(value1)
                .Min(value1);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            if (value2 <= value1)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1);
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Arg.Validate(value2, nameof(value2))
                .Min(value1)
                .Min(value1)
                .Min(value1);
        }

        #endregion
    }
}