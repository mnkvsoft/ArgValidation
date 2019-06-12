using System;
using System.Collections;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public abstract partial class EnumerableSimpleMethodsTestBase
    {
        protected abstract void RunNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value) where TEnumerable : IEnumerable;
    
        [Fact]
        public void NullOrEmpty_ValueIsNull_Ok()
        {
            object[] nullValue = null;
            RunNullOrEmpty(() => nullValue);
        }

        [Fact]
        public void NullOrEmpty_ValueIsEmpty_Ok()
        {
            object[] objs = { };
            RunNullOrEmpty(() => objs);
        }

        [Fact]
        public void NullOrEmpty_ValueNotEmpty_ArgumentException()
        {
            object[] objs = { new object() };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNullOrEmpty(() => objs));
            Assert.Equal($"Argument '{nameof(objs)}' must be null or empty. Current value: ['System.Object']", exc.Message);
        }

        [Fact]
        public void NullOrEmpty_ValueNotNullOrEmptyContainsNull_ArgumentException()
        {
            object[] containsNull = { null };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNullOrEmpty(() => containsNull));
            Assert.Equal($"Argument '{nameof(containsNull)}' must be null or empty. Current value: [null]", exc.Message);
        }
    }
}