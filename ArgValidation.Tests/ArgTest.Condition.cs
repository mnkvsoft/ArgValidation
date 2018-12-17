using System;
using System.Linq.Expressions;
using Xunit;

namespace ArgValidation.Tests
{
    public partial class ArgTest
    {
        public class ConditionNameOfTest : ConditionTestBase
        {
            protected override Argument<T> RunForNullableValueType<T>(Expression<Func<T?>> value)
            {
                var arg = Arg.Validate(value);
                return Arg.IfNotNull(arg.Value, arg.Name);
            }

            protected override Argument<T> RunForReferenceType<T>(Expression<Func<T>> value)
            {
                var arg = Arg.Validate(value);
                return Arg.IfNotNull(arg.Value, arg.Name);
            }
        }

        public class ConditionExpressionThreeTest : ConditionTestBase
        {
            protected override Argument<T> RunForNullableValueType<T>(Expression<Func<T?>> value)
            {
                return Arg.IfNotNull(value);
            }

            protected override Argument<T> RunForReferenceType<T>(Expression<Func<T>> value)
            {
                return Arg.IfNotNull(value);
            }
        }
    }
}