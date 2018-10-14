using ArgValidation.Validators;
using System;
using System.Linq.Expressions;

namespace ArgValidation.Tests.Validators
{
    public partial class StringValidatorTest
    {
        private static StringValidator CreateStringValidator(Expression<Func<string>> arg)
        {
            var Argument = Argument<string>.FromExpression(arg);
            return new StringValidator(Argument);
        }
    }
}
