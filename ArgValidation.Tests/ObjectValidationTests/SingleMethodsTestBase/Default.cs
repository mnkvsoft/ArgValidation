using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests.SingleMethodsTestBase
{
    public abstract partial class ObjectSingleMethodsTestBase
    {
        protected abstract void RunDefault<T>(Expression<Func<T>> value);
        
        [Fact]
        public void Default_ReferenceTypeIsNull_Ok()
        {
            object arg = null;
            RunDefault(() => arg);
        }

        [Fact]
        public void Default_ReferenceTypeIsNotNull_ArgumentException()
        {
            object arg = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                RunDefault(() => arg);
            });
            Assert.Equal($"Argument '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void Default_ValueTypeIsDefault_Ok()
        {
            RunDefault(() => default(int));
        }

        [Fact]
        public void Default_ValueTypeIsNotDefault_ArgumentException()
        {
            int arg = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunDefault(() => arg));
            Assert.Equal($"Argument '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }
    }
}
