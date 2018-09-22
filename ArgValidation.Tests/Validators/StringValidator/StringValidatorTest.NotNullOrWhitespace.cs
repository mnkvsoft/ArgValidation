using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NotNullOrWhitespace_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => emptyString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(emptyString)}' cannot be empty or whitespace. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_WhiteSpace_ArgumentException()
        {
            string whitespaceString = "   ";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => whitespaceString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(whitespaceString)}' cannot be empty or whitespace. Current value: '   '", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).NotNullOrWhitespace());
            Assert.Equal($"String with name '{nameof(nullString)}' cannot be empty or whitespace. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrWhitespace_HasValue_Ok()
        {
            string strWithValue = "with-value";
            CreateStringValidator(() => strWithValue).NotNullOrWhitespace();
        }
    }
}
