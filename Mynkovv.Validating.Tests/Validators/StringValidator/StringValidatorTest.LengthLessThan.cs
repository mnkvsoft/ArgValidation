using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthLessThan_ValidatingObjectIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(nullString)}' must be length less than {length}. Current length: unknown (string is null)", exc.Message);
        }

        [Fact]
        public void LengthLessThan_More_ArgumentException()
        {
            string str = "str";
            int length = str.Length - 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthLessThan(length));
            Assert.Equal($"String with name '{nameof(str)}' must be length less than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthLessThan_Less_Ok()
        {
            string str = "str";
            int length = str.Length + 1;
            CreateStringValidator(() => str).LengthLessThan(length);
        }
    }
}
