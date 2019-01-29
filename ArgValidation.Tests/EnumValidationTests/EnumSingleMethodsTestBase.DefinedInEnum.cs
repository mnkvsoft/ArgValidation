using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests.EnumValidationTests
{
    public abstract class EnumSingleMethodsTestBase
    {
        protected abstract void RunDefinedInEnum<TEnum>(Expression<Func<TEnum>> value) where TEnum : Enum;

        [Fact]
        public void DefinedInEnum_ArgumentDefinedInEnum_Ok()
        {
            NotFlagsEnum value = NotFlagsEnum.Value1;
            RunDefinedInEnum(() => value);
        }

        [Fact]
        public void DefinedInEnum_ArgumentNotDefinedInEnum_ArgumentException()
        {
            NotFlagsEnum value = (NotFlagsEnum)111;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunDefinedInEnum(() => value));
            Assert.Equal($"Argument '{nameof(value)}' must be defined in enum type {typeof(NotFlagsEnum).FullName}. Current value: {value}", exc.Message);
        }

        [Fact]
        public void DefinedInEnum_ArgumentIsFlagsDefinedInEnumAsMultiple_Ok()
        {
            FlagsEnum value = FlagsEnum.Value1 | FlagsEnum.Value2;
            RunDefinedInEnum(() => value);
        }

        [Fact]
        public void DefinedInEnum_ArgumentIsFlagsAndNotDefinedInEnum_ArgumentException()
        {
            FlagsEnum value7 = (FlagsEnum)22;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => RunDefinedInEnum(() => value7));
            Assert.Equal($"Argument '{nameof(value7)}' must be defined in enum type {typeof(FlagsEnum).FullName}. Current value: {value7}", exc.Message);
        }

        [Fact]
        public void DefinedInEnum_ValidationIsDisabled_WithoutException()
        {
            NotFlagsEnum value = (NotFlagsEnum)111;
            var arg = new Argument<NotFlagsEnum>(value, "name", validationIsDisabled: true);
            arg.DefinedInEnum();
        }
    }
}
