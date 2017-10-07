using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Argument
{
    public class NullTest
    {
        [Fact]
        public void object_is_not_null()
        {
            object notNullObj = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => notNullObj).Null());
            Assert.Equal($"Object with name '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void object_is_null()
        {
            object nullObj = null;
            Validate.Argument(() => nullObj).Null();
        }

        [Fact]
        public void nullable_is_not_null()
        {
            int? notNullObj = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => notNullObj).Null());
            Assert.Equal($"Object with name '{nameof(notNullObj)}' must be null. Current value: '{notNullObj}'", exc.Message);
        }

        [Fact]
        public void nullable_is_null()
        {
            int? nullObj = null;
            Validate.Argument(() => nullObj).Null();
        }
    }
}
