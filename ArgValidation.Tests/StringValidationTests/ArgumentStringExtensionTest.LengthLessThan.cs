using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthLessThan_ArgumentIsNull_ArgValidationException()
        {
            var length = 2;
            string nullString = null;
            var exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullString).LengthLessThan(length));
            Assert.Equal(
                $"Argument '{nameof(nullString)}' is null. Can not execute 'LengthLessThan' method",
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

        [Fact]
        public void LengthLessThan_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.LengthLessThan(value.Length - 1);
        }

        [Fact]
        public void LengthLessThan_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .LengthLessThan(1));

            Assert.Equal($"Argument '{nameof(value)}' must be length less than 1. Current length: {value.Length}", exc.Message);
        }
    }
}