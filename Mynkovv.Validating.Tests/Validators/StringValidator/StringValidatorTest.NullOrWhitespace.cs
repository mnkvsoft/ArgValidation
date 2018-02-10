using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NullOrWhitespace_Empty_Ok()
        {
            string emptyString = string.Empty;
            CreateStringValidator(() => emptyString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_WhiteSpace_Ok()
        {
            string whitespaceString = "   ";
            CreateStringValidator(() => whitespaceString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_Null_Ok()
        {
            string nullString = null;
            CreateStringValidator(() => nullString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_HasValue_ArgumentException()
        {
            string strWithValue = "with-value";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => strWithValue).NullOrWhitespace());
            Assert.Equal($"String with name '{nameof(strWithValue)}' must be empty or whitespace. Current value: '{strWithValue}'", exc.Message);
        }
    }
}
