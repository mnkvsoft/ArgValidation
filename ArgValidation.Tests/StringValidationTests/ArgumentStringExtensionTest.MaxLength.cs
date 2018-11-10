using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void MaxLength_ArgumentIsNull_ArgumentException()
        {
            var length = 2;
            string nullString = null;
            
            var exc = Assert.Throws<ArgumentException>(() =>
                Arg.Validate(() => nullString).MaxLength(length));
            
            Assert.Equal(
                $"Argument '{nameof(nullString)}' has a maximum length of {length}. Current length: unknown (string is null)",
                exc.Message);
        }

        [Fact]
        public void MaxLength_Equals_Ok()
        {
            var str = "str";
            var length = str.Length;
            
            Arg.Validate(() => str)
                .MaxLength(length);
        }

        [Fact]
        public void MaxLength_Less_Ok()
        {
            var str = "str";
            var length = str.Length + 1;
            
            Arg.Validate(() => str)
                .MaxLength(length);
        }

        [Fact]
        public void MaxLength_More_ArgumentException()
        {
            var str = "str";
            var length = str.Length - 1;
            
            var exc = Assert.Throws<ArgumentException>(() => 
                Arg.Validate(() => str)
                    .MaxLength(length));
            
            Assert.Equal(
                $"Argument '{nameof(str)}' has a maximum length of {length}. Current length: {str.Length}",
                exc.Message);
        }
    }
}