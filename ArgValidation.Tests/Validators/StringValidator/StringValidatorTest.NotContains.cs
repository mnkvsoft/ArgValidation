using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NotContains_ValueIsNullAndArgumentIsNull_ArgumentException()
        {
            string nullValue = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullValue).NotContains(nullValue));
            Assert.Equal($"Argument '{nameof(nullValue)}' must not contains null. Current value: null", exc.Message);
        }


        [Fact]
        public void NotContains_ValueIsEmptyAndArgumentIsEmpty_ArgumentException()
        {
            string emptyValue = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => emptyValue).NotContains(emptyValue));
            Assert.Equal($"Argument '{nameof(emptyValue)}' must not contains '{emptyValue}'. Current value: '{emptyValue}'", exc.Message);
        }

        [Fact]
        public void NotContains_ValueNotContainsArgument_Ok()
        {
            string value = "qwe";
            string arg = "123";
            CreateStringValidator(() => value).NotContains(arg);
        }

        [Fact]
        public void NotContains_ValueContainsArgument_ArgumentException()
        {
            string value = "string";
            string substring = value.Substring(3);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => value).NotContains(substring));
            Assert.Equal($"Argument '{nameof(value)}' must not contains '{substring}'. Current value: '{value}'", exc.Message);
        }

        [Fact]
        public void NotContains_ValueIsNullButArgumentNotNull_Ok()
        {
            string nullValue = null;
            string arg = "123";
            CreateStringValidator(() => nullValue).NotContains(arg);
        }

        [Fact]
        public void NotContains_ValueNotNullButArgumentIsNull_Ok()
        {
            string value = "value";
            string nullArg = null;
            CreateStringValidator(() => value).NotContains(nullArg);
        }
    }
}
