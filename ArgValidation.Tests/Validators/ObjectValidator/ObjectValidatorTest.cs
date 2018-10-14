using ArgValidation.Validators;
using System;
using System.Linq.Expressions;

namespace ArgValidation.Tests.Validators.ObjectValidator
{
    public partial class ObjectValidatorTest
    {
        private static ObjectValidator<T> CreateObjectValidator<T>(Expression<Func<T>> arg) 
        {
            var Argument = Argument<T>.FromExpression(arg);
            return new ObjectValidator<T>(Argument);
        }
    }
}
