using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Object
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NullTest
    {
        private static readonly System.Object NullObj = new System.Object();
        private static readonly int? NullNullable = null;

        #region Object

        [Benchmark]
        public void Native_Object()
        {
            if (NullObj != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidaton_Object()
        {
            Arg.Validate(NullObj, nameof(NullObj)).Null();
        }

        [Benchmark]
        public void ArgValidaton_Object_Short()
        {
            Arg.Null(NullObj, nameof(NullObj));
        }

        #endregion

        #region Nullable

        [Benchmark]
        public void Native_Nullable()
        {
            if (NullNullable != null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidaton_Nullable()
        {
            Arg.Validate(NullNullable, nameof(NullNullable)).Null();
        }

        [Benchmark]
        public void ArgValidaton_Nullable_Short()
        {
            Arg.Null(NullNullable, nameof(NullNullable));
        }

        #endregion
    }
}