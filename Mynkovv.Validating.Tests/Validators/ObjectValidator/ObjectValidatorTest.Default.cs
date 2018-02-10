using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void Default_ReferenceTypeIsNull_Ok()
        {
            object arg = null;
            CreateObjectValidator(() => arg).Default();
        }

        [Fact]
        public void Default_ReferenceTypeIsNotNull_ArgumentException()
        {
            object arg = new object();
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).Default());
            Assert.Equal($"Object with name '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }

        [Fact]
        public void Default_ValueTypeIsDefault_Ok()
        {
            CreateObjectValidator(() => default(int)).Default();
        }

        [Fact]
        public void Default_ValueTypeIsNotDefault_ArgumentException()
        {
            int arg = 5;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => arg).Default());
            Assert.Equal($"Object with name '{nameof(arg)}' must be default value. Current value: '{arg}'", exc.Message);
        }
    }
}
