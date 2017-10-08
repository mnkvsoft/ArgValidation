using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests
{
    public class ConditionCheckerTest
    {
        [Fact]
        public void exception_if_validatingValue_is_null()
        {
            object nullValue = null;
            ValidatingObject<object> validatingObject = new ValidatingObject<object>(nameof(nullValue), nullValue);

            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.Compare(validatingObject, value));
            Assert.Equal($"Object with name '{validatingObject.Name}' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void exception_if_method_argument_is_null()
        {
            object validatingValue = new object();
            object nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => validatingValue).MoreThan(nullValue));
            Assert.Equal("Argument cannot be equal null", exc.Message);
        }

        [Fact]
        public void exception_if_validatingValue_not_IComparable()
        {
            object validatingValue = new object();
            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Validate.Obj(() => validatingValue).MoreThan(value));
            Assert.Equal($"Object with name '{nameof(validatingValue)}' must be implement interface '{typeof(IComparable<object>)}'", exc.Message);
        }
    }
}
