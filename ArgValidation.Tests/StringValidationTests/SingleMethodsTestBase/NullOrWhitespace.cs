using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests.SingleMethodsTestBase
{
    public partial class StringSingleMethodsTestBase
    {
        protected abstract void RunNullOrWhitespace(Expression<Func<string>> value);
        
        [Fact]
        public void NullOrWhitespace_Empty_Ok()
        {
            string emptyString = string.Empty;
            RunNullOrWhitespace(() => emptyString);
        }

        [Fact]
        public void NullOrWhitespace_WhiteSpace_Ok()
        {
            string whitespaceString = "   ";
            RunNullOrWhitespace(() => whitespaceString);
        }

        [Fact]
        public void NullOrWhitespace_Null_Ok()
        {
            string nullString = null;
            RunNullOrWhitespace(() => nullString);
        }

        [Fact]
        public void NullOrWhitespace_HasValue_ArgumentException()
        {
            string strWithValue = "with-value";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunNullOrWhitespace(() => strWithValue));
            Assert.Equal($"Argument '{nameof(strWithValue)}' must be empty or whitespace. Current value: '{strWithValue}'", exc.Message);
        }
    }
}
