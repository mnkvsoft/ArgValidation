using System;
using Xunit;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountLessOrEqualThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountLessOrEqualThan(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountLessOrEqualThan_CountEqual_Ok()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
           CreateEnumerableValidator(() => objsWithEqualCount).CountLessOrEqualThan(count);
        }

        [Fact]
        public void CountLessOrEqualThan_CountLess_Ok()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            CreateEnumerableValidator(() => objsWithLessCount).CountLessOrEqualThan(count);
        }

        [Fact]
        public void CountLessOrEqualThan_CountMore_ArgumentException()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithMoreCount).CountLessOrEqualThan(count));
            Assert.Equal($"Argument '{nameof(objsWithMoreCount)}' must contains less or equal than {count} elements. Current count elements: {objsWithMoreCount.Length}", exc.Message);
        }
    }
}
