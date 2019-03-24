using System;
using System.Collections;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public abstract partial class EnumerableSimpleMethodsTestBase
    {
        protected abstract void RunNotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value) where TEnumerable : IEnumerable;
    
        [Fact]
        public void NotNullOrEmpty_ValueIsNull_ArgumentException()
        {
            object[] nullValue = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrEmpty(() => nullValue));
            Assert.Equal($"Argument '{nameof(nullValue)}' must be null or empty. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_ValueIsEmpty_ArgumentException()
        {
            object[] objs = { };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrEmpty(() => objs));
            Assert.Equal($"Argument '{nameof(objs)}' must be null or empty. Current value: empty", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_ValueNotEmpty_ArgumentException()
        {
            object[] objs = { new object() };
            RunNotNullOrEmpty(() => objs);
        }

        [Fact]
        public void NotNullOrEmpty_ValueNotNotNullOrEmptyContainsNull_ArgumentException()
        {
            object[] containsNull = { null };
            RunNotNullOrEmpty(() => containsNull);
        }
    }
}