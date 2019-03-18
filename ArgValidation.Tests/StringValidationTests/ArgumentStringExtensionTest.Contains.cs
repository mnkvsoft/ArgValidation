using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void Contains_ArgumentIsNull_ArgValidationException()
        {
            string nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => nullValue).Contains("");
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'Contains' method", exc.Message);            
        }

        [Fact]
        public void Contains_ValueIsNull_ArgValidationException()
        {
            string arg = "value";
            string nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => arg).Contains(nullValue);
            });
            Assert.Equal($"Argument 'value' of method 'Contains' is null. Can not execute 'Contains' method", exc.Message);
        }

        [Fact]
        public void Contains_ValueIsEmptyAndArgumentIsEmpty_Ok()
        {
            string emptyValue = string.Empty;
            Arg.Validate(() => emptyValue).Contains(emptyValue);
        }

        [Fact]
        public void Contains_ArgumentNotContainsValue_ArgumentException()
        {
            string arg = "qwe";
            string value = "123";
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => arg).Contains(value);
            });
            Assert.Equal($"Argument '{nameof(arg)}' must contains '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void Contains_ArgumentContainsValue_Ok()
        {
            string arg = "string";
            string substring = arg.Substring(3);
            Arg.Validate(() => arg).Contains(substring);
        }

        [Fact]
        public void Contains_ArgumentContainsValueWithIgnoreCase_Ok()
        {
            string arg = "string";
            string substring = "STR";
            Arg.Validate(() => arg).Contains(substring, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void Contains_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.Contains("asfd");
        }

        [Fact]
        public void Contains_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Contains("4"));

            Assert.Equal($"Argument '{nameof(value)}' must contains '4'. Current value: '{value}'", exc.Message);
        }
    }
}
