using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ObjectSimpleMethodsTestBase
    {
        protected abstract void RunNull<T>(Expression<Func<T>> value);
        
        [Fact]
        public void Null_ObjectIsNotNull_ArgumentException()
        {
            object notNullObj = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNull(() => notNullObj));
            Assert.Equal($"Argument '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void Null_ObjectIsNull_Ok()
        {
            object nullObj = null;
            RunNull(() => nullObj);
        }

        [Fact]
        public void Null_NullableIsNotNull_ArgumentException()
        {
            int? notNullObj = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                RunNull(() => notNullObj)
                    ;
            });
            Assert.Equal($"Argument '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void Null_NullableIsNull_Ok()
        {
            int? nullObj = null;
            RunNull(() => nullObj);
        }
    }
}
