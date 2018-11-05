using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public abstract partial class ObjectSingleMethodsTestBase
    {
        protected abstract void RunNotNull<T>(Expression<Func<T>> value);
        
        [Fact]
        public void NotNull_ObjectIsNull_ArgumentNullException()
        {
            object nullObj = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => RunNotNull(() => nullObj));
            Assert.Equal(nameof(nullObj), exc.ParamName);
        }

        [Fact]
        public void NotNull_ObjectIsNotNull_Ok()
        {
            RunNotNull(() => new object());
        }

        [Fact]
        public void NotNull_NullableIsNull_ArgumentNullException()
        {
            int? nullArg = new int?();
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() =>
            {
                RunNotNull(() => nullArg)
                    ;
            });
            Assert.Equal(nameof(nullArg), exc.ParamName);
        }

        [Fact]
        public void NotNull_NullableIsNotNull_Ok()
        {
            RunNotNull(() => 5);
        }
    }
}
