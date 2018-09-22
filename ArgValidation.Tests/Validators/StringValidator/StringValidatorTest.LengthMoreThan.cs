using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthMoreThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length more than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Equals_ArgumentException()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length more than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            CreateStringValidator(() => str).LengthMoreThan(length);
        }
    }
}
