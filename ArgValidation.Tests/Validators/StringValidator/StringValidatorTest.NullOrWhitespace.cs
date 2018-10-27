using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NullOrWhitespace_Empty_Ok()
        {
            string emptyString = string.Empty;
            Arg.Validate(() => emptyString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_WhiteSpace_Ok()
        {
            string whitespaceString = "   ";
            Arg.Validate(() => whitespaceString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_Null_Ok()
        {
            string nullString = null;
            Arg.Validate(() => nullString).NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_HasValue_ArgumentException()
        {
            string strWithValue = "with-value";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => strWithValue).NullOrWhitespace());
            Assert.Equal($"Argument '{nameof(strWithValue)}' must be empty or whitespace. Current value: '{strWithValue}'", exc.Message);
        }
    }
}
