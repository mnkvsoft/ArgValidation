using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class InTest
    {
        #region Object

        private static readonly object Obj1 = new Object();
        private static readonly object Obj2 = new Object();
        private static readonly object Obj3 = new Object();

        [Benchmark]
        public void In_Object_Native()
        {
            var arr = new[] { Obj1, Obj2, Obj3 };

            if (!arr.Contains(Obj1))
                throw new ArgumentException();
        }

        [Benchmark]
        public void In_Object()
        {
            var arr = new[] { Obj1, Obj2, Obj3 };
            Arg.Validate(Obj1, nameof(Obj1))
                .In(arr);
        }

        [Benchmark]
        public void In_Object_Multiple()
        {
            var arr = new[] { Obj1, Obj2, Obj3 };
            Arg.Validate(Obj1, nameof(Obj1))
                .In(arr)
                .In(arr)
                .In(arr);
        }

        #endregion

        #region Byte

        [Benchmark]
        public void In_Byte_Native()
        {
            Byte value = 1;
            var arr = new[] { value, 2, 3 };

            if (!arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void In_Byte()
        {
            Byte value = 1;
            var arr = new Byte[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr);
        }

        [Benchmark]
        public void In_Byte_Multiple()
        {
            Byte value = 1;
            var arr = new Byte[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .In(arr);
        }

        #endregion

        #region Int32

        [Benchmark]
        public void In_Int32_Native()
        {
            Int32 value = 1;
            var arr = new[] { value, 2, 3};

            if (!arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void In_Int32()
        {
            Int32 value = 1;
            var arr = new [] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr);
        }

        [Benchmark]
        public void In_Int32_Multiple()
        {
            Int32 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .In(arr);
        }

        #endregion

        #region Int64

        [Benchmark]
        public void In_Int64_Native()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3};

            if (!arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void In_Int64()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr);
        }

        [Benchmark]
        public void In_Int64_Multiple()
        {
            Int64 value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .In(arr);
        }

        #endregion

        #region Decimal

        [Benchmark]
        public void In_Decimal_Native()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3};

            if (!arr.Contains(value))
                throw new ArgumentException();
        }

        [Benchmark]
        public void In_Decimal()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr);
        }

        [Benchmark]
        public void In_Decimal_Multiple()
        {
            Decimal value = 1;
            var arr = new[] { value, 2, 3 };
            Arg.Validate(value, nameof(value))
                .In(arr)
                .In(arr)
                .In(arr);
        }

        #endregion
    }
}