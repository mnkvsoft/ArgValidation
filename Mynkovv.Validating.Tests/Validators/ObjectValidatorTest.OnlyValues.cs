using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class ObjectValidatorTest
    {
        [Fact]
        public void OnlyValues_ArgumentIsNull_InvalidOperationException()
        {
            var value = new object();
            object[] nullArgument = null;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateObjectValidator(() => value).OnlyValues(nullArgument));

            Assert.Equal("Argument 'values' is null. There are no values to compare", exc.Message);
        }

        [Fact]
        public void OnlyValues_ValidatingObjectOnlyNull_Ok()
        {
            object value = null;
            var onlyNull = new object[] { null };

            CreateObjectValidator(() => value).OnlyValues(onlyNull);
        }

        [Fact]
        public void OnlyValues_ValidatingObjectEqual3Only3Or4_Ok()
        {
            CreateObjectValidator(() => 3).OnlyValues(3, 4);
        }

        [Fact]
        public void OnlyValues_ValidatingObjectEqual3Only2Or1_ArgumentException()
        {
            int value3 = 3;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateObjectValidator(() => value3).OnlyValues(2, 1));
            Assert.Equal($"Object with name '{nameof(value3)}' must have only values: '2', '1'. Current value: '3'", exc.Message);
        }
    }
}
