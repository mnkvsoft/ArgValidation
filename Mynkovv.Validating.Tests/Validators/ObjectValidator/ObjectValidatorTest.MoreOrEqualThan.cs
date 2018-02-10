
using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void MoreOrEqualThan_3MoreOrEqualThan2_Ok()
        {
            CreateObjectValidator(() => 3).MoreOrEqualThan(2);
        }

        [Fact]
        public void MoreOrEqualThan_3MoreOrEqualThan3_Ok()
        {
            CreateObjectValidator(() => 3).MoreOrEqualThan(3);
        }

        [Fact]
        public void MoreOrEqualThan_3MoreOrEqualThan4_ArgumentOutOfRangeException()
        {
            int value3 = 3;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value3).MoreOrEqualThan(value4));
            Assert.Equal($"Object with name '{nameof(value3)}' must be more or equal than '{value4}'. Current value: '{value3}'", exc.Message);
        }

        [Fact]
        public void MoreOrEqualThan_NullMoreOrEqualThanNull_Ok()
        {
            object null1 = null;
            object null2 = null;
            CreateObjectValidator(() => null1).MoreOrEqualThan(null2);
        }

        [Fact]
        public void MoreOrEqualThan_EqualValuesNotImplementIComparable_Ok()
        {
            object notComparable = new object();
            CreateObjectValidator(() => notComparable).MoreOrEqualThan(notComparable);
        }

        [Fact]
        public void MoreOrEqualThan_ValidatingObjectNotImplementIComparable_InvalidOperationException()
        {
            object notImplementIComparable = new object();
            object moreOrEqualThanValue = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => notImplementIComparable).MoreOrEqualThan(moreOrEqualThanValue));
            Assert.Equal($"Object with name '{nameof(notImplementIComparable)}' not implement interface '{typeof(IComparable<object>)}'. Сannot compare objects", exc.Message);
        }
    }
}
