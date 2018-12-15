using System;
using System.Linq.Expressions;

namespace ArgValidation.Internal
{
    internal static class ArgumentFactory
    {
        public static Argument<T> FromExpression<T>(Expression<Func<T>> expression)
        {
            T value = GetArgumentValue(expression);
            string name = GetArgumentName(expression);

            return new Argument<T>(value, name);
        }

        public static T GetArgumentValue<T>(Expression<Func<T>> expression)
        {
            Func<T> func = expression.Compile();
            T value = func();
            return value;
        }

        public static string GetArgumentName<T>(Expression<Func<T>> expression)
        {
            ExpressionType expressionType = expression.Body.NodeType;
            if (expressionType == ExpressionType.Constant || expressionType == ExpressionType.New)
                return "Static value";

            MemberExpression exp = (MemberExpression)expression.Body;
            return exp.Member.Name;
        }
    }
}
