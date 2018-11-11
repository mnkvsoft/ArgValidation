using System;
using Xunit;

namespace ArgValidation.Tests.ComparableValidationTests
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void Min_3Min2_Ok()
        {
            Arg.Validate(() => 3).Min(2);
        }

        [Fact]
        public void Min_3Min3_Ok()
        {
            Arg.Validate(() => 3).Min(3);
        }

        [Fact]
        public void Min_3Min4_ArgumentOutOfRangeException()
        {
            int value3 = 3;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => Arg.Validate(() => value3).Min(value4));
            Assert.Equal($"The minimum value for the argument '{nameof(value3)}' is '{value4}'. Current value: '{value3}'", exc.Message);
        }

        [Fact]
        public void Min_ArgumentIsNull_InvalidOperationException()
        {
            ComparableClass nullValue = null;
            ComparableClass minValue = new ComparableClass();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                Arg.Validate(() => nullValue).Min(minValue);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void Min_MinArgumentIsNull_InvalidOperationException()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass minNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                Arg.Validate(() => value).Min(minNull);
            });
            Assert.Equal("Argument 'value' of method 'Min' is null. Сan not compare null object", exc.Message);
        }
    }
}
