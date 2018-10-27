using ArgValidation.Validators;
using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        
        [Fact]
        public void Contains_ValueIsNullAndArgumentIsNull_Ok()
        {
            string nullValue = null;
            Arg.Validate(() => nullValue).Contains(null);
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
        public void Contains_ValueIsNullButArgumentNotNull_ArgumentException()
        {
            string nullValue = null;
            string arg = "123";
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
            {
                Arg.Validate(() => nullValue).Contains(arg);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' must contains '{arg}'. Current value: null", exc.Message);
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
    }
}
