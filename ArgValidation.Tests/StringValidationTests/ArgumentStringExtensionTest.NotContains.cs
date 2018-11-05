using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotContainsString_ValueIsNullAndArgumentIsNull_ArgumentException()
        {
            string nullValue = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullValue).NotContainsString(nullValue));
            Assert.Equal($"Argument '{nameof(nullValue)}' must not contains null. Current value: null", exc.Message);
        }


        [Fact]
        public void NotContainsString_ValueIsEmptyAndArgumentIsEmpty_ArgumentException()
        {
            string emptyValue = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => emptyValue).NotContainsString(emptyValue));
            Assert.Equal($"Argument '{nameof(emptyValue)}' must not contains '{emptyValue}'. Current value: '{emptyValue}'", exc.Message);
        }

        [Fact]
        public void NotContainsString_ValueNotContainsArgument_Ok()
        {
            string value = "qwe";
            string arg = "123";
            Arg.Validate(() => value).NotContainsString(arg);
        }

        [Fact]
        public void NotContainsString_ValueContainsArgument_ArgumentException()
        {
            string value = "string";
            string substring = value.Substring(3);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => value).NotContainsString(substring));
            Assert.Equal($"Argument '{nameof(value)}' must not contains '{substring}'. Current value: '{value}'", exc.Message);
        }

        [Fact]
        public void NotContainsString_ValueIsNullButArgumentNotNull_Ok()
        {
            string nullValue = null;
            string arg = "123";
            Arg.Validate(() => nullValue).NotContainsString(arg);
        }

        [Fact]
        public void NotContainsString_ValueNotNullButArgumentIsNull_Ok()
        {
            string value = "value";
            string nullArg = null;
            Arg.Validate(() => value).NotContainsString(nullArg);
        }
    }
}
