using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NotNullOrWhitespace_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => emptyString).NotNullOrWhitespace());
            Assert.Equal($"Argument '{nameof(emptyString)}' cannot be empty or whitespace. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_WhiteSpace_ArgumentException()
        {
            string whitespaceString = "   ";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => whitespaceString).NotNullOrWhitespace());
            Assert.Equal($"Argument '{nameof(whitespaceString)}' cannot be empty or whitespace. Current value: '   '", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).NotNullOrWhitespace());
            Assert.Equal($"Argument '{nameof(nullString)}' cannot be empty or whitespace. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_HasValue_Ok()
        {
            string strWithValue = "with-value";
            Arg.Validate(() => strWithValue).NotNullOrWhitespace();
        }
    }
}
