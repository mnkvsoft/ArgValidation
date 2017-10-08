using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class DefaultTest
    {
        [Fact]
        public void reference_type_is_null()
        {
            object arg = null;
            Validate.Obj(() => arg).Default();
        }

        [Fact]
        public void exception_if_reference_type_is_not_null()
        {
            object arg = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => arg).Default());
            Assert.Equal($"Object with name '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void value_type_is_default()
        {
            Validate.Obj(() => default(int)).Default();
        }

        [Fact]
        public void exception_if_value_type_is_not_default()
        {
            int arg = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => arg).Default());
            Assert.Equal($"Object with name '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }
    }
}
