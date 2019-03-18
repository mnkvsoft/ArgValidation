using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests.Condition
{
    [CoreJob]
    [MemoryDiagnoser]
    public class IfNotNullTest
    {
        private static readonly byte? NullableByte = 1;
        private static readonly int? NullableInt32 = 1;
        private static readonly long? NullableInt64 = 1;
        private static readonly decimal? NullableDecimal = 1;

        private static readonly object ReferenceObject = new object();

        #region NullableByte

        [Benchmark]
        public void Native_NullableByte()
        {
            if (!NullableByte.HasValue)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_NullableByte()
        {
            Arg.Validate(NullableByte, nameof(NullableByte)).IfNotNull();
        }

        [Benchmark]
        public void ArgValidation_NullableByte_Short()
        {
            Arg.IfNotNull(NullableByte, nameof(NullableByte));
        }

        #endregion

        #region NullableInt32

        [Benchmark]
        public void Native_NullableInt32()
        {
            if (!NullableInt32.HasValue)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_NullableInt32()
        {
            Arg.Validate(NullableInt32, nameof(NullableInt32)).IfNotNull();
        }

        [Benchmark]
        public void ArgValidation_NullableInt32_Short()
        {
            Arg.IfNotNull(NullableInt32, nameof(NullableInt32));
        }

        #endregion

        #region NullableInt64

        [Benchmark]
        public void Native_NullableInt64()
        {
            if (!NullableInt64.HasValue)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_NullableInt64()
        {
            Arg.Validate(NullableInt64, nameof(NullableInt64)).IfNotNull();
        }

        [Benchmark]
        public void ArgValidation_NullableInt64_Short()
        {
            Arg.IfNotNull(NullableInt64, nameof(NullableInt64));
        }

        #endregion

        #region NullableDecimal

        [Benchmark]
        public void Native_NullableDecimal()
        {
            if (!NullableDecimal.HasValue)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_NullableDecimal()
        {
            Arg.Validate(NullableDecimal, nameof(NullableDecimal)).IfNotNull();
        }

        [Benchmark]
        public void ArgValidation_NullableDecimal_Short()
        {
            Arg.IfNotNull(NullableDecimal, nameof(NullableDecimal));
        }

        #endregion

        #region ReferenceObject

        [Benchmark]
        public void Native_ReferenceObject()
        {
            if (ReferenceObject == null)
                throw new ArgumentException();
        }

        [Benchmark]
        public void ArgValidation_ReferenceObject()
        {
            Arg.Validate(ReferenceObject, nameof(ReferenceObject)).IfNotNull();
        }

        [Benchmark]
        public void ArgValidation_ReferenceObject_Short()
        {
            Arg.IfNotNull(ReferenceObject, nameof(ReferenceObject));
        }

        #endregion
    }
}