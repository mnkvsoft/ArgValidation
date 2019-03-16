using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NullOrEmpty_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_WithCustomException_CustomTypeException()
        {
            string value = "value";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NullOrEmpty());

            Assert.Equal($"Argument '{nameof(value)}' must be empty or null. Current value: '{value}'", exc.Message);
        }
    }
}
