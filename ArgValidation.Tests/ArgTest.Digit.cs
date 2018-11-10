using System;
using System.Linq.Expressions;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;

namespace ArgValidation.Tests
{
    public partial  class ArgTest
    {
	    public class DigitMethodsNameOfTest : DigitMethodsTestBase
	    {
		    protected override void RunPositive(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Positive(arg.Value, arg.Name);
		    }

		    protected override void RunPositive(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Positive(arg.Value, arg.Name);
		    }

		    protected override void RunPositive(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Positive(arg.Value, arg.Name);
		    }

		    protected override void RunPositive(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Positive(arg.Value, arg.Name);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.PositiveOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.PositiveOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.PositiveOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.PositiveOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunZero(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Zero(arg.Value, arg.Name);
		    }

		    protected override void RunZero(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Zero(arg.Value, arg.Name);
		    }

		    protected override void RunZero(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Zero(arg.Value, arg.Name);
		    }

		    protected override void RunZero(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Zero(arg.Value, arg.Name);
		    }

		    protected override void RunNotZero(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotZero(arg.Value, arg.Name);
		    }

		    protected override void RunNotZero(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotZero(arg.Value, arg.Name);
		    }

		    protected override void RunNotZero(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotZero(arg.Value, arg.Name);
		    }

		    protected override void RunNotZero(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotZero(arg.Value, arg.Name);
		    }

		    protected override void RunNegative(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Negative(arg.Value, arg.Name);
		    }

		    protected override void RunNegative(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Negative(arg.Value, arg.Name);
		    }

		    protected override void RunNegative(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Negative(arg.Value, arg.Name);
		    }

		    protected override void RunNegative(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Negative(arg.Value, arg.Name);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<double>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NegativeOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<int>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NegativeOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<decimal>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NegativeOrZero(arg.Value, arg.Name);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<float>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NegativeOrZero(arg.Value, arg.Name);
		    }
	    }

	    public class DigitMethodsExpressionThreeTest : DigitMethodsTestBase
	    {
		    protected override void RunPositive(Expression<Func<double>> value)
		    {
			    Arg.Positive(value);
		    }

		    protected override void RunPositive(Expression<Func<int>> value)
		    {
			    Arg.Positive(value);
		    }

		    protected override void RunPositive(Expression<Func<decimal>> value)
		    {
			    Arg.Positive(value);
		    }

		    protected override void RunPositive(Expression<Func<float>> value)
		    {
			    Arg.Positive(value);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<double>> value)
		    {
			    Arg.PositiveOrZero(value);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<int>> value)
		    {
			    Arg.PositiveOrZero(value);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<decimal>> value)
		    {
			    Arg.PositiveOrZero(value);
		    }

		    protected override void RunPositiveOrZero(Expression<Func<float>> value)
		    {
			    Arg.PositiveOrZero(value);
		    }

		    protected override void RunZero(Expression<Func<double>> value)
		    {
			    Arg.Zero(value);
		    }

		    protected override void RunZero(Expression<Func<int>> value)
		    {
			    Arg.Zero(value);
		    }

		    protected override void RunZero(Expression<Func<decimal>> value)
		    {
			    Arg.Zero(value);
		    }

		    protected override void RunZero(Expression<Func<float>> value)
		    {
			    Arg.Zero(value);
		    }

		    protected override void RunNotZero(Expression<Func<double>> value)
		    {
			    Arg.NotZero(value);
		    }

		    protected override void RunNotZero(Expression<Func<int>> value)
		    {
			    Arg.NotZero(value);
		    }

		    protected override void RunNotZero(Expression<Func<decimal>> value)
		    {
			    Arg.NotZero(value);
		    }

		    protected override void RunNotZero(Expression<Func<float>> value)
		    {
			    Arg.NotZero(value);
		    }

		    protected override void RunNegative(Expression<Func<double>> value)
		    {
			    Arg.Negative(value);
		    }

		    protected override void RunNegative(Expression<Func<int>> value)
		    {
			    Arg.Negative(value);
		    }

		    protected override void RunNegative(Expression<Func<decimal>> value)
		    {
			    Arg.Negative(value);
		    }

		    protected override void RunNegative(Expression<Func<float>> value)
		    {
			    Arg.Negative(value);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<double>> value)
		    {
			    Arg.NegativeOrZero(value);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<int>> value)
		    {
			    Arg.NegativeOrZero(value);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<decimal>> value)
		    {
			    Arg.NegativeOrZero(value);
		    }

		    protected override void RunNegativeOrZero(Expression<Func<float>> value)
		    {
			    Arg.NegativeOrZero(value);
		    }
	    }
    }
}
