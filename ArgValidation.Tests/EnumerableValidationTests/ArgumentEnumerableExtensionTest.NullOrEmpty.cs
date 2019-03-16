using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NullOrEmpty_ValidationIsDisabled_WithoutException()
        {
            int[] notEmpty = { 1 };
            var arg = new Argument<int[]>(notEmpty, "name", validationIsDisabled: true);
            arg.NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1 };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .NullOrEmpty());

            Assert.Equal($"Argument '{nameof(arr)}' must be null or empty", exc.Message);
        }
    }
}
