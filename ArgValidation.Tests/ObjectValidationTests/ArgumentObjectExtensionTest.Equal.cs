using System;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void Equal_5Equal5_Ok()
        {
            Arg.Validate(() => 5).Equal(5);
        }

        [Fact]
        public void Equal_5NotEqual4_ArgumentException()
        {
            int val = 5;
            int expectedVal = 4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => val).Equal(expectedVal));
            Assert.Equal($"Argument '{nameof(val)}' must be equal '{expectedVal}'. Current value: '{val}'", exc.Message);
        }

        [Fact]
        public void Equal_ValidationIsDisabled_WithoutException()
        {
            int value = 1;
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.Equal(value + 1);
        }
    }
}
