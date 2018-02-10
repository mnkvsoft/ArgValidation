using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void LessThan_3LessThan4_Ok()
        {
            CreateObjectValidator(() => 3).LessThan(4);
        }

        [Fact]
        public void LessThan_EqualValues_ArgumentOutOfRangeException()
        {
            int val = 5;
            int equalVal = val;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => val).LessThan(equalVal));
            Assert.Equal($"Object with name '{nameof(val)}' must be less than '{equalVal}'. Current value: '{val}'", exc.Message);
        }

        [Fact]
        public void LessThan_5LessThan4_ArgumentOutOfRangeException()
        {
            int value5 = 5;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value5).LessThan(value4));
            Assert.Equal($"Object with name '{nameof(value5)}' must be less than '{value4}'. Current value: '{value5}'", exc.Message);
        }

        [Fact]
        public void LessThan_ValidatingObjectIsNull_InvalidOperationException()
        {
            object nullValue = null;
            object lessThanValue = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => nullValue).LessThan(lessThanValue));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void LessThan_LessThanArgumentIsNull_InvalidOperationException()
        {
            object value = new object();
            object lessThanNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).LessThan(lessThanNull));
            Assert.Equal($"Argument 'lessThan' is null. Сannot compare null object", exc.Message);
        }

        [Fact]
        public void LessThan_ValidatingObjectNotImplementIComparable_InvalidOperationException()
        {
            object notImplementIComparable = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => notImplementIComparable).LessThan(notImplementIComparable));
            Assert.Equal($"Object with name '{nameof(notImplementIComparable)}' not implement interface '{typeof(IComparable<object>)}'. Сannot compare objects", exc.Message);
        }
    }
}
