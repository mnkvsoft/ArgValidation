using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {

        [Fact]
        public void NotNull_ValidationIsDisabled_WithoutException()
        {
            var arg = new Argument<object>(null, "name", validationIsDisabled: true);
            arg.NotNull();
        }

        [Fact]
        public void NotNull_WithCustomException_CustomTypeException()
        {
            object nullObj = null;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(nullObj, nameof(nullObj))
                    .With<CustomException>()
                       .NotNull());

            Assert.Equal($"Argument '{nameof(nullObj)}' is null", exc.Message);
        }
    }
}
