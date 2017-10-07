using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class EqualTest
    {
        [Fact]
        public void int_equal()
        {
            int val = 5;
            Validate.Obj(() => val).Equal(5);
        }

        [Fact]
        public void exception_if_int_not_equal()
        {
            int val = 5;
            int expectedVal = 4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => val).Equal(expectedVal));
            Assert.Equal($"Object with name '{nameof(val)}' must be equal '{expectedVal}'. Current value: '{val}'", exc.Message);
        }
    }
}
