using System;
using System.Linq.Expressions;
using ArgValidation.Validators;

namespace ArgValidation.Tests.Validators.ComparableValidator
{
    public partial class ComparableValidatorTest
    {
        private static ComparableValidator<T> CreateObjectValidator<T>(Expression<Func<T>> arg) where T : IComparable<T> 
        {
            var Argument = Argument<T>.FromExpression(arg);
            return new ComparableValidator<T>(Argument);
        }
    }
}
