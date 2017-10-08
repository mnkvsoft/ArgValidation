using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class NotNullTest
    {
        [Fact]
        public void exception_if_object_is_null()
        {
            object nullObj = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => Validate.Obj(() => nullObj).NotNull());
            Assert.Equal(nameof(nullObj), exc.ParamName);
        }

        [Fact]
        public void object_is_not_null()
        {
            Validate.Obj(() => new object()).NotNull();
        }

        [Fact]
        public void exception_if_nullable_is_null()
        {
            int? nullArg = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => Validate.Obj(() => nullArg).NotNull());
            Assert.Equal(nameof(nullArg), exc.ParamName);
        }

        [Fact]
        public void nullable_is_not_null()
        {
            Validate.Obj(() => 5).NotNull();
        }
    }
}
