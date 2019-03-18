using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void MinCount_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullValue).MinCount(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void MinCount_CountEqual_Ok()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
           Arg.Validate(() => objsWithEqualCount).MinCount(count);
        }

        [Fact]
        public void MinCount_CountLess_ArgumentException()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objsWithLessCount).MinCount(count));
            Assert.Equal($"Argument '{nameof(objsWithLessCount)}' must contains a minimum of {count} elements. Current count elements: {objsWithLessCount.Length}", exc.Message);
        }

        [Fact]
        public void MinCount_CountMore_Ok()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            Arg.Validate(() => objsWithMoreCount).MinCount(count);
        }

        [Fact]
        public void MinCount_ValidationIsDisabled_WithoutException()
        {
            int[] digits = { 1, 2 };
            var arg = new Argument<int[]>(digits, "name", validationIsDisabled: true);

            arg.MinCount(digits.Length + 1);
        }

        [Fact]
        public void MinCount_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1 };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .MinCount(2));

            Assert.Equal($"Argument '{nameof(arr)}' must contains a minimum of 2 elements. Current count elements: {arr.Length}", exc.Message);
        }
    }
}
