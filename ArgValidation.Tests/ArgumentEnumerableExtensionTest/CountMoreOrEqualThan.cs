using System;
using Xunit;

namespace ArgValidation.Tests.ArgumentEnumerableExtensionTest
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void CountMoreOrEqualThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullValue).CountMoreOrEqualThan(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountEqual_Ok()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
           Arg.Validate(() => objsWithEqualCount).CountMoreOrEqualThan(count);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountLess_ArgumentException()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objsWithLessCount).CountMoreOrEqualThan(count));
            Assert.Equal($"Argument '{nameof(objsWithLessCount)}' must contains more or equal than {count} elements. Current count elements: {objsWithLessCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreOrEqualThan_CountMore_Ok()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            Arg.Validate(() => objsWithMoreCount).CountMoreOrEqualThan(count);
        }
    }
}
