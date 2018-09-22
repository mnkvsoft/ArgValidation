using ArgValidation.Validators;
using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static class Validate
    {
        public static ObjectValidator<T> Obj<T>(Expression<Func<T>> arg)
        {
            var validatingObject = ValidatingObject<T>.FromExpression(arg);
            return new ObjectValidator<T>(validatingObject);
        }
    }
}
