using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void NotContains_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullValue).NotContains(new object()));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'NotContains' method", exc.Message);
        }

        //todo: Arg.Validate(() => objs).NotContains(null);
        [Fact]
        public void NotContains_ListWithoutNullNotContainsNull_Ok()
        {
            object[] objs = { new object(), new object() };
            object nullObj = null;
            
            Arg.Validate(() => objs).NotContains(nullObj);
        }

        [Fact]
        public void NotContains_ListWithNullNotContainsNull_ArgumentException()
        {
            object nullObj = null;
            object[] objs = { new object(), new object(), nullObj };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objs).NotContains(nullObj));
            Assert.Equal($"Argument '{nameof(objs)}' contains null value. Current value: ['System.Object', 'System.Object', null]", exc.Message);
        }

        [Fact]
        public void NotContains_ListWithout5NotContains5_Ok()
        {
            int[] digits = { 1, 2 };
            Arg.Validate(() => digits).NotContains(5);
        }

        [Fact]
        public void NotContains_ListWith5NotContains5_ArgumentException()
        {
            int value5 = 5;
            int[] digits = { 1, 2, value5 };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => digits).NotContains(value5));
            Assert.Equal($"Argument '{nameof(digits)}' contains '{value5}' value. Current value: ['1', '2', '5']", exc.Message);
        }

        [Fact]
        public void NotContains_ValidationIsDisabled_WithoutException()
        {
            int[] digits = { 1, 2 };
            var arg = new Argument<int[]>(digits, "name", validationIsDisabled: true);

            arg.NotContains(digits[0]);
        }

        [Fact]
        public void NotContains_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1, 2 };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .NotContains(1));

            Assert.Equal($"Argument '{nameof(arr)}' contains '1' value. Current value: ['1', '2']", exc.Message);
        }
    }
}
