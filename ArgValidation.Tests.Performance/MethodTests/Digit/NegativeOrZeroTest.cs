using System;
using BenchmarkDotNet.Attributes;


namespace ArgValidation.Tests.Performance.MethodTests.Digit
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NegativeOrZeroTest
    {
        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value = -1;
            if (value > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value = -1;
            Arg.Validate(value, nameof(value)).NegativeOrZero();
        }

        [Benchmark]
        public void ArgValidaton_Int32_Short()
        {
            Int32 value = -1;
            Arg.NegativeOrZero(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value = -1;
            Arg.Validate(value, nameof(value))
                .NegativeOrZero()
                .NegativeOrZero()
                .NegativeOrZero();
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value = -1;
            if (value > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value = -1;
            Arg.Validate(value, nameof(value)).NegativeOrZero();
        }

        [Benchmark]
        public void ArgValidaton_Int64_Short()
        {
            Int64 value = -1;
            Arg.NegativeOrZero(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value = -1;
            Arg.Validate(value, nameof(value))
                .NegativeOrZero()
                .NegativeOrZero()
                .NegativeOrZero();
        }

        #endregion

        #region 

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value = -1;
            if (value > 0)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Decimal()
        {
            Decimal value = -1;
            Arg.Validate(value, nameof(value)).NegativeOrZero();
        }

        [Benchmark]
        public void ArgValidaton_Decimal_Short()
        {
            Decimal value = -1;
            Arg.NegativeOrZero(value, nameof(value));
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value = -1;
            Arg.Validate(value, nameof(value))
                .NegativeOrZero()
                .NegativeOrZero()
                .NegativeOrZero();
        }

        #endregion
    }
}