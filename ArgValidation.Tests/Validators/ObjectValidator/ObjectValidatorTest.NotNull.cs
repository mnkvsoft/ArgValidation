using System;
using Xunit;

namespace ArgValidation.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void NotNull_ObjectIsNull_ArgumentNullException()
        {
            object nullObj = null;
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() => Arg.Validate(() => nullObj).NotNull());
            Assert.Equal(nameof(nullObj), exc.ParamName);
        }

        [Fact]
        public void NotNull_ObjectIsNotNull_Ok()
        {
            Arg.Validate(() => new object()).NotNull();
        }

        [Fact]
        public void NotNull_NullableIsNull_ArgumentNullException()
        {
            int? nullArg = new int?();
            ArgumentNullException exc = Assert.Throws<ArgumentNullException>(() =>
            {
                Arg.Validate(() => nullArg)
                    .NotNull();
            });
            Assert.Equal(nameof(nullArg), exc.ParamName);
        }

        [Fact]
        public void NotNull_NullableIsNotNull_Ok()
        {
            Arg.Validate(() => 5).NotNull();
        }
    }
}
