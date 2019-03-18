using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotNullOrEmpty_ValidationIsDisabled_WithoutException()
        {
            string value = "";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.NotNullOrEmpty();
        }

        [Fact]
        public void NotNullOrEmpty_WithCustomException_CustomTypeException()
        {
            string value = "";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotNullOrEmpty());

            Assert.Equal($"Argument '{nameof(value)}' cannot be empty or null. Current value: ''", exc.Message);
        }
    }
}
