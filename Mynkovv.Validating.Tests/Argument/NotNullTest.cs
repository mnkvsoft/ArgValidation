using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Argument
{
    public class NotNullTest
    {
        [Fact]
        public void object_is_null()
        {
            object nullObj = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => Validate.Argument(() => nullObj).NotNull());
            Assert.Equal(nameof(nullObj), exc.ParamName);
        }

        [Fact]
        public void object_is_not_null()
        {
            object notNullObj = new object();
            Validate.Argument(() => notNullObj).NotNull();
        }

        [Fact]
        public void nullable_is_null()
        {
            int? nullArg = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => Validate.Argument(() => nullArg).NotNull());
            Assert.Equal(nameof(nullArg), exc.ParamName);
        }

        [Fact]
        public void nullable_is_not_null()
        {
            int? notNullObj = 5;
            Validate.Argument(() => notNullObj).NotNull();
        }
    }
}
