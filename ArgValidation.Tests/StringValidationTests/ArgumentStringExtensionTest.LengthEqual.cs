using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void ArgumentIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(nullString)}' must be length {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void NotEqual_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 2;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthEqual(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void Equal_Ok()
        {
            string str = "str";
            Arg.Validate(() => str).LengthEqual(str.Length);
        }
    }
}
