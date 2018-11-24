using System;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void NotMatch_IsNotMatch_Ok()
        {
            string letters = "asdf";
            Arg.Validate(letters, nameof(letters))
                .NotMatch("\\d{10}");
        }

        [Fact]
        public void NotMatch_IsMatch_ArgumentException()
        {
            string digits = "1234567890";
            const string pattern = "\\d{10}";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(digits, nameof(digits)).NotMatch(pattern));
            Assert.Equal($"Argument '{nameof(digits)}' not must be match with pattern '{pattern}'. Current value: '{digits}'",exc.Message);
        }

        [Fact]
        public void NotMatch_ArgumentValueIsNull_InvalidOperationException()
        {
            string nullValue = null;
            const string pattern = "\\d{10}";
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(nullValue, nameof(nullValue)).NotMatch(pattern));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not execute 'NotMatch' method", exc.Message);
        }

        [Fact]
        public void NotMatch_Pattern_InvalidOperationException()
        {
            string argValue = "some-value";
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => 
                Arg.Validate(argValue, nameof(argValue))
                    .NotMatch(pattern: null));
            Assert.Equal($"Argument 'pattern' of method 'NotMatch' is null. Can not execute 'NotMatch' method", exc.Message);
        }
    }
}
