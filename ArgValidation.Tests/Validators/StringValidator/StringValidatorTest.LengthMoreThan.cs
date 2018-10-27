using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthMoreThan_ArgumentIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).LengthMoreThan(length));
            Assert.Equal($"Argument '{nameof(nullString)}' must be length more than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Equals_ArgumentException()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthMoreThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthMoreThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            Arg.Validate(() => str).LengthMoreThan(length);
        }
    }
}
