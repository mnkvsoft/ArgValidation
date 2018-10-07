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

        public static ObjectValidator<T> CreateObjectValidator<T>(T value, string argName)
        {
            return new ObjectValidator<T>(new ValidatingObject<T>(value, argName));
        }
        
        public static ComparableValidator<T> CreateComparableValidator<T>(Expression<Func<T>> value) where T : IComparable<T>
        {
            var validatingObj = ValidatingObject<T>.FromExpression(value);
            var validator = new ComparableValidator<T>(validatingObj);
            return validator;
        }
        
        public static ComparableValidator<T> CreateComparableValidator<T>(T value, string argName) where T : IComparable<T>
        {
            return new ComparableValidator<T>(new ValidatingObject<T>(value, argName));
        }
        
        public static EnumerableValidator<T> CreateEnumerableValidator<T>(Expression<Func<IEnumerable<T>>> value)
        {
            var validatingObj = ValidatingObject<IEnumerable<T>>.FromExpression(value);
            var validator = new EnumerableValidator<T>(validatingObj);
            return validator;
        }
        
        public static EnumerableValidator<T> CreateEnumerableValidator<T>(IEnumerable<T> value, string argName)
        {
            return new EnumerableValidator<T>(new ValidatingObject<IEnumerable<T>>(value, argName));
        }
        
        public static StringValidator CreateStringValidator(Expression<Func<string>> value)
        {
            var validatingObj = ValidatingObject<string>.FromExpression(value);
            var validator = new StringValidator(validatingObj);
            return validator;
        }
        
        public static StringValidator CreateStringValidator(string value, string argName)
        {
            return new StringValidator (new ValidatingObject<string>(value, argName));
        }
    }
}