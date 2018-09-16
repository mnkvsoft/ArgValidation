using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountEqual_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountEqual(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountEqual_CountEqual_Ok()
        {
            object[] objs = new[] { new object(), new object() };
            CreateEnumerableValidator(() => objs).CountEqual(objs.Length);
        }

        [Fact]
        public void CountEqual_CountNotEqual_ArgumentException()
        {
            object[] objsWithNotEqualCount = new[] { new object(), new object() };
            int count = objsWithNotEqualCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithNotEqualCount).CountEqual(count));
            Assert.Equal($"Object with name '{nameof(objsWithNotEqualCount)}' must contains {count} elements. Current count elements: {objsWithNotEqualCount.Length}", exc.Message);
        }
    }
}
