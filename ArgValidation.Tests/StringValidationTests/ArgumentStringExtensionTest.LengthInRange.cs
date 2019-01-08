using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthInRange_MinMoreThanMax_ArgValidationException()
        {
            var str = "str";
            var min5 = 5;
            var max3 = 3;

            var exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => str).LengthInRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more or equals 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueIsNull_ArgValidationException()
        {
            string nullString = null;
            var min3 = 3;
            var max5 = 5;

            var exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullString).LengthInRange(min3, max5));
            Assert.Equal(
                $"Argument '{nameof(nullString)}' is null. Can not execute 'LengthInRange' method",
                exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueLengthEqualsMax_Ok()
        {
            var strLength5 = "12345";
            var min3 = 3;
            var max5 = 5;

            Arg.Validate(() => strLength5).LengthInRange(min3, max5);
        }

        [Fact]
        public void LengthInRange_ValueLengthEqualsMin_Ok()
        {
            var strLength3 = "123";
            var min3 = 3;
            var max5 = 5;

            Arg.Validate(() => strLength3).LengthInRange(min3, max5);
        }

        [Fact]
        public void LengthInRange_ValueLengthLessMin_ArgumentException()
        {
            var strLength2 = "12";
            var min3 = 3;
            var max5 = 5;

            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => strLength2).LengthInRange(min3, max5));
            Assert.Equal(
                $"Argument '{nameof(strLength2)}' must be length in range {min3} - {max5}. Current length: {strLength2.Length}",
                exc.Message);
        }

        [Fact]
        public void LengthInRange_ValueLengthMoreMax_ArgumentException()
        {
            var strLength6 = "123456";
            var min3 = 3;
            var max5 = 5;

            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => strLength6).LengthInRange(min3, max5));
            Assert.Equal(
                $"Argument '{nameof(strLength6)}' must be length in range {min3} - {max5}. Current length: {strLength6.Length}",
                exc.Message);
        }

        [Fact]
        public void LengthInRange_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.LengthInRange(value.Length + 1, value.Length + 10);
        }
    }
}