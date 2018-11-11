using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void MinLength_ArgumentIsNull_InvalidOperationException()
        {
            int length = 2;
            string nullString = null;
            var exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => nullString).MinLength(length));
            Assert.Equal($"Argument '{nameof(nullString)}' is null. Сan not execute 'MinLength' method", exc.Message);
        }

        [Fact]
        public void MinLength_Less_ArgumentException()
        {
            string str = "str";
            int length = str.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => str).MinLength(length));
            Assert.Equal($"Argument '{nameof(str)}' has a minimum length of {length}. Current length: {str.Length}", exc.Message);
        }

        [Fact]
        public void MinLength_More_Ok()
        {
            string str = "str";
            int length = str.Length - 1;
            Arg.Validate(() => str).MinLength(length);
        }

        [Fact]
        public void MinLength_Equals_Ok()
        {
            string str = "str";
            int length = str.Length;
            Arg.Validate(() => str).MinLength(length);
        }
    }
}
