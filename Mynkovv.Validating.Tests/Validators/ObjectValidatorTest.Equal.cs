using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void Equal_5Equal5_Ok()
        {
            CreateObjectValidator(() => 5).Equal(5);
        }

        [Fact]
        public void Equal_5NotEqual4_ArgumentException()
        {
            int val = 5;
            int expectedVal = 4;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => val).Equal(expectedVal));
            Assert.Equal($"Object with name '{nameof(val)}' must be equal '{expectedVal}'. Current value: '{val}'", exc.Message);
        }
    }
}
