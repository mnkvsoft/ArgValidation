﻿using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void NotDefault_ReferenceTypeIsNotNull_Ok()
        {
            CreateObjectValidator(() => new object()).NotDefault();
        }

        [Fact]
        public void NotDefault_ReferenceTypeIsNull_Exception()
        {
            object arg = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).NotDefault());
            Assert.Equal($"Argument '{nameof(arg)}' must be not default value", exc.Message);
        }

        [Fact]
        public void NotDefault_ValueTypeIsNotDefault_Ok()
        {
            CreateObjectValidator(() => 5).NotDefault();
        }

        [Fact]
        public void NotDefault_ValueTypeIsDefault_ArgumentException()
        {
            int arg = default(int);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).NotDefault());
            Assert.Equal($"Argument '{nameof(arg)}' must be not default value", exc.Message);
        }
    }
}
