using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests
{
    public class DigitMethodsTest : DigitMethodsTestBase
    {
        protected override void RunPositive(Expression<Func<double>> value)
        {
            Arg.Validate(value).Positive();
        }

        protected override void RunPositive(Expression<Func<int>> value)
        {
            Arg.Validate(value).Positive();
        }

        protected override void RunPositive(Expression<Func<long>> value)
        {
            Arg.Validate(value).Positive();
        }

        protected override void RunPositive(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).Positive();
        }

        protected override void RunPositive(Expression<Func<float>> value)
        {
            Arg.Validate(value).Positive();
        }

        protected override void RunPositiveOrZero(Expression<Func<double>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunPositiveOrZero(Expression<Func<int>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunPositiveOrZero(Expression<Func<long>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunPositiveOrZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunPositiveOrZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunZero(Expression<Func<byte>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<double>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<int>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<long>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunNotZero(Expression<Func<byte>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNotZero(Expression<Func<double>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNotZero(Expression<Func<long>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNotZero(Expression<Func<int>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNotZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNotZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).NotZero();
        }

        protected override void RunNegative(Expression<Func<double>> value)
        {
            Arg.Validate(value).Negative();
        }

        protected override void RunNegative(Expression<Func<int>> value)
        {
            Arg.Validate(value).Negative();
        }

        protected override void RunNegative(Expression<Func<long>> value)
        {
            Arg.Validate(value).Negative();
        }

        protected override void RunNegative(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).Negative();
        }

        protected override void RunNegative(Expression<Func<float>> value)
        {
            Arg.Validate(value).Negative();
        }

        protected override void RunNegativeOrZero(Expression<Func<double>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        protected override void RunNegativeOrZero(Expression<Func<int>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        protected override void RunNegativeOrZero(Expression<Func<long>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        protected override void RunNegativeOrZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        protected override void RunNegativeOrZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        #region PositiveCustomException

        [Fact]
        public void PositiveInt32_WithCustomException_CustomTypeException()
        {
            int value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Positive());

            CustomAssert.MessageForPositiveMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveInt64_WithCustomException_CustomTypeException()
        {
            long value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Positive());

            CustomAssert.MessageForPositiveMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Positive());

            CustomAssert.MessageForPositiveMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveDouble_WithCustomException_CustomTypeException()
        {
            double value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Positive());

            CustomAssert.MessageForPositiveMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveFloat_WithCustomException_CustomTypeException()
        {
            float value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Positive());

            CustomAssert.MessageForPositiveMethodIsValid(value, exc);
        }

        #endregion


        #region PositiveOrZeroCustomException

        [Fact]
        public void PositiveOrZeroInt32_WithCustomException_CustomTypeException()
        {
            int value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .PositiveOrZero());

            CustomAssert.MessageForPositiveOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveOrZeroInt64_WithCustomException_CustomTypeException()
        {
            long value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .PositiveOrZero());

            CustomAssert.MessageForPositiveOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveOrZeroDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .PositiveOrZero());

            CustomAssert.MessageForPositiveOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveOrZeroDouble_WithCustomException_CustomTypeException()
        {
            double value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .PositiveOrZero());

            CustomAssert.MessageForPositiveOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void PositiveOrZeroFloat_WithCustomException_CustomTypeException()
        {
            float value = -1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .PositiveOrZero());

            CustomAssert.MessageForPositiveOrZeroMethodIsValid(value, exc);
        }

        #endregion


        #region NegativeCustomException

        [Fact]
        public void NegativeInt32_WithCustomException_CustomTypeException()
        {
            int value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Negative());

            CustomAssert.MessageForNegativeMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeInt64_WithCustomException_CustomTypeException()
        {
            long value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Negative());

            CustomAssert.MessageForNegativeMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Negative());

            CustomAssert.MessageForNegativeMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeDouble_WithCustomException_CustomTypeException()
        {
            double value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Negative());

            CustomAssert.MessageForNegativeMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeFloat_WithCustomException_CustomTypeException()
        {
            float value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Negative());

            CustomAssert.MessageForNegativeMethodIsValid(value, exc);
        }

        #endregion

        #region NegativeOrZeroCustomException

        [Fact]
        public void NegativeOrZeroInt32_WithCustomException_CustomTypeException()
        {
            int value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NegativeOrZero());

            CustomAssert.MessageForNegativeOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeOrZeroInt64_WithCustomException_CustomTypeException()
        {
            long value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NegativeOrZero());

            CustomAssert.MessageForNegativeOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeOrZeroDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NegativeOrZero());

            CustomAssert.MessageForNegativeOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeOrZeroDouble_WithCustomException_CustomTypeException()
        {
            double value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NegativeOrZero());

            CustomAssert.MessageForNegativeOrZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NegativeOrZeroFloat_WithCustomException_CustomTypeException()
        {
            float value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NegativeOrZero());

            CustomAssert.MessageForNegativeOrZeroMethodIsValid(value, exc);
        }

        #endregion

        #region ZeroCustomException

        [Fact]
        public void ZeroInt32_WithCustomException_CustomTypeException()
        {
            int value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Zero());

            CustomAssert.MessageForZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void ZeroInt64_WithCustomException_CustomTypeException()
        {
            long value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Zero());

            CustomAssert.MessageForZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void ZeroDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Zero());

            CustomAssert.MessageForZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void ZeroDouble_WithCustomException_CustomTypeException()
        {
            double value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Zero());

            CustomAssert.MessageForZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void ZeroFloat_WithCustomException_CustomTypeException()
        {
            float value = 1;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .Zero());

            CustomAssert.MessageForZeroMethodIsValid(value, exc);
        }

        #endregion

        #region NotZeroCustomException

        [Fact]
        public void NotZeroInt32_WithCustomException_CustomTypeException()
        {
            int value = 0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotZero());

            CustomAssert.MessageForNotZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NotZeroInt64_WithCustomException_CustomTypeException()
        {
            long value = 0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotZero());

            CustomAssert.MessageForNotZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NotZeroDecimal_WithCustomException_CustomTypeException()
        {
            decimal value = 0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotZero());

            CustomAssert.MessageForNotZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NotZeroDouble_WithCustomException_CustomTypeException()
        {
            double value = 0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotZero());

            CustomAssert.MessageForNotZeroMethodIsValid(value, exc);
        }

        [Fact]
        public void NotZeroFloat_WithCustomException_CustomTypeException()
        {
            float value = 0;

            CustomException exc = Assert.Throws<CustomException>(() =>
                Arg.Validate(value, nameof(value))
                    .With<CustomException>()
                    .NotZero());

            CustomAssert.MessageForNotZeroMethodIsValid(value, exc);
        }

        #endregion

        private static class CustomAssert
        {
            public static void MessageForPositiveMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"Argument 'value' must be more than '0'. Current value: '{value}'", exc.Message);
            }

            public static void MessageForPositiveOrZeroMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"The minimum value for the argument 'value' is '0'. Current value: '{value}'", exc.Message);
            }

            public static void MessageForNegativeMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"Argument 'value' must be less than '0'. Current value: '{value}'", exc.Message);
            }

            public static void MessageForNegativeOrZeroMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"The maximum value for the argument 'value' is '0'. Current value: '{value}'", exc.Message);
            }

            public static void MessageForZeroMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"Argument 'value' must be equal '0'. Current value: '{value}'", exc.Message);
            }

            public static void MessageForNotZeroMethodIsValid<T>(T value, CustomException exc)
            {
                Assert.Equal($"Argument 'value' must be not equal '{value}'", exc.Message);
            }
        }
    }
}