using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public abstract partial class StringSingleMethodsTestBase
    {
        protected abstract void RunNotNullOrEmpty(Expression<Func<string>> value);
        
        [Fact]
        public void NotNullOrEmpty_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrEmpty(() => emptyString));
            Assert.Equal($"Argument '{nameof(emptyString)}' cannot be empty or null. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrEmpty(() => nullString));
            Assert.Equal($"Argument '{nameof(nullString)}' cannot be empty or null. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_NotEmpty_Ok()
        {
            string notEmpty = "not-empty";
            RunNotNullOrEmpty(() => notEmpty);
        }
    }
}
