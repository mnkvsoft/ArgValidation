using System;
using System.Linq.Expressions;
using ArgValidation.Tests.ObjectValidationTests;
using Xunit;

namespace ArgValidation.Tests
{
    public partial  class ArgTest
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
    }
}
