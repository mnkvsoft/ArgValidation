using System;
using System.Linq.Expressions;
using ArgValidation.Tests.EnumValidationTests;

namespace ArgValidation.Tests
{
    public partial class ArgTest
    {
	    public class EnumMethodsExpressionThreeTest : EnumSingleMethodsTestBase
        {
            protected override void RunDefinedInEnum<TEnum>(Expression<Func<TEnum>> value)
            {
                Arg.DefinedInEnum(value);
            }
        }
	    
	    public class EnumMethodsNameOfTest : EnumSingleMethodsTestBase
        {
            protected override void RunDefinedInEnum<TEnum>(Expression<Func<TEnum>> value)
            {
                var arg = Arg.Validate(value);
                Arg.DefinedInEnum(arg.Value, arg.Name);
            }
        }
    }
}
