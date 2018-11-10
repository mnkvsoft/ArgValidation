using System;
using System.Linq.Expressions;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;

namespace ArgValidation.Tests
{
    public partial  class ArgTest
    {
	    public class ObjectMethodsExpressionThreeTest : ObjectSimpleMethodsTestBase
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
	    
	    public class ObjectMethodsNameOfTest : ObjectSimpleMethodsTestBase
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
    }
}
