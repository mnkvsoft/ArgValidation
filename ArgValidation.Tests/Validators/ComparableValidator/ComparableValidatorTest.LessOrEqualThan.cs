using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
    {
        [Fact]
        public void LessOrEqualThan_2LessOrEqualThan3_Ok()
        {
            CreateObjectValidator(() => 2).LessOrEqualThan(3);
        }

        [Fact]
        public void LessOrEqualThan_3LessOrEqualThan3_Ok()
        {
            CreateObjectValidator(() => 3).LessOrEqualThan(3);
        }

        [Fact]
        public void LessOrEqualThan_4LessOrEqualThan3_ArgumentOutOfRangeException()
        {
            int value3 = 3;
            int value4 = 4;
            ArgumentOutOfRangeException exc = Assert.Throws<ArgumentOutOfRangeException>(() => CreateObjectValidator(() => value4).LessOrEqualThan(value3));
            Assert.Equal($"Object with name '{nameof(value4)}' must be less or equal than '{value3}'. Current value: '{value4}'", exc.Message);
        }

        [Fact]
        public void LessOrEqualThan_NullLessOrEqualThanNull_Ok()
        {
            ComparableClass null1 = null;
            ComparableClass null2 = null;
            CreateObjectValidator(() => null1).LessOrEqualThan(null2);
        }
    }
}
