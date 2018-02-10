using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        private static ObjectValidator<T> CreateObjectValidator<T>(Expression<Func<T>> arg)
        {
            var validatingObject = ValidatingObject<T>.FromExpression(arg);
            return new ObjectValidator<T>(validatingObject);
        }
    }
}
