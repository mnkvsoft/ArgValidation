﻿using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountLessThan_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountLessThan(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountLessThan_CountEqual_ArgumentException()
        {
            object[] objsWithEqualCount = new[] { new object(), new object() };
            int count = objsWithEqualCount.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithEqualCount).CountLessThan(count));
            Assert.Equal($"Object with name '{nameof(objsWithEqualCount)}' must contains less than {count} elements. Current count elements: {objsWithEqualCount.Length}", exc.Message);
        }

        [Fact]
        public void CountLessThan_CountLess_Ok()
        {
            object[] objsWithLessCount = new[] { new object(), new object() };
            int count = objsWithLessCount.Length + 1;
            CreateEnumerableValidator(() => objsWithLessCount).CountLessThan(count);
        }

        [Fact]
        public void CountLessThan_CountMore_ArgumentException()
        {
            object[] objsWithMoreCount = new[] { new object(), new object() };
            int count = objsWithMoreCount.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objsWithMoreCount).CountLessThan(count));
            Assert.Equal($"Object with name '{nameof(objsWithMoreCount)}' must contains less than {count} elements. Current count elements: {objsWithMoreCount.Length}", exc.Message);
        }
    }
}
