using System;
using System.Linq.Expressions;

namespace ArgValidation.Tests.EnumValidationTests
{
    public partial class ArgumentEnumExtensionTest : EnumSingleMethodsTestBase
    {
        protected override void RunDefinedInEnum<T>(Expression<Func<T>> value)
        {
            Arg.Validate(value).DefinedInEnum();
        }
    }
}