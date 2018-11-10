using System;
using System.Linq.Expressions;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;

namespace ArgValidation.Tests
{
    public partial class ArgTest
    {
	    public class StringMethodsExpressionThreeTest : StringValidationTests.StringSimpleMethodsTestBase
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
	    
	    public class StringMethodsNameOfTest : StringValidationTests.StringSimpleMethodsTestBase
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
    }
}
