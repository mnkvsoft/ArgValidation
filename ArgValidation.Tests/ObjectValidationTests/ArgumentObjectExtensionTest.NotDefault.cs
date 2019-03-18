using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void NotDefault_ValidationIsDisabled_WithoutException()
        {
            int value = default(int);
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.NotDefault();
        }

        [Fact]
        public void NotDefault_WithCustomException_CustomTypeException()
        {
            object defaultObj = null;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(defaultObj, nameof(@defaultObj)).With<CustomException>()
                    .NotDefault());

            Assert.Equal($"Argument '{nameof(defaultObj)}' must be not default value", exc.Message);
        }
    }
}
