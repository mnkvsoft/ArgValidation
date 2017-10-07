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
            Validate.Argument(() => val).Equal(5);
        }

        [Fact]
        public void int_not_equal()
        {
            int val = 5;
            int expectedVal = 4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => val).Equal(expectedVal));
            Assert.Equal($"Object with name '{nameof(val)}' must be equal '{expectedVal}'", exc.Message);
        }

        [Fact]
        public void anonymous_object_equal()
        {
            var anonymousObj1 = new { Value = 2 };
            var anonymousObj2 = new { Value = 2 };

            Validate.Argument(() => anonymousObj1).Equal(anonymousObj2);
        }

        [Fact]
        public void anonymous_object_not_equal()
        {
            var anonymousObj1 = new { Value = 2 };
            var anonymousObj2 = new { Value = 3 };

            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => anonymousObj1).Equal(anonymousObj2));
            Assert.Equal($"Object with name '{nameof(anonymousObj1)}' must be equal '{anonymousObj2}'", exc.Message);
        }

        [Fact]
        public void objects_equals_nulls()
        {
            object obj1 = null;
            object obj2 = null;

            Validate.Argument(() => obj1).Equal(obj2);
        }

        [Fact]
        public void only_validating_object_is_null()
        {
            object obj1 = null;
            object obj2 = new object();

            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Argument(() => obj1).Equal(obj2));
            Assert.Equal($"Object with name '{nameof(obj1)}' must be equal '{obj2}'", exc.Message);
        }
    }
}
