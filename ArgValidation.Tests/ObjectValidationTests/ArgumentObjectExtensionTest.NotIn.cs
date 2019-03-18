using System;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void NotIn_ListIsNull_ArgValidationException()
        {
            object[] nullList = null;

            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => 
                Arg.Validate(() => new object())
                    .NotIn(nullList));

            Assert.Equal("Argument 'values' is null. There are no values to compare", exc.Message);
        }

        [Fact]
        public void NotIn_ArgumentIsNullAndListContainsOnlyNull_ArgumentException()
        {
            object nullArg = null;
            var listContainedOnlyNull = new object[] { null };

            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => nullArg).NotIn(listContainedOnlyNull));
            Assert.Equal($"Argument '{nameof(nullArg)}' can not have the following values: null. Current value: null", exc.Message);
        }

        [Fact]
        public void NotIn_ArgumentContainsInList_ArgumentException()
        {
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => 3).NotIn(3, 4));
        }

        [Fact]
        public void NotIn_ArgumentNotContainsInList_Ok()
        {
            Arg.Validate(() => 3).NotIn(2, 1);
        }

        [Fact]
        public void NotIn_ValidationIsDisabled_WithoutException()
        {
            int value = 2;
            var arg = new Argument<int>(value, "name", validationIsDisabled: true);
            arg.NotIn(2, 3);
        }

        [Fact]
        public void NotIn_WithCustomException_CustomTypeException()
        {
            int value = 3;
            int[] arr = { 1, 2, value };
            
            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotIn(arr));

            Assert.Equal($"Argument '{nameof(value)}' can not have the following values: '1', '2', '3'. Current value: '{value}'", exc.Message);
        }
    }
}
