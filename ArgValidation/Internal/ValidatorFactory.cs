using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ArgValidation.Validators;

namespace ArgValidation.Internal
{
    internal static class ValidatorFactory
    {
        public static ObjectValidator<T> CreateObjectValidator<T>(Expression<Func<T>> value)
        {
            var validatingObj = ValidatingObject<T>.FromExpression(value);
            var validator = new ObjectValidator<T>(validatingObj);
            return validator;
        }
        
        public static ComparableValidator<T> CreateComparableValidator<T>(Expression<Func<T>> value) where T : IComparable<T>
        {
            var validatingObj = ValidatingObject<T>.FromExpression(value);
            var validator = new ComparableValidator<T>(validatingObj);
            return validator;
        }
        
        public static EnumerableValidator<T> CreateEnumerableValidator<T>(Expression<Func<IEnumerable<T>>> value)
        {
            var validatingObj = ValidatingObject<IEnumerable<T>>.FromExpression(value);
            var validator = new EnumerableValidator<T>(validatingObj);
            return validator;
        }
        
        public static StringValidator CreateStringValidator(Expression<Func<string>> value)
        {
            var validatingObj = ValidatingObject<string>.FromExpression(value);
            var validator = new StringValidator(validatingObj);
            return validator;
        }
    }
}