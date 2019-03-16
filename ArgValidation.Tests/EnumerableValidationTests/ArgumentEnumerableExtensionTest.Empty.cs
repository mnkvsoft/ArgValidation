using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void Empty_ValidationIsDisabled_WithoutException()
        {
            int[] notEmpty = { 1 };
            var arg = new Argument<int[]>(notEmpty, "name", validationIsDisabled: true);
            arg.Empty();
        }

        [Fact]
        public void Empty_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1 };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .Empty());

            Assert.Equal($"Argument '{nameof(arr)}' must be empty", exc.Message);
        }
    }
}
