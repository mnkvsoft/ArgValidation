using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Argument
{
    public class DefaultTest
    {
        [Fact]
        public void reference_type_is_null()
        {
            object arg = null;
            Validate.Argument(() => arg).Default();
        }

        [Fact]
        public void exception_if_reference_type_is_not_null()
        {
            object arg = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => arg).Default());
            Assert.Equal($"Argument '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void value_type_is_default()
        {
            int arg = default(int);
            Validate.Argument(() => arg).Default();
        }

        [Fact]
        public void exception_if_value_type_is_not_default()
        {
            int arg = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => arg).Default());
            Assert.Equal($"Argument '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }
    }
}
