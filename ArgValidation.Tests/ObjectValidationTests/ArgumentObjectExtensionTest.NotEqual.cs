using System;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void NotEqual_5NotEqual4_Ok()
        {
            Arg.Validate(() => 5).NotEqual(4);
        }

        [Fact]
        public void NotEqual_5Equal5_ArgumentException()
        {
            int val = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => val).NotEqual(val));
            Assert.Equal($"Argument '{nameof(val)}' must be not equal '{val}'", exc.Message);
        }

        [Fact]
        public void NotEqual_ValidationIsDisabled_WithoutException()
        {
            int value = 1;
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.NotEqual(value);
        }

        [Fact]
        public void NotEqual_WithCustomException_CustomTypeException()
        {
            object obj = new object();

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(obj, nameof(obj))
                    .With<CustomException>()
                    .NotEqual(obj));

            Assert.Equal($"Argument '{nameof(obj)}' must be not equal '{obj}'", exc.Message);
        }
    }
}
