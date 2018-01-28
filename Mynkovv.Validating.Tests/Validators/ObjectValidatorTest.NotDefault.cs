using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void NotDefault_ReferenceTypeIsNotNull_Ok()
        {
            CreateObjectValidator(() => new object()).NotDefault();
        }

        [Fact]
        public void NotDefault_ReferenceTypeIsNull_Exception()
        {
            object arg = null;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).NotDefault());
            Assert.Equal($"Object with name '{nameof(arg)}' must be not default value", exc.Message);
        }

        [Fact]
        public void NotDefault_ValueTypeIsNotDefault_Ok()
        {
            CreateObjectValidator(() => 5).NotDefault();
        }

        [Fact]
        public void NotDefault_ValueTypeIsDefault_ArgumentException()
        {
            int arg = default(int);
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).NotDefault());
            Assert.Equal($"Object with name '{nameof(arg)}' must be not default value", exc.Message);
        }
    }
}
