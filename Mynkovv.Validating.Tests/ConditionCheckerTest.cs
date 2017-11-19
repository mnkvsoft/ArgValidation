using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mynkovv.Validating.Tests
{
    public class ConditionCheckerTest
    {
        [Fact]
        public void Compare_ValidatingValueIsNull_Exception()
        {
            object nullValue = null;
            ValidatingObject<object> validatingObject = new ValidatingObject<object>(nameof(nullValue), nullValue);

            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.Compare(validatingObject, value));
            Assert.Equal($"Object with name '{validatingObject.Name}' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_MoreThanArgumentIsNull_Exception()
        {
            var validatingObject = new ValidatingObject<object>("name", new object());
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.MoreThan(validatingObject, null));
            Assert.Equal("Argument cannot be equal null", exc.Message);
        }

        [Fact]
        public void MoreThan_ValidatingValueNotIComparable_Exception()
        {
            var validatingObject = new ValidatingObject<object>("name", new object());
            object value = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => ConditionChecker.MoreThan(validatingObject, value));
            Assert.Equal($"Object with name '{validatingObject.Name}' must be implement interface '{typeof(IComparable<object>)}'", exc.Message);
        }
    }
}
