using System;
using ArgValidation.Internal;
using Xunit;

namespace ArgValidation.Tests.StringValidationTests
{
    public partial class ArgumentStringExtensionTest
    {
        [Fact]
        public void Match_IsMatch_Ok()
        {
            string digits = "1234567890";
            Arg.Validate(digits, nameof(digits))
                .Match("\\d{10}");
        }

        [Fact]
        public void Match_IsNotMatch_ArgumentException()
        {
            string letters = "asdf";
            const string pattern = "\\d{10}";
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(letters, nameof(letters)).Match(pattern));
            Assert.Equal($"Argument '{nameof(letters)}' must be match with pattern '{pattern}'. Current value: '{letters}'",exc.Message);
        }

        [Fact]
        public void Match_ArgumentValueIsNull_ArgValidationException()
        {
            string nullValue = null;
            const string pattern = "\\d{10}";
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => Arg.Validate(nullValue, nameof(nullValue)).Match(pattern));
            Assert.Equal($"Argument '{nameof(nullValue)}' is null. Can not execute 'Match' method", exc.Message);
        }

        [Fact]
        public void Match_Pattern_ArgValidationException()
        {
            string argValue = "some-value";
            ArgValidationException exc = Assert.Throws<ArgValidationException>(() => 
                Arg.Validate(argValue, nameof(argValue))
                    .Match(pattern: null));
            Assert.Equal($"Argument 'pattern' of method 'Match' is null. Can not execute 'Match' method", exc.Message);
        }

        [Fact]
        public void Match_ValidationIsDisabled_WithoutException()
        {
            string letters = "asdf";
            var arg = new Argument<string>(letters, "name", validationIsDisabled: true);
            arg.Match("\\d{10}");
        }

        [Fact]
        public void Match_WithCustomException_CustomTypeException()
        {
            string value = "123";

            string pattern = "\\d\\d\\d\\d";
            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Match(pattern));

            Assert.Equal($"Argument '{nameof(value)}' must be match with pattern '{pattern}'. Current value: '{value}'", exc.Message);
        }
    }
}
