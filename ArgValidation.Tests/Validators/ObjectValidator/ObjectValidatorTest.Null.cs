using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void Null_ObjectIsNotNull_ArgumentException()
        {
            object notNullObj = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => notNullObj).Null());
            Assert.Equal($"Argument '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void Null_ObjectIsNull_Ok()
        {
            object nullObj = null;
            CreateObjectValidator(() => nullObj).Null();
        }

        [Fact]
        public void Null_NullableIsNotNull_ArgumentException()
        {
            int? notNullObj = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => notNullObj).Null());
            Assert.Equal($"Argument '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void Null_NullableIsNull_Ok()
        {
            int? nullObj = null;
            CreateObjectValidator(() => nullObj).Null();
        }
    }
}
