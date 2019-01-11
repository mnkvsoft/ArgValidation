using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void EndsWith_ArgumentIsNull_ArgValidationException()
        {
            string nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => nullValue).EndsWith("");
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'EndsWith' method", exc.Message);            
        }

        [Fact]
        public void EndsWith_ValueIsNull_ArgValidationException()
        {
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
            {
                Arg.Validate(() => "value").EndsWith(null);
            });
            Assert.Equal("Argument 'value' of method 'EndsWith' is null. Can not execute 'EndsWith' method", exc.Message);
        }

        [Fact]
        public void EndsWith_ValueIsEmptyAndArgumentIsEmpty_Ok()
        {
            string emptyValue = string.Empty;
            Arg.Validate(() => emptyValue).EndsWith(emptyValue);
        }

        [Fact]
        public void EndsWith_ArgumentNotIndsWithValue_ArgumentException()
        {
            string arg = "qwe";
            string value = "123";
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => arg).EndsWith(value);
            });
            Assert.Equal($"Argument '{nameof(arg)}' must ends with '{value}'. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void EndsWith_ArgumentEndsWithValue_Ok()
        {
            string arg = "string";
            string value = "ing";
            Arg.Validate(() => arg).EndsWith(value);
        }

        [Fact]
        public void EndsWith_ArgumentEndsWithValueWithIgnoreCase_Ok()
        {
            string arg = "string";
            string value = "ING";
            Arg.Validate(() => arg).EndsWith(value, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void EndsWith_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.EndsWith("asfd");
        }
    }
}
