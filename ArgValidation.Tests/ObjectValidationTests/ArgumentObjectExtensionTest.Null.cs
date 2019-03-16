using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void Null_ValidationIsDisabled_WithoutException()
        {
            object value = new object();
            var arg = new Argument<object>(value, "name", validationIsDisabled: true);
            arg.Null();
        }

        [Fact]
        public void Null_WithCustomException_CustomTypeException()
        {
            object notNull = new object();

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(notNull, nameof(notNull))
                    .With<CustomException>()
                    .Null());

            Assert.Equal($"Argument '{nameof(notNull)}' must be null. Current value: '{notNull}'", exc.Message);
        }
    }
}
