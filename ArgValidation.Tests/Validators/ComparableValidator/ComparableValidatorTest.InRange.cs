using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void InRange_EqualValuesNotImplementIComparable_Ok()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass min = value;
            ComparableClass max = value;
            Arg.Validate(() => value).InRange(min, max);
        }

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
        public void InRange_MinMoreThanMax_InvalidOperationException()
        {
            int value = 1;
            int min5 = 5;
            int max3 = 3;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => value).InRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more than 'max'. Cannot define range", exc.Message);
        }
    }
}
