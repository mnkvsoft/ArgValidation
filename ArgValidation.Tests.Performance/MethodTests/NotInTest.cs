using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NotInTest
    {
        #region Object

        private static readonly object Obj1 = new Object();
        private static readonly object Obj2 = new Object();
        private static readonly object Obj3 = new Object();
        private static readonly object Obj4 = new Object();

        [Benchmark]
        public void NotIn_Object_Native()
        {
            var arr = new[] { Obj2, Obj3, Obj4 };

            if (arr.Contains(Obj1))
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotIn_Object()
        {
            var arr = new[] { Obj2, Obj3, Obj4 };
            Arg.Validate(Obj1, nameof(Obj1))
                .NotIn(arr);
        }

        [Benchmark]
        public void NotIn_Object_Multiple()
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
        public void NotIn_Byte_Native()
        {
            Byte value = 1;
            var arr = new[] { value, 2, 3 };

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotIn_Byte()
        {
            Byte value = 1;
            var arr = new Byte[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void NotIn_Byte_Multiple()
        {
            Byte value = 1;
            var arr = new Byte[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .NotIn(arr);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void NotIn_Int32_Native()
        {
            Int32 value = 1;
            var arr = new[] { value, 2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotIn_Int32()
        {
            Int32 value = 1;
            var arr = new [] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void NotIn_Int32_Multiple()
        {
            Int32 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .NotIn(arr);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void NotIn_Int64_Native()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotIn_Int64()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void NotIn_Int64_Multiple()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .NotIn(arr);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void NotIn_Decimal_Native()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3};

            if (arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void NotIn_Decimal()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .NotIn(arr);
        }

        [Benchmark]
        public void NotIn_Decimal_Multiple()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .NotIn(arr);
        }

        #endregion
    }
}