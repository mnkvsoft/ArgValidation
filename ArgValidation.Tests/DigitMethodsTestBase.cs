using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests
{
    public abstract class DigitMethodsTestBase
    {
        protected abstract void RunPositive(Expression<Func<double>> value); 
        protected abstract void RunPositive(Expression<Func<int>> value);
        protected abstract void RunPositive(Expression<Func<long>> value);
        protected abstract void RunPositive(Expression<Func<decimal>> value); 
        protected abstract void RunPositive(Expression<Func<float>> value); 
        
        protected abstract void RunPositiveOrZero(Expression<Func<double>> value); 
        protected abstract void RunPositiveOrZero(Expression<Func<int>> value);
        protected abstract void RunPositiveOrZero(Expression<Func<long>> value);
        protected abstract void RunPositiveOrZero(Expression<Func<decimal>> value); 
        protected abstract void RunPositiveOrZero(Expression<Func<float>> value); 
        
        protected abstract void RunZero(Expression<Func<double>> value); 
        protected abstract void RunZero(Expression<Func<int>> value);
        protected abstract void RunZero(Expression<Func<long>> value);
        protected abstract void RunZero(Expression<Func<decimal>> value); 
        protected abstract void RunZero(Expression<Func<float>> value); 
        
        protected abstract void RunNotZero(Expression<Func<double>> value);
        protected abstract void RunNotZero(Expression<Func<int>> value);
        protected abstract void RunNotZero(Expression<Func<long>> value);
        protected abstract void RunNotZero(Expression<Func<decimal>> value);
        protected abstract void RunNotZero(Expression<Func<float>> value);
        
        protected abstract void RunNegative(Expression<Func<double>> value); 
        protected abstract void RunNegative(Expression<Func<int>> value);
        protected abstract void RunNegative(Expression<Func<long>> value);
        protected abstract void RunNegative(Expression<Func<decimal>> value); 
        protected abstract void RunNegative(Expression<Func<float>> value); 
        
        protected abstract void RunNegativeOrZero(Expression<Func<double>> value); 
        protected abstract void RunNegativeOrZero(Expression<Func<int>> value);
        protected abstract void RunNegativeOrZero(Expression<Func<long>> value);
        protected abstract void RunNegativeOrZero(Expression<Func<decimal>> value); 
        protected abstract void RunNegativeOrZero(Expression<Func<float>> value); 
        
        [Theory]
        [InlineData(0.01)]
        [InlineData(0.1)]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void Positive_ValueMoreThanZero_Ok(double doubleValue)
        {
            var intValue = (int)Math.Ceiling(doubleValue);
            var longValue = (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            RunPositive(() => doubleValue);
            RunPositive(() => intValue);
            RunPositive(() => longValue);
            RunPositive(() => decimalValue);
            RunPositive(() => floatValue);
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
            var longValue = (long)Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositive(() => doubleValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositive(() => intValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositive(() => longValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositive(() => decimalValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositive(() => floatValue));
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
            var longValue = (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            RunPositiveOrZero(() => doubleValue);
            RunPositiveOrZero(() => intValue);
            RunPositiveOrZero(() => longValue);
            RunPositiveOrZero(() => decimalValue);
            RunPositiveOrZero(() => floatValue);
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
            var longValue = (long)Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositiveOrZero(() => doubleValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositiveOrZero(() => intValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositiveOrZero(() => longValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositiveOrZero(() => decimalValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunPositiveOrZero(() => floatValue));
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
            var longValue = doubleValue < 0 ? (long)Math.Floor(doubleValue) : (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentException>(() => RunZero(() => doubleValue));
            Assert.Throws<ArgumentException>(() => RunZero(() => intValue));
            Assert.Throws<ArgumentException>(() => RunZero(() => longValue));
            Assert.Throws<ArgumentException>(() => RunZero(() => decimalValue));
            Assert.Throws<ArgumentException>(() => RunZero(() => floatValue));
        }

        [Fact]
        public void Zero_ValueEqualsZero_Ok()
        {
            RunZero(() => 0.0);
            RunZero(() => 0);
            RunZero(() => 0L);
            RunZero(() => 0M);
            RunZero(() => 0F);
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
            var longValue = doubleValue < 0 ? (long)Math.Floor(doubleValue) : (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            RunNotZero(() => doubleValue);
            RunNotZero(() => intValue);
            RunNotZero(() => decimalValue);
            RunNotZero(() => floatValue);
        }
        
        [Fact]
        public void NotZero_ValueEqualsZero_Exception()
        {
            Assert.Throws<ArgumentException>(() => RunNotZero(() => 0.0));
            Assert.Throws<ArgumentException>(() => RunNotZero(() => 0));
            Assert.Throws<ArgumentException>(() => RunNotZero(() => 0L));
            Assert.Throws<ArgumentException>(() => RunNotZero(() => 0M));
            Assert.Throws<ArgumentException>(() => RunNotZero(() => 0F));
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
            var longValue = (long)Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            RunNegative(() => doubleValue);
            RunNegative(() => intValue);
            RunNegative(() => longValue);
            RunNegative(() => decimalValue);
            RunNegative(() => floatValue);
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
            var longValue = (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegative(() => doubleValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegative(() => intValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegative(() => longValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegative(() => decimalValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegative(() => floatValue));
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
            var longValue = (long)Math.Floor(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            RunNegativeOrZero(() => doubleValue);
            RunNegativeOrZero(() => intValue);
            RunNegativeOrZero(() => longValue);
            RunNegativeOrZero(() => decimalValue);
            RunNegativeOrZero(() => floatValue);
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
            var longValue = (long)Math.Ceiling(doubleValue);
            var decimalValue = (decimal) doubleValue;
            var floatValue = (float) doubleValue;

            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegativeOrZero(() => doubleValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegativeOrZero(() => intValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegativeOrZero(() => longValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegativeOrZero(() => decimalValue));
            Assert.Throws<ArgumentOutOfRangeException>(() => RunNegativeOrZero(() => floatValue));
        }
    }
}