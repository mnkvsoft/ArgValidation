using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating
{
    public static class Validate
    {
        public static ObjectValidator<T> Obj<T>(Expression<Func<T>> arg)
        {
            var validatingObject = new Argument<T>(arg);
            return new ObjectValidator<T>(validatingObject);
        }
    }
}
