using System;
using System.Linq.Expressions;
using ArgValidation.Validators;
using System.Collections.Generic;

namespace ArgValidation
{
    public static class Arg
    {
        public static ObjectValidator<T> Default<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).Default();
        }

        public static ObjectValidator<T> NotDefault<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotDefault();
        }
        
        public static ObjectValidator<T> Null<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).Null();
        }
        
        public static ObjectValidator<T> NotNull<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotNull();
        }
        
        
        
        public static StringValidator NullOrEmpty<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrEmpty();
        }
        
        public static StringValidator NotNullOrEmpty<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrEmpty();
        }
        
        public static StringValidator NullOrWhitespace<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrWhitespace();
        }
        
        public static StringValidator NotNullOrWhitespace<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrWhitespace();
        }
        
        
        
        public static ObjectValidator<T> Validate<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value);
        }
        
        public static StringValidator Validate(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value);
        }
        
        public static EnumerableValidator<T> Validate<T>(Expression<Func<IEnumerable<T>>> value)
        {
            return ValidatorFactory.CreateEnumerableValidator(value);
        }
    }
}