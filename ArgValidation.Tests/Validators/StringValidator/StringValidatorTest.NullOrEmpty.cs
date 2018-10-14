using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NullOrEmpty_Empty_Ok()
        {
            CreateStringValidator(() => string.Empty).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_Null_Ok()
        {
            CreateStringValidator(() => null).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_NotEmpty_ArgumentException()
        {
            string notEmptyString = "not-empty";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => notEmptyString).NullOrEmpty());
            Assert.Equal($"Argument '{nameof(notEmptyString)}' must be empty or null. Current value: '{notEmptyString}'", exc.Message);
        }
    }
}
