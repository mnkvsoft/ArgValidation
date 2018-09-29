using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
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
            ComparableClass null1 = null;
            ComparableClass null2 = null;
            CreateObjectValidator(() => null1).MoreOrEqualThan(null2);
        }
    }
}
