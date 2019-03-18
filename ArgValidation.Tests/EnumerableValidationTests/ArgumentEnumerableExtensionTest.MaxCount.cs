using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void MaxCount_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => 
                Arg.Validate(() => nullValue)
                    .MaxCount(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void MaxCount_CountEqual_Ok()
        {
            object[] objsWithEqualCount = { new object(), new object() };
            int count = objsWithEqualCount.Length;
            
           Arg.Validate(() => objsWithEqualCount)
               .MaxCount(count);
        }

        [Fact]
        public void MaxCount_CountLess_Ok()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            
            Arg.Validate(() => objsWithLessCount)
                .MaxCount(count);
        }

        [Fact]
        public void MaxCount_CountMore_ArgumentException()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => objsWithMoreCount)
                    .MaxCount(count));
            
            Assert.Equal($"Argument '{nameof(objsWithMoreCount)}' must contains a maximum of {count} elements. Current count elements: {objsWithMoreCount.Length}", exc.Message);
        }

        [Fact]
        public void MaxCount_ValidationIsDisabled_WithoutException()
        {
            int[] digits = { 1, 2 };
            var arg = new Argument<int[]>(digits, "name", validationIsDisabled: true);

            arg.MaxCount(digits.Length - 1);
        }

        [Fact]
        public void MaxCount_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1, 2};

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .MaxCount(1));

            Assert.Equal($"Argument '{nameof(arr)}' must contains a maximum of 1 elements. Current count elements: {arr.Length}", exc.Message);
        }
    }
}
