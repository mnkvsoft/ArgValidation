﻿using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void MaxLength_ArgumentIsNull_ArgValidationException()
        {
            var length = 2;
            string nullString = null;
            
            var exc = Assert.Throws<ArgValidationException>(() =>
                Arg.Validate(() => nullString).MaxLength(length));
            
            Assert.Equal(
                $"Argument '{nameof(nullString)}' is null. Can not execute 'MaxLength' method",
                exc.Message);
        }

        [Fact]
        public void MaxLength_Equals_Ok()
        {
            var str = "str";
            var length = str.Length;
            
            Arg.Validate(() => str)
                .MaxLength(length);
        }

        [Fact]
        public void MaxLength_Less_Ok()
        {
            var str = "str";
            var length = str.Length + 1;
            
            Arg.Validate(() => str)
                .MaxLength(length);
        }

        [Fact]
        public void MaxLength_More_ArgumentException()
        {
            var str = "str";
            var length = str.Length - 1;
            
            var exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => str)
                    .MaxLength(length));
            
            Assert.Equal(
                $"Argument '{nameof(str)}' has a maximum length of {length}. Current length: {str.Length}",
                exc.Message);
        }

        [Fact]
        public void MaxLength_ValidationIsDisabled_WithoutException()
        {
            string value = "asdf";
            var arg = new Argument<string>(value, "name", validationIsDisabled: true);
            arg.MaxLength(value.Length - 1);
        }

        [Fact]
        public void MaxLength_WithCustomException_CustomTypeException()
        {
            string value = "123";

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .MaxLength(1));

            Assert.Equal($"Argument '{nameof(value)}' has a maximum length of 1. Current length: {value.Length}", exc.Message);
        }
    }
}