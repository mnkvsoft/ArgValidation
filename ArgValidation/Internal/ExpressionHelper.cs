using System;
using System.Linq.Expressions;

namespace ArgValidation.Internal
{
    internal static class ExpressionHelper
    {
        public static T GetArgumentValue<T>(Expression<Func<T>> expression)
        {
            Func<T> func = expression.Compile();
            T value = func();
            return value;
        }

        public static string GetArgumentName<T>(Expression<Func<T>> expression)
        {
            string name;
            if (expression.Body.NodeType == ExpressionType.Constant || expression.Body.NodeType == ExpressionType.New)
            {
                name = "Static value";
            }
            else
            {
                MemberExpression exp = (MemberExpression)expression.Body;
                name = exp.Member.Name;
            }

            return name;
        }
    }
}
