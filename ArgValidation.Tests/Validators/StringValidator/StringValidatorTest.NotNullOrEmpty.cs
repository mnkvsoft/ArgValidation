using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void NotNullOrEmpty_Empty_ArgumentException()
        {
            string emptyString = string.Empty;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => emptyString).NotNullOrEmpty());
            Assert.Equal($"Argument '{nameof(emptyString)}' cannot be empty or null. Current value: ''", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_Null_ArgumentException()
        {
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).NotNullOrEmpty());
            Assert.Equal($"Argument '{nameof(nullString)}' cannot be empty or null. Current value: null", exc.Message);
        }

        [Fact]
        public void NotNullOrEmpty_NotEmpty_Ok()
        {
            string notEmpty = "not-empty";
            CreateStringValidator(() => notEmpty).NotNullOrEmpty();
        }
    }
}
