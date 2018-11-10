using System;
using System.Collections;
using System.Linq.Expressions;
using ArgValidation.Tests.EnumerableValidationTests;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;

namespace ArgValidation.Tests
{
    public partial class ArgTest
    {
	    public class EnumerableMethodsExpressionThreeTest : EnumerableSimpleMethodsTestBase
	    {
		    protected override void RunNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    Arg.NullOrEmpty(value);
		    }

		    protected override void RunNotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    Arg.NotNullOrEmpty(value);
		    }

		    protected override void RunNotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    Arg.NotEmpty(value);
		    }

		    protected override void RunEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    Arg.Empty(value);
		    }
	    }
	    
	    public class EnumerableMethodsNameOfTest : EnumerableSimpleMethodsTestBase
	    {
		    protected override void RunNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NullOrEmpty(arg.Value, arg.Name);
		    }

		    protected override void RunNotNullOrEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotNullOrEmpty(arg.Value, arg.Name);
		    }

		    protected override void RunNotEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.NotEmpty(arg.Value, arg.Name);
		    }

		    protected override void RunEmpty<TEnumerable>(Expression<Func<TEnumerable>> value)
		    {
			    var arg = Arg.Validate(value);
			    Arg.Empty(arg.Value, arg.Name);
		    }
	    }
    }
}
