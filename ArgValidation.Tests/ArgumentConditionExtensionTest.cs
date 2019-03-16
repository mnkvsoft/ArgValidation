using System;
using System.Linq.Expressions;

namespace ArgValidation.Tests
{
    public class ArgumentConditionExtensionTest : ConditionTestBase
    {
        protected override Argument<T> RunForNullableValueType<T>(Expression<Func<T?>> value)
        {
            return Arg.Validate(value).IfNotNull();
        }

        protected override Argument<T> RunForReferenceType<T>(Expression<Func<T>> value)
        {
            return Arg.Validate(value).IfNotNull();
        }
    }
}
