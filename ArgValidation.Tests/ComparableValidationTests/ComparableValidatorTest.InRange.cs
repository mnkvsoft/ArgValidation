using System;
using Xunit;

namespace ArgValidation.Tests.ComparableValidationTests
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void InRange_ArgumentEqualMin_Ok()
        {
            int value2 = 2;
            int min2 = 2;
            int max3 = 3;

            Arg.Validate(() => value2).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ArgumentEqualMax_Ok()
        {
            int value3 = 3;
            int min2 = 2;
            int max3 = 3;

            Arg.Validate(() => value3).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ValueMiddleMinMax_Ok()
        {
            int value2 = 2;
            int min1 = 1;
            int max3 = 3;

            Arg.Validate(() => value2).InRange(min1, max3);
        }

        [Fact]
        public void InRange_ArgumentMoreMax_ArgumentOutOfRangeException()
        {
            int value4 = 4;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value4).InRange(min1, max3));
            Assert.Equal($"Argument '{nameof(value4)}' must be in range from '{min1}' to '{max3}'. Current value: '{value4}'", exc.Message);
        }

        [Fact]
        public void InRange_ValueLessMin_ArgumentOutOfRangeException()
        {
            int value0 = 0;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value0).InRange(min1, max3));
            Assert.Equal($"Argument '{nameof(value0)}' must be in range from '{min1}' to '{max3}'. Current value: '{value0}'", exc.Message);
        }

        [Fact]
        public void InRange_MinMoreThanMax_ArgValidationException()
        {
            int value = 1;
            int min5 = 5;
            int max3 = 3;

            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => value).InRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more or equals 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void InRange_MinEqualsMax_ArgValidationException()
        {
            int value = 2;
            int min = 1;
            int max = min;

            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => value).InRange(min, max));
            Assert.Equal("Argument 'min' cannot be more or equals 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void InRange_ValidationIsDisabled_WithoutException()
        {
            int min = 1;
            int max = 2;
            var arg = new Argument<int>(max + 1, "name", validationIsDisabled: true);
            arg.InRange(min, max);
        }
    }
}
