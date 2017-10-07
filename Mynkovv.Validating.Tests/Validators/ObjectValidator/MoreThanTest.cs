using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public class MoreThanTest
    {
        [Fact]
        public void value_more()
        {
            int argEqual2 = 2;
            Validate.Obj(() => argEqual2).MoreThan(1);
        }

        [Fact]
        public void value_not_more()
        {
            int argEqual0 = 0;
            int valueEqual1 = 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Validate.Obj(() => argEqual0).MoreThan(valueEqual1));
            Assert.Equal($"Object with name '{nameof(argEqual0)}' must be more than '{valueEqual1}'", exc.Message);
        }

        [Fact]
        public void exception_on_null_argument()
        {
            object argNull = null;
            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => argNull).MoreThan(value));
            Assert.Equal($"Object with name '{nameof(argNull)}' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void exception_on_null_value()
        {
            object arg = new object();
            object nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => arg).MoreThan(nullValue));
            Assert.Equal("Argument cannot be equal null", exc.Message);
        }

        [Fact]
        public void exception_on_not_IComparable()
        {
            object arg = new object();
            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => arg).MoreThan(value));
            Assert.Equal($"Object with name '{nameof(arg)}' must be implement interface '{typeof(IComparable<object>)}'", exc.Message);
        }
    }
}
