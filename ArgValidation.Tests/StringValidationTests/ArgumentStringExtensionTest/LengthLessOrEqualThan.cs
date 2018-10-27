using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests.ArgumentStringExtensionTest
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void LengthLessOrEqualThan_ArgumentIsNull_ArgumentException()
        {
            var length = 2;
            string nullString = null;
            
            var exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(() => nullString).LengthLessOrEqualThan(length));
            
            Assert.Equal(
                $"Argument '{nameof(nullString)}' must be length less or equals than {length}. Current length: unknown (string is null)",
                exc.Message);
        }

        [Fact]
        public void LengthLessOrEqualThan_Equals_Ok()
        {
            var str = "str";
            var length = str.Length;
            
            Arg.Validate(() => str)
                .LengthLessOrEqualThan(length);
        }

        [Fact]
        public void LengthLessOrEqualThan_Less_Ok()
        {
            var str = "str";
            var length = str.Length + 1;
            
            Arg.Validate(() => str)
                .LengthLessOrEqualThan(length);
        }

        [Fact]
        public void LengthLessOrEqualThan_More_ArgumentException()
        {
            var str = "str";
            var length = str.Length - 1;
            
            var exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => str)
                    .LengthLessOrEqualThan(length));
            
            Assert.Equal(
                $"Argument '{nameof(str)}' must be length less or equals than {length}. Current length: {str.Length}",
                exc.Message);
        }
    }
}