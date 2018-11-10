using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void MaxLength_ArgumentIsNull_InvalidOperationException()
        {
            var length = 2;
            string nullString = null;
            
            var exc = Assert.Throws<InvalidOperationException>(() =>
                Arg.Validate(() => nullString).MaxLength(length));
            
            Assert.Equal(
                $"Argument '{nameof(nullString)}' is null. Сan not execute 'MaxLength' operation",
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