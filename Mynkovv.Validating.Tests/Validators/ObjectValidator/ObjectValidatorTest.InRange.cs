using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void InRange_EqualValuesNotImplementIComparable_Ok()
        {
            object value = new object();
            object min = value;
            object max = value;
            CreateObjectValidator(() => value).InRange(min, max);
        }

        [Fact]
        public void InRange_ValidatingObjectEqualMin_Ok()
        {
            int value2 = 2;
            int min2 = 2;
            int max3 = 3;

            CreateObjectValidator(() => value2).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ValidatingObjectEqualMax_Ok()
        {
            int value3 = 3;
            int min2 = 2;
            int max3 = 3;

            CreateObjectValidator(() => value3).InRange(min2, max3);
        }

        [Fact]
        public void InRange_ValueMiddleMinMax_Ok()
        {
            int value2 = 2;
            int min1 = 1;
            int max3 = 3;

            CreateObjectValidator(() => value2).InRange(min1, max3);
        }

        [Fact]
        public void InRange_ValidatingObjectMoreMax_ArgumentOutOfRangeException()
        {
            int value4 = 4;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value4).InRange(min1, max3));
            Assert.Equal($"Object with name '{nameof(value4)}' must be in range from '{min1}' to '{max3}'. Current value: '{value4}'", exc.Message);
        }

        [Fact]
        public void InRange_ValueLessMin_ArgumentOutOfRangeException()
        {
            int value0 = 0;
            int min1 = 1;
            int max3 = 3;

            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value0).InRange(min1, max3));
            Assert.Equal($"Object with name '{nameof(value0)}' must be in range from '{min1}' to '{max3}'. Current value: '{value0}'", exc.Message);
        }

        [Fact]
        public void InRange_ValdatingObjectNotNullAndMinNotNullButMaxIsNull_InvalidOperationException()
        {
            object value = new object();
            object min = new object();
            object maxNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).InRange(min, maxNull));
            Assert.Equal("Argument 'max' is null. Cannot define range", exc.Message);
        }

        [Fact]
        public void InRange_ValidatingObjectNotNullAndMaxNotNullButMinIsNull_InvalidOperationException()
        {
            object value = new object();
            object minNull = null;
            object max = new object();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).InRange(minNull, max));
            Assert.Equal("Argument 'min' is null. Cannot define range", exc.Message);
        }

        [Fact]
        public void InRange_MinNotNullAndMaxNotNullButValidatingObjectIsNull_InvalidOperationException()
        {
            object valueNull = null;
            object min = 1;
            object max = 2;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => valueNull).InRange(min, max));
            Assert.Equal($"Object with name '{nameof(valueNull)}' is null. Cannot define belonging to range: '{min}' - '{max}'", exc.Message);
        }

        [Fact]
        public void InRange_MinMoreThanMax_InvalidOperationException()
        {
            int value = 1;
            int min5 = 5;
            int max3 = 3;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).InRange(min5, max3));
            Assert.Equal("Argument 'min' cannot be more than 'max'. Cannot define range", exc.Message);
        }

        [Fact]
        public void InRange_ValidatingObjectNotImplementIComparable_InvalidOperationException()
        {
            object value = 1;
            object min = 5;
            object max = 3;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).InRange(min, max));
            Assert.Equal($"Object with name '{nameof(value)}' not implement interface '{typeof(IComparable<object>)}'. Сannot compare objects", exc.Message);
        }
    }
}
