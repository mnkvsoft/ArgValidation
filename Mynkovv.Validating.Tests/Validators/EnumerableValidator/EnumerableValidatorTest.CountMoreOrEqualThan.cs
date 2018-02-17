using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountMoreOrEqualThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountMoreOrEqualThan(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сannot get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountEqual_Ok()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
           CreateEnumerableValidator(() => objsWithEqualCount).CountMoreOrEqualThan(count);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountLess_ArgumentException()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithLessCount).CountMoreOrEqualThan(count));
            Assert.Equal($"Object with name '{nameof(objsWithLessCount)}' must contains more or equal than {count} elements. Current count elements: {objsWithLessCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountMore_Ok()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            CreateEnumerableValidator(() => objsWithMoreCount).CountMoreOrEqualThan(count);
        }
    }
}
