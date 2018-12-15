using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public abstract partial class ObjectSimpleMethodsTestBase
    {
        protected abstract void RunNotNull<T>(Expression<Func<T>> value) where T : class;
        
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
    }
}
