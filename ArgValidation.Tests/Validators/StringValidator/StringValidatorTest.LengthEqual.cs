using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthEqual_ArgumentIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(nullString)}' must be length {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthEqual_NotEqual_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 2;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthEqual_Equal_Ok()
        {
            string str = "str";
            CreateStringValidator(() => str).LengthEqual(str.Length);
        }
    }
}
