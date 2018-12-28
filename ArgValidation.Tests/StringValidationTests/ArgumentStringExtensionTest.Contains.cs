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
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not execute 'Contains' method", exc.Message);            
        }

        [Fact]
        public void Contains_ValueIsEmptyAndArgumentIsEmpty_Ok()
        {
            string emptyValue = string.Empty;
            Arg.Validate(() => emptyValue).Contains(emptyValue);
        }

        [Fact]
        public void Contains_ValueNotContainsArgument_ArgumentException()
        {
            string value = "qwe";
            string arg = "123";
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => value).Contains(arg);
            });
            Assert.Equal($"Argument '{nameof(value)}' must contains '{arg}'. Current value: '{value}'", exc.Message);
        }

        [Fact]
        public void Contains_ValueContainsArgument_Ok()
        {
            string value = "string";
            string substring = value.Substring(3);
            Arg.Validate(() => value).Contains(substring);
        }

        [Fact]
        public void Contains_ValueNotNullButArgumentIsNull_ArgumentException()
        {
            string value = "value";
            string nullArg = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => value).Contains(nullArg);
            });
            Assert.Equal($"Argument '{nameof(value)}' must contains null. Current value: '{value}'", exc.Message);
        }

        [Fact]
        public void Contains_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.Contains("asfd");
        }
    }
}
