using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthMoreOrEqualThan_ArgumentIsNull_InvalidOperationException()
        {
            int length = 2;
            string nullString = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullString).LengthMoreOrEqualThan(length));
            Assert.Equal($"Argument '{nameof(nullString)}' is null. Сan not execute 'LengthMoreOrEqualThan' method", exc.Message);
        }


        [Fact]
        public void LengthMoreOrEqualThan_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).LengthMoreOrEqualThan(length));
            Assert.Equal($"Argument '{nameof(str)}' must be length more or equals than {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void LengthMoreOrEqualThan_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            Arg.Validate(() => str).LengthMoreOrEqualThan(length);
        }

        [Fact]
        public void LengthMoreOrEqualThan_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            Arg.Validate(() => str).LengthMoreOrEqualThan(length);
        }
    }
}
