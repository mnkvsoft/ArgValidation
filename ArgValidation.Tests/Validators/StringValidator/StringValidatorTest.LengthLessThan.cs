using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthLessThan_ArgumentIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).LengthLessThan(length));
            Assert.Equal($"Argument '{nameof(nullString)}' must be length less than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthLessThan_More_ArgumentException()
        {
            string str = "str";
            int length = str.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthLessThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthLessThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Less_Ok()
        {
            string str = "str";
            int length = str.Length + 1;
            Arg.Validate(() => str).LengthLessThan(length);
        }
    }
}
