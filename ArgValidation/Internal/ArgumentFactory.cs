using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    internal static class ArgumentFactory
    {
        public static Argument<T> FromExpression<T>(Expression<Func<T>> expression)
        {
            Func<T> func = expression.Compile();
            T value = func();

            string name;
            if (expression.Body.NodeType == ExpressionType.Constant)
            {
                name = $"Static value '{value}'";

            }
            else if (expression.Body.NodeType == ExpressionType.New)
            {
                name = $"Static value '{value}'";
            }
            else
            {
                MemberExpression exp = (MemberExpression) expression.Body;
                name = exp.Member.Name;
            }

            return new Argument<T>(value, name);
        }
    }
}
