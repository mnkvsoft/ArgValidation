using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotContains_ArgumentIsNull_ArgValidationException()
        {
            string nullArg = null;
            var exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullArg).NotContains(""));
            Assert.Equal($"Argument '{nameof(nullArg)}' is null. Can not execute 'NotContains' method", exc.Message);
        }

        [Fact]
        public void NotContains_ArgumentNotContainsValue_Ok()
        {
            string arg = "qwe";
            string value = "123";
            Arg.Validate(() => arg).NotContains(value);
        }

        [Fact]
        public void NotContains_ArgumentContainsValue_ArgumentException()
        {
            string arg = "string";
            string value = arg.Substring(3);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => arg).NotContains(value));
            Assert.Equal($"Argument '{nameof(arg)}' must not contains '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void NotContains_ArgumentContainsValueWithIgnoreCase_ArgumentException()
        {
            string arg = "string";
            string value = "STR";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => arg).NotContains(value, StringComparison.OrdinalIgnoreCase));
            Assert.Equal($"Argument '{nameof(arg)}' must not contains '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void NotContains_ValidationIsDisabled_WithoutException()
        {
            string value = "asdf";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NotContains(value);
        }

        [Fact]
        public void NotContains_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotContains("1"));

            Assert.Equal($"Argument '{nameof(value)}' must not contains '1'. Current value: '{value}'", exc.Message);
        }
    }
}
