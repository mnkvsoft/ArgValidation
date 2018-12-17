using System;
using System.Linq.Expressions;

namespace ArgValidation.Internal
{
    internal static class ArgumentFactory
    {
        public static Argument<T> FromExpression<T>(Expression<Func<T>> expression)
        {
            T value = ExpressionHelper.GetArgumentValue(expression);
            string name = ExpressionHelper.GetArgumentName(expression);

            return new Argument<T>(value, name);
        }
    }
}
