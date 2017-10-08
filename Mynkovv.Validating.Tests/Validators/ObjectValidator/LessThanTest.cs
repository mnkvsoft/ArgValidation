using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class LessThanTest
    {
        [Fact]
        public void if_value_less_then_no_exception()
        {
            Validate.Obj(() => 3).LessThan(4);
        }

        [Fact]
        public void if_value_equal_then_throw_exception()
        {
            int val = 5;
            int equalVal = val;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => val).LessThan(equalVal));
            Assert.Equal($"Object with name '{nameof(val)}' must be less than '{equalVal}'. Current value: '{val}'", exc.Message);
        }

        [Fact]
        public void if_value_more_then_throw_exception()
        {
            int bigValue = 5;
            int smallValue = bigValue - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => bigValue).LessThan(smallValue));
            Assert.Equal($"Object with name '{nameof(bigValue)}' must be less than '{smallValue}'. Current value: '{bigValue}'", exc.Message);
        }
    }
}
