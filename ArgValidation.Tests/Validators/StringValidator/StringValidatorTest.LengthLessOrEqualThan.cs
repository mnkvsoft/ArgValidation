using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthLessOrEqualThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthLessOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length less or equals than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthLessOrEqualThan_More_ArgumentException()
        {
            string str = "str";
            int length = str.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessOrEqualThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less or equals than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessOrEqualThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            CreateStringValidator(() => str).LengthLessOrEqualThan(length);
        }

        [Fact]
        public void LengthLessOrEqualThan_Less_Ok()
        {
            string str = "str";
            int length = str.Length + 1;
            CreateStringValidator(() => str).LengthLessOrEqualThan(length);
        }
    }
}
