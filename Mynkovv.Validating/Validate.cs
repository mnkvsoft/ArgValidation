using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating
{
    public static class Validate
    {
        public static ObjectValidator<T> Obj<T>(Expression<Func<T>> arg)
        {
            var validatingObject = GetValidatingObjectFromExpression(arg);
            return new ObjectValidator<T>(validatingObject);
        }

        private static ValidatingObject<T> GetValidatingObjectFromExpression<T>(Expression<Func<T>> expression)
        {
           //TODO: нужно покрыть тестами

            Func<T> func = expression.Compile();
            T value = func();
            string name;
            if (expression.Body.NodeType == ExpressionType.Constant)
            {
                ConstantExpression c = (ConstantExpression)expression.Body;
                name = $"Static value '{value}'";
            }
            else
            {
                MemberExpression exp = (MemberExpression)expression.Body;
                name = exp.Member.Name;
            }

            return new ValidatingObject<T>(name, value);
        }
    }
}
