using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthEqual_ArgumentIsNull_InvalidOperationException()
        {
            int length = 2;
            string nullString = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullString).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(nullString)}' is null. Сan not execute 'LengthEqual' operation", exc.Message);
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
    }
}
