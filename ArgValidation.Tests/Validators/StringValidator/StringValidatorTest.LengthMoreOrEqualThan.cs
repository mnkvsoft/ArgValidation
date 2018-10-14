using System;
using Xunit;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        [Fact]
        public void LengthMoreOrEqualThan_ArgumentIsNull_ArgumentException()
        {
            int length = 2;
            string nullString = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => nullString).LengthMoreOrEqualThan(length));
            Assert.Equal($"Argument '{nameof(nullString)}' must be length more or equals than {length}. Current length: unknown (string is null)", exc.Message);
        }


        [Fact]
        public void LengthMoreOrEqualThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateStringValidator(() => str).LengthMoreOrEqualThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length more or equals than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreOrEqualThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            CreateStringValidator(() => str).LengthMoreOrEqualThan(length);
        }

        [Fact]
        public void LengthMoreOrEqualThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            CreateStringValidator(() => str).LengthMoreOrEqualThan(length);
        }
    }
}
