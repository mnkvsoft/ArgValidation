using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests.ArgumentStringExtensionTest
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void MinMoreThanMax_InvalidOperationException()
        {
            var str = "str";
            var min5 = 5;
            var max3 = 3;

            var exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => str).LengthInRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more than 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void ValueIsNull_ArgumentException()
        {
            string nullString = null;
            var min3 = 3;
            var max5 = 5;

            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullString).LengthInRange(min3, max5));
            Assert.Equal(
                $"Argument '{nameof(nullString)}' must be length in range {min3} - {max5}. Current length: unknown (string is null)",
                exc.Message);
        }

        [Fact]
        public void ValueLengthEqualsMax_Ok()
        {
            var strLength5 = "12345";
            var min3 = 3;
            var max5 = 5;

            Arg.Validate(() => strLength5).LengthInRange(min3, max5);
        }

        [Fact]
        public void ValueLengthEqualsMin_Ok()
        {
            var strLength3 = "123";
            var min3 = 3;
            var max5 = 5;

            Arg.Validate(() => strLength3).LengthInRange(min3, max5);
        }

        [Fact]
        public void ValueLengthLessMin_ArgumentException()
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
        public void ValueLengthMoreMax_ArgumentException()
        {
            var strLength6 = "123456";
            var min3 = 3;
            var max5 = 5;

            var exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => strLength6).LengthInRange(min3, max5));
            Assert.Equal(
                $"Argument '{nameof(strLength6)}' must be length in range {min3} - {max5}. Current length: {strLength6.Length}",
                exc.Message);
        }
    }
}