using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthEqual_ArgumentIsNull_ArgValidationException()
        {
            int length = 2;
            string nullString = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullString).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(nullString)}' is null. Can not execute 'LengthEqual' method", exc.Message);
        }

        [Fact]
        public void LengthEqual_NotEqual_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 2;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthEqual_Equal_Ok()
        {
            string str = "str";
            Arg.Validate(() => str).LengthEqual(str.Length);
        }

        [Fact]
        public void LengthEqual_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.LengthEqual(value.Length + 1);
        }
    }
}
