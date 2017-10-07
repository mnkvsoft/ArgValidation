using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating
{
    public static class Validate
    {
        public static ObjectValidator<T> Argument<T>(Expression<Func<T>> arg)
        {
            var validatingObject = GetValidatingObjectFromExpression(arg);
            return new ObjectValidator<T>(validatingObject);
        }

        private static ValidatingObject<T> GetValidatingObjectFromExpression<T>(Expression<Func<T>> expression)
        {
            MemberExpression exp = (MemberExpression)expression.Body;
            string name = exp.Member.Name;
            Func<T> func = expression.Compile();
            T value = func();

            return new ValidatingObject<T>(name, value);
        }
    }
}
