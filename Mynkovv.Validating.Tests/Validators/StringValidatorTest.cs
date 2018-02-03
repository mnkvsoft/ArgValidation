using Mynkovv.Validating.Validators;
using System;
using System.Linq.Expressions;

namespace Mynkovv.Validating.Tests.Validators
{
    public partial class StringValidatorTest
    {
        private static StringValidator CreateStringValidator(Expression<Func<string>> arg)
        {
            var validatingObject = ValidatingObject<string>.FromExpression(arg);
            return new StringValidator(validatingObject);
        }
    }
}
