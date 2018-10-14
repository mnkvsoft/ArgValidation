using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ObjectValidator
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
            Assert.Equal($"Argument '{nameof(val)}' must be not equal '{val}'", exc.Message);
        }
    }
}
