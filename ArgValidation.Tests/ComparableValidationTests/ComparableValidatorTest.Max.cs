using System;
using Xunit;

namespace ArgValidation.Tests.ComparableValidationTests
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void Max_2Max3_Ok()
        {
            Arg.Validate(() => 2).Max(3);
        }

        [Fact]
        public void Max_3Max3_Ok()
        {
            Arg.Validate(() => 3).Max(3);
        }

        [Fact]
        public void Max_4Max3_ArgumentOutOfRangeException()
        {
            int value3 = 3;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value4).Max(value3));
            Assert.Equal($"The maximum value for the argument '{nameof(value4)}' is '{value3}'. Current value: '{value4}'", exc.Message);
        }

        
        [Fact]
        public void Max_ArgumentIsNull_ArgValidationException()
        {
            ComparableClass nullValue = null;
            ComparableClass maxValue = new ComparableClass();
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => nullValue).Max(maxValue);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void Max_MaxArgumentIsNull_ArgValidationException()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass maxNull = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => value).Max(maxNull);
            });
            Assert.Equal($"Argument 'value' of method 'Max' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void Max_ValidationIsDisabled_WithoutException()
        {
            int maxValue = 1;
            var arg = new Argument<int>(maxValue + 1, "name", validationIsDisabled: true);
            arg.Max(maxValue);
        }

        [Fact]
        public void Max_WithCustomException_CustomTypeException()
        {
            int value3 = 3;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value3, nameof(value3))
                    .With<CustomException>()
                    .Max(2));

            Assert.Equal($"The maximum value for the argument '{nameof(value3)}' is '2'. Current value: '{value3}'",
                exc.Message);
        }
    }
}
