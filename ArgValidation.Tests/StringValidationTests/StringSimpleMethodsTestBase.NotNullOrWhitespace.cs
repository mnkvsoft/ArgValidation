using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class StringSimpleMethodsTestBase
    {
        protected abstract void RunNotNullOrWhitespace(Expression<Func<string>> value);
        
        [Fact]
        public void NotNullOrWhitespace_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrWhitespace(() => emptyString));
            Assert.Equal($"Argument '{nameof(emptyString)}' cannot be empty or whitespace. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_WhiteSpace_ArgumentException()
        {
            string whitespaceString = "   ";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrWhitespace(() => whitespaceString));
            Assert.Equal($"Argument '{nameof(whitespaceString)}' cannot be empty or whitespace. Current value: '   '", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNotNullOrWhitespace(() => nullString));
            Assert.Equal($"Argument '{nameof(nullString)}' cannot be empty or whitespace. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_HasValue_Ok()
        {
            string strWithValue = "with-value";
            RunNotNullOrWhitespace(() => strWithValue);
        }
    }
}
