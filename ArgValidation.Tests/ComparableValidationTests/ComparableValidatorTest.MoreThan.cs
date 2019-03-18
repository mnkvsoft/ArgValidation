using System;
using Xunit;

namespace ArgValidation.Tests.ComparableValidationTests
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void MoreThan_2MoreThan1_Ok()
        {
            Arg.Validate(() => 2).MoreThan(1);
        }

        [Fact]
        public void MoreThan_0MoreThan1_ArgumentOutOfRangeException()
        {
            int argEqual0 = 0;
            int valueEqual1 = 1;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => argEqual0).MoreThan(valueEqual1));
            Assert.Equal($"Argument '{nameof(argEqual0)}' must be more than '{valueEqual1}'. Current value: '{argEqual0}'", exc.Message);
        }

        [Fact]
        public void MoreThan_1MoreThan1_ArgumentOutOfRangeException()
        {
            int value1 = 1;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value1).MoreThan(value1));
            Assert.Equal($"Argument '{nameof(value1)}' must be more than '{value1}'. Current value: '{value1}'", exc.Message);
        }

        [Fact]
        public void MoreThan_ArgumentIsNull_ArgValidationException()
        {
            ComparableClass nullValue = null;
            ComparableClass moreThanValue = new ComparableClass();
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => nullValue).MoreThan(moreThanValue);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_MoreThanArgumentIsNull_ArgValidationException()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass moreThanNull = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => value).MoreThan(moreThanNull);
            });
            Assert.Equal($"Argument 'value' of method 'MoreThan' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_ValidationIsDisabled_WithoutException()
        {
            int moreThanValue = 1;
            var arg = new Argument<int>(moreThanValue, "name", validationIsDisabled: true);
            arg.MoreThan(moreThanValue);
        }

        [Fact]
        public void MoreThan_WithCustomException_CustomTypeException()
        {
            int value3 = 3;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value3, nameof(value3))
                    .With<CustomException>()
                    .MoreThan(4));

            Assert.Equal($"Argument '{nameof(value3)}' must be more than '4'. Current value: '{value3}'",
                exc.Message);
        }
    }
}
