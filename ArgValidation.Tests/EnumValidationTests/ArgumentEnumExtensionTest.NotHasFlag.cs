using System;
using Xunit;

namespace ArgValidation.Tests.EnumValidationTests
{
    public partial class ArgumentEnumExtensionTest
    {
        [Fact]
        public void NotHasFlag_ArgumentNotHasFlag_Ok()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;
            Arg.Validate(value, nameof(value))
                .NotHasFlag(FlagsEnum.Value4);
        }

        [Fact]
        public void NotHasFlag_ArgumentNotHasMultipleFlags_Ok()
        {
            FlagsEnum value = FlagsEnum.Value2 | FlagsEnum.Value4;
            Arg.Validate(value, nameof(value))
                .NotHasFlag(FlagsEnum.Value1 | FlagsEnum.Value2);
        }

        [Fact]
        public void NotHasFlag_ArgumentHasFlag_ArgumentException()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;

            FlagsEnum flag = FlagsEnum.Value1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(value, nameof(value))
                    .NotHasFlag(flag));

            Assert.Equal($"Argument '{nameof(value)}' must not have the nexts flag(s): {flag}. Current value: {value}", exc.Message);
        }

        [Fact]
        public void NotHasFlag_ArgumentHasMultipleFlags_ArgumentException()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2 | FlagsEnum.Value4;

            FlagsEnum flag = FlagsEnum.Value1 | FlagsEnum.Value4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(value, nameof(value))
                    .NotHasFlag(flag));

            Assert.Equal($"Argument '{nameof(value)}' must not have the nexts flag(s): {flag}. Current value: {value}", exc.Message);
        }

        [Fact]
        public void NotHasFlag_ValidationIsDisabled_WithoutException()
        {
            FlagsEnum argValue = FlagsEnum.Value1 | FlagsEnum.Value2;
            var arg =new Argument<FlagsEnum>(argValue, nameof(argValue), validationIsDisabled: true);
            arg.NotHasFlag(FlagsEnum.Value1);
        }

        [Fact]
        public void NotHasFlag_WithCustomException_CustomTypeException()
        {
            FlagsEnum value = FlagsEnum.Value0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotHasFlag(value));

            Assert.Equal($"Argument '{nameof(value)}' must not have the nexts flag(s): {value}. Current value: {value}", exc.Message);
        }
    }
}