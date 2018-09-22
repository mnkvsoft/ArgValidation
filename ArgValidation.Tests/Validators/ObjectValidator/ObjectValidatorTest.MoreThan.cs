using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void MoreThan_2MoreThan1_Ok()
        {
            CreateObjectValidator(() => 2).MoreThan(1);
        }

        [Fact]
        public void MoreThan_0MoreThan1_ArgumentOutOfRangeException()
        {
            int argEqual0 = 0;
            int valueEqual1 = 1;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => argEqual0).MoreThan(valueEqual1));
            Assert.Equal($"Object with name '{nameof(argEqual0)}' must be more than '{valueEqual1}'. Current value: '{argEqual0}'", exc.Message);
        }

        [Fact]
        public void MoreThan_1MoreThan1_ArgumentOutOfRangeException()
        {
            int value1 = 1;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value1).MoreThan(value1));
            Assert.Equal($"Object with name '{nameof(value1)}' must be more than '{value1}'. Current value: '{value1}'", exc.Message);
        }

        [Fact]
        public void MoreThan_ValidatingObjectIsNull_InvalidOperationException()
        {
            object nullValue = null;
            object moreThanValue = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => nullValue).MoreThan(moreThanValue));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_MoreThanArgumentIsNull_InvalidOperationException()
        {
            object value = new object();
            object moreThanNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).MoreThan(moreThanNull));
            Assert.Equal($"Argument 'moreThan' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_ValidatingObjectNotImplementIComparable_InvalidOperationException()
        {
            object notImplementIComparable = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => notImplementIComparable).MoreThan(notImplementIComparable));
            Assert.Equal($"Object with name '{nameof(notImplementIComparable)}' not implement interface '{typeof(IComparable<object>)}'. Сan not compare objects", exc.Message);
        }
    }
}
