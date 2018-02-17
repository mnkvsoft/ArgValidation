﻿using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountNotEqual_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountNotEqual(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сannot get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountNotEqual_CountEqual_ArgumentException()
        {
            object[] objs = new[] { new object(), new object() };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objs).CountNotEqual(objs.Length));
            Assert.Equal($"Object with name '{nameof(objs)}' not must contains {objs.Length} elements", exc.Message);
        }

        [Fact]
        public void CountNotEqual_CountNotEqual_Ok()
        {
            object[] objs = new[] { new object(), new object() };
            CreateEnumerableValidator(() => objs).CountNotEqual(objs.Length + 1);
        }
    }
}