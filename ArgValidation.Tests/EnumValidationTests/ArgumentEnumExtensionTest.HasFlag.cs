using System;
using Xunit;

namespace ArgValidation.Tests.EnumValidationTests
{
    public partial class ArgumentEnumExtensionTest
    {
        [Fact]
        public void HasFlag_ArgumentHasFlag_Ok()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;
            Arg.Validate(value, nameof(value))
                .HasFlag(FlagsEnum.Value1);
        }

        [Fact]
        public void HasFlag_ArgumentHasMultipleFlags_Ok()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2 | FlagsEnum.Value4;
            Arg.Validate(value, nameof(value))
                .HasFlag(FlagsEnum.Value1 | FlagsEnum.Value2);
        }

        [Fact]
        public void HasFlag_ArgumentNotHasFlag_ArgumentException()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;

            FlagsEnum flag = FlagsEnum.Value4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(value, nameof(value))
                .HasFlag(flag));

            Assert.Equal($"Argument '{nameof(value)}' must have the nexts flag(s): {flag}. Current value: {value}", exc.Message);
        }

        [Fact]
        public void HasFlag_ArgumentNotHasMultipleFlags_ArgumentException()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;

            FlagsEnum flag = FlagsEnum.Value1 | FlagsEnum.Value4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(value, nameof(value))
                    .HasFlag(flag));

            Assert.Equal($"Argument '{nameof(value)}' must have the nexts flag(s): {flag}. Current value: {value}", exc.Message);
        }

        [Fact]
        public void HasFlag_ValidationIsDisabled_WithoutException()
        {
            FlagsEnum argValue = FlagsEnum.Value1 | FlagsEnum.Value2;
            var arg =new Argument<FlagsEnum>(argValue, nameof(argValue), validationIsDisabled: true);
            arg.HasFlag(FlagsEnum.Value4);
        }

        [Fact]
        public void HasFlag_WithCustomException_CustomTypeException()
        {
            FlagsEnum value = FlagsEnum.Value0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .HasFlag(FlagsEnum.Value1));

            Assert.Equal($"Argument '{nameof(value)}' must have the nexts flag(s): {FlagsEnum.Value1}. Current value: {value}", exc.Message);
        }
    }
}