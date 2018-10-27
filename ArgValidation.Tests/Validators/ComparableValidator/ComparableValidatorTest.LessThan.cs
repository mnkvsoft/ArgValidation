using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void LessThan_3LessThan4_Ok()
        {
            Arg.Validate(() => 3).LessThan(4);
        }

        [Fact]
        public void LessThan_EqualValues_ArgumentOutOfRangeException()
        {
            int val = 5;
            int equalVal = val;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => val).LessThan(equalVal));
            Assert.Equal($"Argument '{nameof(val)}' must be less than '{equalVal}'. Current value: '{val}'", exc.Message);
        }

        [Fact]
        public void LessThan_5LessThan4_ArgumentOutOfRangeException()
        {
            int value5 = 5;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value5).LessThan(value4));
            Assert.Equal($"Argument '{nameof(value5)}' must be less than '{value4}'. Current value: '{value5}'", exc.Message);
        }

        [Fact]
        public void LessThan_ArgumentIsNull_InvalidOperationException()
        {
            ComparableClass nullValue = null;
            ComparableClass lessThanValue = new ComparableClass();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                Arg.Validate(() => nullValue).LessThan(lessThanValue);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void LessThan_LessThanArgumentIsNull_InvalidOperationException()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass lessThanNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                Arg.Validate(() => value).LessThan(lessThanNull);
            });
            Assert.Equal($"Argument 'lessThan' is null. Сan not compare null object", exc.Message);
        }
    }
}
