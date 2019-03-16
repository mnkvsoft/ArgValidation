using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NotEmpty_ValidationIsDisabled_WithoutException()
        {
            int[] empty = { };
            var arg = new Argument<int[]>(empty, "name", validationIsDisabled: true);
            arg.NotEmpty();
        }

        [Fact]
        public void NotEmpty_WithCustomException_CustomTypeException()
        {
            int[] arr = { };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .NotEmpty());

            Assert.Equal($"Argument '{nameof(arr)}' must be not empty", exc.Message);
        }
    }
}
