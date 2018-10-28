using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests.SingleMethodsTestBase
{
    public partial class StringSingleMethodsTestBase
    {
        protected abstract void RunNullOrEmpty(Expression<Func<string>> value);
        
        [Fact]
        public void NullOrEmpty_Empty_Ok()
        {
            RunNullOrEmpty(() => string.Empty);
        }

        [Fact]
        public void NullOrEmpty_Null_Ok()
        {
            string nullStr = null;
            RunNullOrEmpty(() => nullStr);
        }

        [Fact]
        public void NullOrEmpty_NotEmpty_ArgumentException()
        {
            string notEmptyString = "not-empty";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNullOrEmpty(() => notEmptyString));
            Assert.Equal($"Argument '{nameof(notEmptyString)}' must be empty or null. Current value: '{notEmptyString}'", exc.Message);
        }
    }
}
