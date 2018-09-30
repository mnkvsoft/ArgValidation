using System;
using Xunit;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void NotContains_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).NotContains(new object()));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сan not execute 'NotContains' operation", exc.Message);
        }

        [Fact]
        public void NotContains_ListWithoutNullNotContainsNull_Ok()
        {
            object[] objs = { new object(), new object() };
            CreateEnumerableValidator(() => objs).NotContains(null);
        }

        [Fact]
        public void NotContains_ListWithNullNotContainsNull_ArgumentException()
        {
            object nullObj = null;
            object[] objs = { new object(), new object(), nullObj };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objs).NotContains(nullObj));
            Assert.Equal($"Object with name '{nameof(objs)}' not contains null value", exc.Message);
        }

        [Fact]
        public void NotContains_ListWithout5NotContains5_Ok()
        {
            int[] digits = { 1, 2 };
            CreateEnumerableValidator(() => digits).NotContains(5);
        }

        [Fact]
        public void NotContains_ListWith5NotContains5_ArgumentException()
        {
            int value5 = 5;
            int[] digits = { 1, 2, value5 };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => digits).NotContains(value5));
            Assert.Equal($"Object with name '{nameof(digits)}' not contains '{value5}' value", exc.Message);
        }
    }
}
