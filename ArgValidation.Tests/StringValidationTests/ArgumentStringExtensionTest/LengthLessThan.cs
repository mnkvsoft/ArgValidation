using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests.ArgumentStringExtensionTest
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthLessThan_ArgumentIsNull_ArgumentException()
        {
            var length = 2;
            string nullString = null;
            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).LengthLessThan(length));
            Assert.Equal(
                $"Argument '{nameof(nullString)}' must be length less than {length}. Current length: unknown (string is null)",
                exc.Message);
        }

        [Fact]
        public void LengthLessThan_Equals_Ok()
        {
            var str = "str";
            var length = str.Length;
            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthLessThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length less than {length}. Current length: {str.Length}",
                exc.Message);
        }

        [Fact]
        public void LengthLessThan_Less_Ok()
        {
            var str = "str";
            var length = str.Length + 1;
            Arg.Validate(() => str).LengthLessThan(length);
        }

        [Fact]
        public void LengthLessThan_More_ArgumentException()
        {
            var str = "str";
            var length = str.Length - 1;
            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthLessThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length less than {length}. Current length: {str.Length}",
                exc.Message);
        }
    }
}