using System;
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
            CreateObjectValidator(() => value).InRange(min, max);
        }

        [Fact]
        public void InRange_ValidatingObjectEqualMin_Ok()
        {
            int value2 = 2;
            int min2 = 2;
            int max3 = 3;

            CreateObjectValidator(() => value2).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ValidatingObjectEqualMax_Ok()
        {
            int value3 = 3;
            int min2 = 2;
            int max3 = 3;

            CreateObjectValidator(() => value3).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ValueMiddleMinMax_Ok()
        {
            int value2 = 2;
            int min1 = 1;
            int max3 = 3;

            CreateObjectValidator(() => value2).InRange(min1, max3);
        }

        [Fact]
        public void InRange_ValidatingObjectMoreMax_ArgumentOutOfRangeException()
        {
            int value4 = 4;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value4).InRange(min1, max3));
            Assert.Equal($"Object with name '{nameof(value4)}' must be in range from '{min1}' to '{max3}'. Current value: '{value4}'", exc.Message);
        }

        [Fact]
        public void InRange_ValueLessMin_ArgumentOutOfRangeException()
        {
            int value0 = 0;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value0).InRange(min1, max3));
            Assert.Equal($"Object with name '{nameof(value0)}' must be in range from '{min1}' to '{max3}'. Current value: '{value0}'", exc.Message);
        }

        [Fact]
        public void InRange_MinMoreThanMax_InvalidOperationException()
        {
            int value = 1;
            int min5 = 5;
            int max3 = 3;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).InRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more than 'max'. Cannot define range", exc.Message);
        }
    }
}
