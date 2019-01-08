using System;
using System.Collections;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public abstract partial class EnumerableSimpleMethodsTestBase
    {
        protected abstract void RunNotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
            where TEnumerable : IEnumerable;
    
        [Fact]
        public void NotEmpty_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => RunNotEmpty(() => nullValue));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'NotEmpty' method", exc.Message);
        }

        [Fact]
        public void NotEmpty_ValueIsNotEmpty_Ok()
        {
            object[] objs = { new object() };
            RunNotEmpty(() => objs);
        }

        [Fact]
        public void NotEmpty_ValueIsEmpty_ArgumentException()
        {
            object[] objs = { };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotEmpty(() => objs));
            Assert.Equal($"Argument '{nameof(objs)}' must be not empty", exc.Message);
        }

        [Fact]
        public void NotEmpty_ValueNotEmptyContainsNull_Ok()
        {
            object[] containsNull = { null };
            RunNotEmpty(() => containsNull);
        }
    }
}