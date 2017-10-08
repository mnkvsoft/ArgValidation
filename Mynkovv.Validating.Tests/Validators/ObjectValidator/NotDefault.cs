using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class NotDefault
    {
        [Fact]
        public void reference_type_is_not_null()
        {
            Validate.Obj(() => new object()).NotDefault();
        }

        [Fact]
        public void exception_if_reference_type_is_null()
        {
            object arg = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => arg).NotDefault());
            Assert.Equal($"Object with name '{nameof(arg)}' must be not default value", exc.Message);
        }

        [Fact]
        public void value_type_is_not_default()
        {
            Validate.Obj(() => 5).NotDefault();
        }

        [Fact]
        public void exception_if_value_type_is_default()
        {
            int arg = default(int);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => arg).NotDefault());
            Assert.Equal($"Object with name '{nameof(arg)}' must be not default value", exc.Message);
        }
    }
}
