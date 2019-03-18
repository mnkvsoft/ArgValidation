using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void StartsWith_ArgumentIsNull_ArgValidationException()
        {
            string nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => nullValue).StartsWith("");
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'StartsWith' method", exc.Message);            
        }

        [Fact]
        public void StartsWith_ValueIsNull_ArgValidationException()
        {
            string arg = "value";
            string nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => arg).StartsWith(nullValue);
            });
            Assert.Equal($"Argument 'value' of method 'StartsWith' is null. Can not execute 'StartsWith' method", exc.Message);
        }

        [Fact]
        public void StartsWith_ValueIsEmptyAndArgumentIsEmpty_Ok()
        {
            string emptyValue = string.Empty;
            Arg.Validate(() => emptyValue).StartsWith(emptyValue);
        }

        [Fact]
        public void StartsWith_ArgumentNotStartsWithValue_ArgumentException()
        {
            string arg = "qwe";
            string value = "123";
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => arg).StartsWith(value);
            });
            Assert.Equal($"Argument '{nameof(arg)}' must starts with '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void StartsWith_ArgumentStartsWithValue_Ok()
        {
            string arg = "string";
            string value = "str";
            Arg.Validate(() => arg).StartsWith(value);
        }

        [Fact]
        public void StartsWith_ArgumentStartsWithValueWithIgnoreCase_Ok()
        {
            string arg = "string";
            string value = "STR";
            Arg.Validate(() => arg).StartsWith(value, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void StartsWith_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.StartsWith("asfd");
        }

        [Fact]
        public void StartsWith_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .StartsWith("2"));

            Assert.Equal($"Argument '{nameof(value)}' must starts with '2'. Current value: '{value}'", exc.Message);
        }
    }
}
