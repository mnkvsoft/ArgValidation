using System;
using System.Linq.Expressions;

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

        protected override void RunPositiveOrZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunPositiveOrZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).PositiveOrZero();
        }

        protected override void RunZero(Expression<Func<double>> value)
        {
            Arg.Validate(value).Zero();
        }

        protected override void RunZero(Expression<Func<int>> value)
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

        protected override void RunNotZero(Expression<Func<double>> value)
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

        protected override void RunNegativeOrZero(Expression<Func<decimal>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }

        protected override void RunNegativeOrZero(Expression<Func<float>> value)
        {
            Arg.Validate(value).NegativeOrZero();
        }
    }
}