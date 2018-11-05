using System;
using Xunit;

namespace ArgValidation.Tests.ObjectValidationTests
{
    public partial class ArgumentObjectExtensionTest
    {
        [Fact]
        public void OnlyValues_ArgumentIsNull_InvalidOperationException()
        {
            var value = new object();
            object[] nullArgument = null;

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => Arg.Validate(() => value).OnlyValues(nullArgument));

            Assert.Equal("Argument 'values' is null. There are no values to compare", exc.Message);
        }

        [Fact]
        public void OnlyValues_ArgumentOnlyNull_Ok()
        {
            object value = null;
            var onlyNull = new object[] { null };

            Arg.Validate(() => value).OnlyValues(onlyNull);
        }

        [Fact]
        public void OnlyValues_ArgumentEqual3only3or4_Ok()
        {
            Arg.Validate(() => 3).OnlyValues(3, 4);
        }

        [Fact]
        public void OnlyValues_ArgumentEqual3Only2Or1_ArgumentException()
        {
            int value3 = 3;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => Arg.Validate(() => value3).OnlyValues(2, 1));
            Assert.Equal($"Argument '{nameof(value3)}' must have only values: '2', '1'. Current value: '3'", exc.Message);
        }
    }
}
