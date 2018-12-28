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
                .NotMatch("\\d+");
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
        public void NotMatch_ArgumentValueIsNull_ArgValidationException()
        {
            string nullValue = null;
            const string pattern = "\\d{10}";
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(nullValue, nameof(nullValue)).NotMatch(pattern));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Сan not execute 'NotMatch' method", exc.Message);
        }

        [Fact]
        public void NotMatch_Pattern_ArgValidationException()
        {
            string argValue = "some-value";
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => 
                Arg.Validate(argValue, nameof(argValue))
                    .NotMatch(pattern: null));
            Assert.Equal("Argument 'pattern' of method 'NotMatch' is null. Can not execute 'NotMatch' method", exc.Message);
        }

        [Fact]
        public void NotMatch_ValidationIsDisabled_WithoutException()
        {
            string digits = "0123456789";
            var arg = new Argument<string>(digits, "name", validationIsDisabled: true);
            arg.NotMatch("\\d+");
        }
    }
}
