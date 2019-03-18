using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void Default_ValidationIsDisabled_WithoutException()
        {
            int value = 1;
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.Default();
        }

        [Fact]
        public void Default_WithCustomException_CustomTypeException()
        {
            object notDefault = new object();

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(notDefault, nameof(notDefault)).With<CustomException>()
                        .Default());

            Assert.Equal($"Argument '{nameof(notDefault)}' must be default value. Current value: '{notDefault}'", exc.Message);
        }
    }
}
