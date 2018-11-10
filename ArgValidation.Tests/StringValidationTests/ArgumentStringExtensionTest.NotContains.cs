using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotContainsString_ArgumentIsNull_ArgumentException()
        {
            string nullValue = null;
            var exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullValue).NotContains(""));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not execute 'NotContains' operation", exc.Message);
        }

        [Fact]
        public void NotContainsString_ValueNotContainsArgument_Ok()
        {
            string value = "qwe";
            string arg = "123";
            Arg.Validate(() => value).NotContains(arg);
        }

        [Fact]
        public void NotContainsString_ValueContainsArgument_ArgumentException()
        {
            string value = "string";
            string substring = value.Substring(3);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => value).NotContains(substring));
            Assert.Equal($"Argument '{nameof(value)}' must not contains '{substring}'. Current value: '{value}'", exc.Message);
        }
    }
}
