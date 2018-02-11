using Mynkovv.Validating.Validators;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        private static EnumerableValidator<T> CreateEnumerableValidator<T>(Expression<Func<IEnumerable<T>>> arg)
        {
            var validatingObject = ValidatingObject<IEnumerable<T>>.FromExpression(arg);
            return new EnumerableValidator<T>(validatingObject);
        }
    }
}
