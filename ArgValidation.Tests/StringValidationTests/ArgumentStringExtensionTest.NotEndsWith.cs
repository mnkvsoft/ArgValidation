using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotEndsWith_ArgumentIsNull_ArgValidationException()
        {
            string nullArg = null;
            var exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullArg).NotEndsWith(""));
            Assert.Equal($"Argument '{nameof(nullArg)}' is null. Can not execute 'NotEndsWith' method", exc.Message);
        }

        [Fact]
        public void NotEndsWith_ValueIsNull_ArgValidationException()
        {
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => "value").NotEndsWith(null);
            });
            Assert.Equal("Argument 'value' of method 'NotEndsWith' is null. Can not execute 'NotEndsWith' method", exc.Message);
        }

        [Fact]
        public void NotEndsWith_ArgumentNotEndsWithValue_Ok()
        {
            string arg = "qwe";
            string value = "123";
            Arg.Validate(() => arg).NotEndsWith(value);
        }

        [Fact]
        public void NotEndsWith_ArgumentEndsWithValue_ArgumentException()
        {
            string arg = "string";
            string value = "ing";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => arg).NotEndsWith(value));
            Assert.Equal($"Argument '{nameof(arg)}' must not ends with '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void NotEndsWith_ArgumentStartsWithValueWithIgnoreCase_ArgumentException()
        {
            string arg = "string";
            string value = "ING";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => arg).NotEndsWith(value, StringComparison.OrdinalIgnoreCase));
            Assert.Equal($"Argument '{nameof(arg)}' must not ends with '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void NotEndsWith_ValidationIsDisabled_WithoutException()
        {
            string value = "asdf";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NotEndsWith(value);
        }

        [Fact]
        public void NotEndsWith_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotEndsWith("23"));

            Assert.Equal($"Argument '{nameof(value)}' must not ends with '23'. Current value: '{value}'", exc.Message);
        }
    }
}
