using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void NotEqual_5NotEqual4_Ok()
        {
            CreateObjectValidator(() => 5).NotEqual(4);
        }

        [Fact]
        public void NotEqual_5Equal5_ArgumentException()
        {
            int val = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => val).NotEqual(val));
            Assert.Equal($"Object with name '{nameof(val)}' must be not equal '{val}'", exc.Message);
        }
    }
}
