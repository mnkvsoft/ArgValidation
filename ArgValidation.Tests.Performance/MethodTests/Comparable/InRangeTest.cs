using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Comparable
{
    [CoreJob]
    [MemoryDiagnoser]
    public class InRangeTest
    {
        #region Object

        private static readonly ComparableClass ReferenceValue1 = 1;
        private static readonly ComparableClass ReferenceValue2 = 2;
        private static readonly ComparableClass ReferenceValue3 = 3;

        [Benchmark]
        public void Native_ReferenceType()
        {
            if (ReferenceValue2.CompareTo(ReferenceValue1) < 0 || ReferenceValue2.CompareTo(ReferenceValue3) > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_ReferenceType()
        {
            Arg.Validate(ReferenceValue2, nameof(ReferenceValue2))
                .InRange(ReferenceValue1, ReferenceValue3);
        }

        [Benchmark]
        public void ArgValidation_ReferenceType_Multiple()
        {
            Arg.Validate(ReferenceValue2, nameof(ReferenceValue2))
                .InRange(ReferenceValue1, ReferenceValue3)
                .InRange(ReferenceValue1, ReferenceValue3)
                .InRange(ReferenceValue1, ReferenceValue3);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            byte value3 = 3;
            if (!(value2 >= value1 && value2 <= value3))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            byte value1 = 1;
            byte value2 = 2;
            byte value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3);
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            byte value1 = 1;
            byte value2 = 2;
            byte value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3)
                .InRange(value1, value3)
                .InRange(value1, value3);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Int32 value3 = 3;
            if (!(value2 >= value1 && value2 <= value3))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Int32 value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3);
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value1 = 1;
            Int32 value2 = 2;
            Int32 value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3)
                .InRange(value1, value3)
                .InRange(value1, value3);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Int64 value3 = 3;
            if (!(value2 >= value1 && value2 <= value3))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Int64 value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3);
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value1 = 1;
            Int64 value2 = 2;
            Int64 value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3)
                .InRange(value1, value3)
                .InRange(value1, value3);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Decimal value3 = 3;
            if (!(value2 >= value1 && value2 <= value3))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Decimal value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3);
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value1 = 1;
            Decimal value2 = 2;
            Decimal value3 = 3;
            Arg.Validate(value2, nameof(value2))
                .InRange(value1, value3)
                .InRange(value1, value3)
                .InRange(value1, value3);
        }

        #endregion
    }
}