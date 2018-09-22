using System;
using Xunit;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountMoreThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountMoreThan(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountEqual_ArgumentException()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithEqualCount).CountMoreThan(count));
            Assert.Equal($"Object with name '{nameof(objsWithEqualCount)}' must contains more than {count} elements. Current count elements: {objsWithEqualCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountLess_ArgumentException()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithLessCount).CountMoreThan(count));
            Assert.Equal($"Object with name '{nameof(objsWithLessCount)}' must contains more than {count} elements. Current count elements: {objsWithLessCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountMore_Ok()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            CreateEnumerableValidator(() => objsWithMoreCount).CountMoreThan(count);
        }
    }
}
