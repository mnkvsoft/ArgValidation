using System;
using Xunit;
using ArgValidation.Validators;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountMoreThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullValue).CountMoreThan(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountEqual_ArgumentException()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objsWithEqualCount).CountMoreThan(count));
            Assert.Equal($"Argument '{nameof(objsWithEqualCount)}' must contains more than {count} elements. Current count elements: {objsWithEqualCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountLess_ArgumentException()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objsWithLessCount).CountMoreThan(count));
            Assert.Equal($"Argument '{nameof(objsWithLessCount)}' must contains more than {count} elements. Current count elements: {objsWithLessCount.Length}", exc.Message);
        }

        [Fact]
        public void CountMoreThan_CountMore_Ok()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            Arg.Validate(() => objsWithMoreCount).CountMoreThan(count);
        }
    }
}
