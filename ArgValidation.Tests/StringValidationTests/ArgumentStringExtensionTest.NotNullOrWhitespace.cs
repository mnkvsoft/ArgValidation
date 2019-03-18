using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotNullOrWhitespace_ValidationIsDisabled_WithoutException()
        {
            string value = "   ";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NotNullOrWhitespace();
        }

        [Fact]
        public void NotNullOrWhitespace_WithCustomException_CustomTypeException()
        {
            string value = "   ";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotNullOrWhitespace());

            Assert.Equal($"Argument '{nameof(value)}' cannot be empty or whitespace. Current value: '{value}'", exc.Message);
        }
    }
}
