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
            var inT = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => doubleValue)).Positive();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => inT)).Positive();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => decimalValue)).Positive();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => floaT)).Positive();
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
            var inT = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => doubleValue)).Positive();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => inT)).Positive();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => decimalValue)).Positive();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => floaT)).Positive();
            });
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
            var inT = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => doubleValue)).PositiveOrZero();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => inT)).PositiveOrZero();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => decimalValue)).PositiveOrZero();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => floaT)).PositiveOrZero();
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
            var inT = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => doubleValue)).PositiveOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => inT)).PositiveOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => decimalValue)).PositiveOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => floaT)).PositiveOrZero();
            });
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
            var inT = doubleValue < 0 ? (int) Math.Floor(doubleValue) : (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            Assert.Throws<ArgumentException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => doubleValue)).Zero();
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => inT)).Zero();
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => decimalValue)).Zero();
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => floaT)).Zero();
            });
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
            var inT = doubleValue < 0 ? (int) Math.Floor(doubleValue) : (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => doubleValue)).NotZero();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => inT)).NotZero();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => decimalValue)).NotZero();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => floaT)).NotZero();
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
            var inT = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => doubleValue)).Negative();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => inT)).Negative();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => decimalValue)).Negative();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => floaT)).Negative();
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
            var inT = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => doubleValue)).Negative();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => inT)).Negative();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => decimalValue)).Negative();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => floaT)).Negative();
            });
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
            var inT = (int) Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => doubleValue)).NegativeOrZero();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => inT)).NegativeOrZero();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => decimalValue)).NegativeOrZero();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => floaT)).NegativeOrZero();
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
            var inT = (int) Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floaT = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => doubleValue)).NegativeOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => inT)).NegativeOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => decimalValue)).NegativeOrZero();
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => floaT)).NegativeOrZero();
            });
        }

        [Fact]
        public void NotZero_ValueEqualsZero_Exception()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var doubleValidator = new ComparableValidator<double>(
                    ValidatingObject<double>.FromExpression(() => 0.0)).NotZero();
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var intValidator = new ComparableValidator<int>(
                    ValidatingObject<int>.FromExpression(() => 0)).NotZero();
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var decimalValidator = new ComparableValidator<decimal>(
                    ValidatingObject<decimal>.FromExpression(() => 0M)).NotZero();
            });
            Assert.Throws<ArgumentException>(() =>
            {
                var floatValidator = new ComparableValidator<float>(
                    ValidatingObject<float>.FromExpression(() => 0F)).NotZero();
            });
        }

        [Fact]
        public void Zero_ValueEqualsZero_Ok()
        {
            var doubleValidator = new ComparableValidator<double>(
                ValidatingObject<double>.FromExpression(() => 0.0)).Zero();

            var intValidator = new ComparableValidator<int>(
                ValidatingObject<int>.FromExpression(() => 0)).Zero();

            var decimalValidator = new ComparableValidator<decimal>(
                ValidatingObject<decimal>.FromExpression(() => 0M)).Zero();

            var floatValidator = new ComparableValidator<float>(
                ValidatingObject<float>.FromExpression(() => 0F)).Zero();
        }
    }
}