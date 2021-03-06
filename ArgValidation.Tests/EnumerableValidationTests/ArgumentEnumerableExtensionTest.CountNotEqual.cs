﻿using System;
using Xunit;

namespace ArgValidation.Tests.EnumerableValidationTests
{
    public partial class ArgumentEnumerableExtensionTest
    {
        [Fact]
        public void CountNotEqual_ValuesIsNull_ArgValidationException()
        {
            object[] nullValue = null;
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(() => nullValue).CountNotEqual(0));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountNotEqual_CountEqual_ArgumentException()
        {
            object[] objs = new[] { new object(), new object() };
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => objs).CountNotEqual(objs.Length));
            Assert.Equal($"Argument '{nameof(objs)}' not must contains {objs.Length} elements", exc.Message);
        }

        [Fact]
        public void CountNotEqual_CountNotEqual_Ok()
        {
            object[] objs = new[] { new object(), new object() };
            Arg.Validate(() => objs).CountNotEqual(objs.Length + 1);
        }

        [Fact]
        public void CountNotEqual_ValidationIsDisabled_WithoutException()
        {
            int[] digits = { 1, 2 };
            var arg = new Argument<int[]>(digits, "name", validationIsDisabled: true);

            arg.CountNotEqual(digits.Length);
        }

        [Fact]
        public void CountNotEqual_WithCustomException_CustomTypeException()
        {
            int[] arr = { 1 };

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(arr, nameof(arr))
                    .With<CustomException>()
                    .CountNotEqual(1));

            Assert.Equal($"Argument '{nameof(arr)}' not must contains {arr.Length} elements", exc.Message);
        }
    }
}
