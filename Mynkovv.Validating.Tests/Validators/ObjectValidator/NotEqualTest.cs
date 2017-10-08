using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class NotEqualTest
    {
        [Fact]
        public void not_equal()
        {
            Validate.Obj(() => 5).NotEqual(4);
        }

        [Fact]
        public void exception_if_equal()
        {
            int val = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => val).NotEqual(val));
            Assert.Equal($"Object with name '{nameof(val)}' must be not equal '{val}'", exc.Message);
        }
    }
}
