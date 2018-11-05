using System;
using System.Linq.Expressions;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;
using StringSingleMethodsTestBase = ArgValidation.Tests.StringValidationTests.StringSingleMethodsTestBase;

namespace ArgValidation.Tests
{
    public class ArgTest
    {
		[Fact]
        public void Validate_NameOf_Ok()
		{
			int argValue = 5;
			string argName = nameof(argValue);
			
		    var argument = Arg.Validate(argValue, argName);
			
			Assert.Equal(argValue, argument.Value);
			Assert.Equal(argName, argument.Name);
		}
	    
	    [Fact]
	    public void Validate_ExpressionThree_Ok()
	    {
		    int argValue = 5;
			
		    var argument = Arg.Validate(() => argValue);
			
		    Assert.Equal(argValue, argument.Value);
		    Assert.Equal(nameof(argValue), argument.Name);
	    }
	    
	    public class StringMethodsExpressionThreeTest : StringValidationTests.StringSingleMethodsTestBase
	    {
		    protected override void RunNullOrWhitespace(Expression<Func<string>> value)
		    {
			    Arg.NullOrWhitespace(value);
		    }

		    protected override void RunNotNullOrWhitespace(Expression<Func<string>> value)
		    {
			    Arg.NotNullOrWhitespace(value);
		    }

		    protected override void RunNullOrEmpty(Expression<Func<string>> value)
		    {
			    Arg.NullOrEmpty(value);
		    }

		    protected override void RunNotNullOrEmpty(Expression<Func<string>> value)
		    {
			    Arg.NotNullOrEmpty(value);
		    }
	    }
	    
	    public class StringMethodsNameOfTest : StringValidationTests.StringSingleMethodsTestBase
	    {
		    protected override void RunNullOrWhitespace(Expression<Func<string>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NullOrWhitespace(arg.Value, arg.Name);
		    }

		    protected override void RunNotNullOrWhitespace(Expression<Func<string>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotNullOrWhitespace(arg.Value, arg.Name);
		    }

		    protected override void RunNullOrEmpty(Expression<Func<string>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NullOrEmpty(arg.Value, arg.Name);
		    }

		    protected override void RunNotNullOrEmpty(Expression<Func<string>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotNullOrEmpty(arg.Value, arg.Name);
		    }
	    }
	    
	    public class ObjectMethodsExpressionThreeTest : ObjectSingleMethodsTestBase
	    {
		    protected override void RunNull<T>(Expression<Func<T>> value)
		    {
			    Arg.Null(value);
		    }

		    protected override void RunNotNull<T>(Expression<Func<T>> value)
		    {
			    Arg.NotNull(value);
		    }

		    protected override void RunNotDefault<T>(Expression<Func<T>> value)
		    {
			    Arg.NotDefault(value);
		    }

		    protected override void RunDefault<T>(Expression<Func<T>> value)
		    {
			    Arg.Default(value);
		    }
	    }
	    
	    public class ObjectMethodsNameOfTest : ObjectSingleMethodsTestBase
	    {
		    protected override void RunNull<T>(Expression<Func<T>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Null(arg.Value, arg.Name);
		    }

		    protected override void RunNotNull<T>(Expression<Func<T>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotNull(arg.Value, arg.Name);
		    }

		    protected override void RunNotDefault<T>(Expression<Func<T>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotDefault(arg.Value, arg.Name);
		    }

		    protected override void RunDefault<T>(Expression<Func<T>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Default(arg.Value, arg.Name);
		    }
	    }

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
