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

        [Fact]
        public void Equal_WithCustomException_CustomTypeException()
        {
            object obj1 = new object();
            object obj2 = new object();

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(obj1, nameof(obj1))
                    .With<CustomException>()
                        .Equal(obj2));

            Assert.Equal($"Argument '{nameof(obj1)}' must be equal '{obj2}'. Current value: '{obj1}'", exc.Message);
        }
    }
}
