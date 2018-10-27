using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NullOrEmpty_Empty_Ok()
        {
            Arg.Validate(() => string.Empty).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_Null_Ok()
        {
            string nullStr = null;
            Arg.Validate(() => nullStr).NullOrEmpty();
        }

        [Fact]
        public void NullOrEmpty_NotEmpty_ArgumentException()
        {
            string notEmptyString = "not-empty";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => notEmptyString).NullOrEmpty());
            Assert.Equal($"Argument '{nameof(notEmptyString)}' must be empty or null. Current value: '{notEmptyString}'", exc.Message);
        }
    }
}
