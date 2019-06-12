using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotInTest
    {
        #region Object

        private static readonly object Obj1 = new System.Object();
        private static readonly object Obj2 = new System.Object();
        private static readonly object Obj3 = new System.Object();
        private static readonly object Obj4 = new System.Object();

        [Benchmark]
        public void Native_Object()
        {
            var arr = new[] { Obj2, Obj3, Obj4 };

            if (arr.Contains(Obj1))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Object()
        {
            var arr = new[] { Obj2, Obj3, Obj4 };
            Arg.Validate(Obj1, nameof(Obj1))
                .NotIn(arr);
        }

        [Benchmark]
        public void ArgValidation_Object_Multiple()
        {
            var arr = new[] { Obj2, Obj3, Obj4 };
            Arg.Validate(Obj1, nameof(Obj1))
                .NotIn(arr)
                .NotIn(arr)
                .NotIn(arr);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void Native_Byte()
        {
            Byte value = 1;
            var arr = new[] { 2, 3 };

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Byte()
        {
            Byte value = 1;
            var arr = new Byte[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void ArgValidation_Byte_Multiple()
        {
            Byte value = 1;
            var arr = new Byte[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr)
                .NotIn(arr)
                .NotIn(arr);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void Native_Int32()
        {
            Int32 value = 1;
            var arr = new Int32[] {  2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int32()
        {
            Int32 value = 1;
            var arr = new Int32[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void ArgValidation_Int32_Multiple()
        {
            Int32 value = 1;
            var arr = new Int32[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr)
                .NotIn(arr)
                .NotIn(arr);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void Native_Int64()
        {
            Int64 value = 1;
            var arr = new Int64[] { 2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Int64()
        {
            Int64 value = 1;
            var arr = new Int64[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void ArgValidation_Int64_Multiple()
        {
            Int64 value = 1;
            var arr = new Int64[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr)
                .NotIn(arr)
                .NotIn(arr);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void Native_Decimal()
        {
            Decimal value = 1;
            var arr = new Decimal[] { 2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_Decimal()
        {
            Decimal value = 1;
            var arr = new Decimal[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void ArgValidation_Decimal_Multiple()
        {
            Decimal value = 1;
            var arr = new Decimal[] { 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr)
                .NotIn(arr)
                .NotIn(arr);
        }

        #endregion
    }
}