using System;
using ArgValidation.Validators;
using Xunit;

namespace ArgValidation.Tests
{
    public class ComparableValidatorExtensionTest
    {
        [Theory]
        [InlineData(0.01)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Positive_ValueMoreThanZero_Ok(double doubleValue)
        {
            var intValue = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Arg.Validate(() => doubleValue).Positive();
            Arg.Validate(() => intValue).Positive();
            Arg.Validate(() => decimalValue).Positive();
            Arg.Validate(() => floatValue).Positive();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void Positive_ValueLessOrEqualsZero_Exception(double doubleValue)
        {
            var intValue = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => doubleValue).Positive(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => intValue).Positive(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => decimalValue).Positive(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => floatValue).Positive(); });
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.01)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void PositiveOrZero_ValueMoreOrEqualsZero_Ok(double doubleValue)
        {
            var intValue = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Arg.Validate(() => doubleValue).PositiveOrZero();
            Arg.Validate(() => intValue).PositiveOrZero();
            Arg.Validate(() => decimalValue).PositiveOrZero();
            Arg.Validate(() => floatValue).PositiveOrZero();
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void PositiveOrZero_ValueLessThanZero_Exception(double doubleValue)
        {
            var intValue = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => doubleValue).PositiveOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => intValue).PositiveOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => decimalValue).PositiveOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => floatValue).PositiveOrZero(); });
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(100)]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(0.1)]
        [InlineData(0.01)]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void Zero_ValueNotEqualsZero_Exception(double doubleValue)
        {
            var intValue = doubleValue < 0 ? (int) Math.Floor(doubleValue) : (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => doubleValue).Zero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => intValue).Zero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => decimalValue).Zero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => floatValue).Zero(); });
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(100)]
        [InlineData(10)]
        [InlineData(1)]
        [InlineData(0.1)]
        [InlineData(0.01)]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void NotZero_ValueNotEqualsZero_Ok(double doubleValue)
        {
            var intValue = doubleValue < 0 ? (int) Math.Floor(doubleValue) : (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Arg.Validate(() => doubleValue).NotZero();
            Arg.Validate(() => intValue).NotZero();
            Arg.Validate(() => decimalValue).NotZero();
            Arg.Validate(() => floatValue).NotZero();
        }

        [Theory]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void Negative_ValueLessThanZero_Ok(double doubleValue)
        {
            var intValue = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Arg.Validate(() => doubleValue).Negative();
            Arg.Validate(() => intValue).Negative();
            Arg.Validate(() => decimalValue).Negative();
            Arg.Validate(() => floatValue).Negative();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(0.01)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Negative_ValueMoreOrEqualsZero_Exception(double doubleValue)
        {
            var intValue = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => doubleValue).Negative(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => intValue).Negative(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => decimalValue).Negative(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => floatValue).Negative(); });
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-0.01)]
        [InlineData(-0.1)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        public void NegativeOrZero_ValueLessOrEqualsZero_Ok(double doubleValue)
        {
            var intValue = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Arg.Validate(() => doubleValue).NegativeOrZero();
            Arg.Validate(() => intValue).NegativeOrZero();
            Arg.Validate(() => decimalValue).NegativeOrZero();
            Arg.Validate(() => floatValue).NegativeOrZero();
        }

        [Theory]
        [InlineData(0.01)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void NegativeOrZero_ValueMoreThanZero_Exception(double doubleValue)
        {
            var intValue = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => doubleValue).NegativeOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => intValue).NegativeOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => decimalValue).NegativeOrZero(); });
            Assert.Throws<ArgumentOutOfRangeException>(() => { Arg.Validate(() => floatValue).NegativeOrZero(); });
        }

        [Fact]
        public void NotZero_ValueEqualsZero_Exception()
        {
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => 0.0).NotZero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => 0).NotZero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => 0M).NotZero(); });
            Assert.Throws<ArgumentException>(() => { Arg.Validate(() => 0F).NotZero(); });
        }

        [Fact]
        public void Zero_ValueEqualsZero_Ok()
        {
            Arg.Validate(() => 0.0).Zero();
            Arg.Validate(() => 0).Zero();
            Arg.Validate(() => 0M).Zero();
            Arg.Validate(() => 0F).Zero();
        }
    }
}