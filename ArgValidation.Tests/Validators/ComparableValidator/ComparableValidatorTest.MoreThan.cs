using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
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
            Assert.Equal($"Argument '{nameof(argEqual0)}' must be more than '{valueEqual1}'. Current value: '{argEqual0}'", exc.Message);
        }

        [Fact]
        public void MoreThan_1MoreThan1_ArgumentOutOfRangeException()
        {
            int value1 = 1;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value1).MoreThan(value1));
            Assert.Equal($"Argument '{nameof(value1)}' must be more than '{value1}'. Current value: '{value1}'", exc.Message);
        }

        [Fact]
        public void MoreThan_ArgumentIsNull_InvalidOperationException()
        {
            ComparableClass nullValue = null;
            ComparableClass moreThanValue = new ComparableClass();
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                CreateObjectValidator(() => nullValue).MoreThan(moreThanValue);
            });
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not compare null object", exc.Message);
        }

        [Fact]
        public void MoreThan_MoreThanArgumentIsNull_InvalidOperationException()
        {
            ComparableClass value = new ComparableClass();
            ComparableClass moreThanNull = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
            {
                CreateObjectValidator(() => value).MoreThan(moreThanNull);
            });
            Assert.Equal($"Argument 'moreThan' is null. Сan not compare null object", exc.Message);
        }
    }
}
