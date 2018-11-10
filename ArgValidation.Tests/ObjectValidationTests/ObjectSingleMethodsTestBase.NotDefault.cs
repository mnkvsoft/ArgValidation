using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{   
    public abstract partial class ObjectSimpleMethodsTestBase
    {
        protected abstract void RunNotDefault<T>(Expression<Func<T>> value);
        
        [Fact]
        public void NotDefault_ReferenceTypeIsNotNull_Ok()
        {
            RunNotDefault(() => new object());
        }

        [Fact]
        public void NotDefault_ReferenceTypeIsNull_Exception()
        {
            object arg = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotDefault(() => arg));
            Assert.Equal($"Argument '{nameof(arg)}' must be not default value", exc.Message);
        }

        [Fact]
        public void NotDefault_ValueTypeIsNotDefault_Ok()
        {
            RunNotDefault(() => 5);
        }

        [Fact]
        public void NotDefault_ValueTypeIsDefault_ArgumentException()
        {
            int arg = default(int);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotDefault(() => arg));
            Assert.Equal($"Argument '{nameof(arg)}' must be not default value", exc.Message);
        }
    }
}
