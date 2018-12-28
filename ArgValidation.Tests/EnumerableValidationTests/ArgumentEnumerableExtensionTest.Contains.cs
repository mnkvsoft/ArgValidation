using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void Contains_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() =>
                Arg.Validate(() => nullValue)
                    .Contains(new object()));
            
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not execute 'Contains' method", exc.Message);
        }

        [Fact]
        public void Contains_ListWithNullContainsNull_Ok()
        {
            object nullObj = null;
            object[] objs = { nullObj, new object() };
            
            Arg.Validate(() => objs)
                .Contains(nullObj);
        }

        [Fact]
        public void Contains_ListWithoutNullContainsNull_ArgumentException()
        {
            object[] objs = { new object(), new object() };
            object nullObj = null;
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => objs)
                    .Contains(nullObj));
            
            Assert.Equal($"Argument '{nameof(objs)}' not contains null value", exc.Message);
        }

        [Fact]
        public void Contains_ListWith5Contains5_Ok()
        {
            int[] digits = { 1, 5 };
            Arg.Validate(() => digits)
                .Contains(5);
        }

        [Fact]
        public void Contains_ListWithout5Contains5_ArgumentException()
        {
            int value5 = 5;
            int[] digits = { 1, 2 };
            
            ArgumentException exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(() => digits)
                    .Contains(value5));
            
            Assert.Equal($"Argument '{nameof(digits)}' not contains '{value5}' value", exc.Message);
        }

        [Fact]
        public void Contains_ValidationIsDisabled_WithoutException()
        {
            int notContainsValue = 5;
            int[] digits = { 1, 2 };

            var arg = new Argument<int[]>(digits, "name", validationIsDisabled: true);

            arg.Contains(notContainsValue);
        }
    }
}
