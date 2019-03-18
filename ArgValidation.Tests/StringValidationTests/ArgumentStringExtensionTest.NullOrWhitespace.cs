using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NullOrWhitespace_ValidationIsDisabled_WithoutException()
        {
            string value = "value";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NullOrWhitespace();
        }

        [Fact]
        public void NullOrWhitespace_WithCustomException_CustomTypeException()
        {
            string value = "value";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NullOrWhitespace());

            Assert.Equal($"Argument '{nameof(value)}' must be empty or whitespace. Current value: '{value}'", exc.Message);
        }
    }
}
