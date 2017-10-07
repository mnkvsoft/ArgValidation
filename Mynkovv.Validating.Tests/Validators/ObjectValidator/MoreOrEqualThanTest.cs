using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class MoreOrEqualThanTest
    {
        [Fact]
        public void value_more_than()
        {
            int value = 3;
            Validate.Obj(() => value).MoreOrEqualThan(2);
        }

        [Fact]
        public void value_equal()
        {
            int value = 3;
            Validate.Obj(() => value).MoreOrEqualThan(3);
        }

        [Fact]
        public void value_less()
        {
            int value3 = 3;
            int value4 = 4; 
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => value3).MoreOrEqualThan(value4));
            Assert.Equal($"Object with name '{nameof(value3)}' must be more or equal {value4}. Current value: '{value3}'", exc.Message);
        }

        [Fact]
        public void validating_object_is_null()
        {
            int? nullValue = null;
            int value4 = 4;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => nullValue).MoreOrEqualThan(value4));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void argument_method_is_null()
        {
            int? val = 5;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => val).MoreOrEqualThan(null));
            Assert.Equal("Argument cannot be equal null", exc.Message);
        }
    }
}
