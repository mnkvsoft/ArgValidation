using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NotNullOrEmpty_ValidationIsDisabled_WithoutException()
        {
            int[] empty = { };
            var arg = new Argument<int[]>(empty, "name", validationIsDisabled: true);
            arg.NotNullOrEmpty();
        }

        [Fact]
        public void NotNullOrEmpty_NullWithCustomException_CustomTypeException()
        {
            int[] arr = null;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .NotNullOrEmpty());

            Assert.Equal($"Argument '{nameof(arr)}' must be null or empty. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_EmptyWithCustomException_CustomTypeException()
        {
            int[] arr = { };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .NotNullOrEmpty());

            Assert.Equal($"Argument '{nameof(arr)}' must be null or empty. Current value: empty", exc.Message);
        }
    }
}
