using System;
using System.Collections;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public abstract partial class EnumerableSimpleMethodsTestBase
    {
        protected abstract void RunEmpty<TEnumerable>(Expression<Func<TEnumerable>> value) where TEnumerable : IEnumerable;
    
        [Fact]
        public void Empty_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => RunEmpty(() => nullValue));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'Empty' method", exc.Message);
        }

        [Fact]
        public void Empty_ValueIsEmpty_Ok()
        {
            object[] objs = { };
            RunEmpty(() => objs);
        }

        [Fact]
        public void Empty_ValueNotEmpty_ArgumentException()
        {
            object[] objs = { new object() };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunEmpty(() => objs));
            Assert.Equal($"Argument '{nameof(objs)}' must be empty. Current value: ['System.Object']", exc.Message);
        }

        [Fact]
        public void Empty_ValueNotEmptyContainsNull_ArgumentException()
        {
            object[] containsNull = { null };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunEmpty(() => containsNull));
            Assert.Equal($"Argument '{nameof(containsNull)}' must be empty. Current value: [null]", exc.Message);
        }
    }
}